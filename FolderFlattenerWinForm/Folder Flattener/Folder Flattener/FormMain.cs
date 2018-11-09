using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Folder_Flattener
{
    public partial class FormMain : Form
    {
        #region Variables

        const string PlaylistFile = ".wpl";
        const string ImageFiles = ".png;.bmp;.gif;.jpg";
        const string XMLFile = ".xml";
        const string AllValidFileTypes = ".wpl;.png;.bmp;.gif;.jpg;.xml";
        string LastValidLoadedFileType = "";
        string fileName;
        DataTable OpenListTable = new DataTable("Open List Table");
        DataTable ExportTable = new DataTable("Export Table");
        /// <summary>
        /// Represents the file list being loaded
        /// </summary>
        bool OpenListPopulated = false;
        /// <summary>
        /// Represents the source folder for wpl entries with incomplete filename directories
        /// </summary>
        bool SourceFolderSet = false;
        /// <summary>
        /// Represents the currently-selected list has been copied to the export table.
        /// </summary>
        bool IsPreviewed;
        bool ExportPathSet = false;

        const int FILE_NAME_COL_IND = 0;

        /// <summary>
        /// Represents a table generation for either export folder selection or export preview
        /// </summary>
        bool IsExport = false;
        string ExportPath;

        List<XmlNode> FileList = new List<XmlNode>();

        DataGridViewCellStyle DupCell = new DataGridViewCellStyle()
        {
            BackColor = Color.Red
        };

        ConfirmationForm Confirm = new ConfirmationForm();

        List<XmlNode> ErroredSongs = new List<XmlNode>();
        XmlDocument XDoc = new XmlDocument();

        SongErrors ErrorForm = new SongErrors();

        #endregion

        public FormMain()
        {
            InitializeComponent();
        }

        #region Custom Methods

        /// <summary>
        /// Creates an in-memory table holding information for the particular
        /// file extension chosen.
        /// </summary>
        /// <param name="FileExtension">The file extension used to craft the table</param>
        private void MakeOpenListDataTable(string FileExtension = PlaylistFile)
        {
            OpenListTable.Columns.Clear();
            OpenListTable.Rows.Clear();

            if (ImageFiles.Split(';').Contains(FileExtension) || FileExtension == PlaylistFile && !IsExport)
            {
                if (FileList[0].Attributes.GetNamedItem("trackArtist") != null)
                {
                    OpenListTable = FormLib.MakeTable(FormLib.TableTypes.OpenList);
                }
                else
                {
                    OpenListTable = FormLib.MakeTable(FormLib.TableTypes.Default);
                }
            }
            else if (FileExtension == XMLFile)
            {
                OpenListTable = FormLib.MakeTable(FormLib.TableTypes.Default);
            }
        }

        private void ShowSourceFolderDialog()
        {
            fbd_SourceMusicFolder.ShowDialog();
        }

        private void SearchForDuplicates(DataGridView Data)
        {
            foreach (DataGridViewRow row in Data.Rows)
            {
                //TODO: Find row duplicates

                foreach (DataGridViewRow rowInner in Data.Rows)
                {
                    if (row.Index != rowInner.Index
                        && (row.Cells[FILE_NAME_COL_IND].Value != null && rowInner.Cells[FILE_NAME_COL_IND].Value != null)
                        && row.Cells[FILE_NAME_COL_IND].Value.ToString() == rowInner.Cells[FILE_NAME_COL_IND].Value.ToString())
                    {
                        row.DefaultCellStyle = DupCell;
                        rowInner.DefaultCellStyle = DupCell;
                    }
                }
            }


        }



        private string GetException(Exception E)
        {
            if (E.InnerException != null)
            {
                return GetException(E.InnerException);
            }
            else
            {
                return E.Message;
            }
        }

        private void ShowException(string Exception, string LastAttemptedDestination = null)
        {
            if (LastAttemptedDestination != null)
            {
                MessageBox.Show("An error occurred when attempting to write to " +
                    LastAttemptedDestination + ":\n" + Exception, "ERROR!");
            }
            else
            {
                MessageBox.Show("An error occurred:\n" + Exception, "ERROR!");
            }
        }

        private DialogResult ShowConfirmationDialog(string Caption, string Question)
        {
            Confirm.Text = Caption;
            Confirm.Question = Question;
            return Confirm.ShowDialog();
        }
        #endregion


        #region Event Methods
        private void B_OpenListClick(object sender, MouseEventArgs e)
        {
            d_openList.ShowDialog();
        }

        private void D_OpenList_FileOk(object sender, CancelEventArgs e)
        {
            SourceFolderSet = false;
            fileName = ((OpenFileDialog)sender).FileName;

            FileInfo fi = new FileInfo(fileName);
            FileList.Clear();
            if (AllValidFileTypes.Split(';').Contains(fi.Extension)) // Check for valid file type
            {



                StreamReader sr = new StreamReader(File.OpenRead(fileName));
                if (ImageFiles.Split(';').Contains(fi.Extension))
                {

                }
                else if (fi.Extension == PlaylistFile)
                {

                    /*Check for valid file type ♪
                     * Create internal view (table) ♪
                     * Find song source folder ♪
                     * Parse data from list ♪
                     * grab the whole list of songs ♪
                     * Populate the table  ♪
                     * Bind the data to DisplayGridView ♪
                     * Show list ♪
                    */



                    XDoc.LoadXml(sr.ReadToEnd());
                    XmlNodeList mediaList = XDoc.GetElementsByTagName("media");


                    if (mediaList.Count > 0)// Parse data from list
                    {
                        string mediaSource = "";
                        string musicPath = "";
                        for (int i = 0; i < mediaList.Count; i++)
                        {
                            string firstHalf = mediaList.Item(i).Attributes.GetNamedItem(FormLib.XML_STR_SRC).Value;
                            FileInfo songInfo;
                            mediaSource = firstHalf;
                            if (!File.Exists(mediaSource))//...or if the file location is not valid / complete
                            {
                                if (!SourceFolderSet)
                                {
                                    ShowSourceFolderDialog(); //Find song source folder
                                    musicPath = fbd_SourceMusicFolder.SelectedPath;
                                    SourceFolderSet = true;
                                }

                                mediaSource = musicPath + @"\" + firstHalf.Replace("..\\", "");
                                mediaList.Item(i).Attributes.GetNamedItem(FormLib.XML_STR_SRC).Value = mediaSource;
                            }


                            if (FileList.FirstOrDefault(x => x.Name == mediaSource) == null && File.Exists(mediaSource))
                            {
                                songInfo = new FileInfo(mediaSource);
                                XmlNode temp = mediaList.Item(i).Clone();
                                XmlAttribute FileTypeAttr = XDoc.CreateAttribute(FormLib.XML_STR_FILE_TYPE);
                                FileTypeAttr.Value = songInfo.Extension;
                                XmlAttribute DateAttr = XDoc.CreateAttribute(FormLib.XML_STR_DATE_MODIFIED);
                                DateAttr.Value = songInfo.LastWriteTime.ToString();

                                temp.Attributes.Append(DateAttr);
                                temp.Attributes.Append(FileTypeAttr);

                                FileList.Add(temp); // grab the whole list of songs
                            }
                        }
                    }

                    MakeOpenListDataTable(fi.Extension); //Create internal view
                    DataView dv = new DataView(OpenListTable);
                    if (FileList[0].Attributes.GetNamedItem("trackArtist") != null)
                    {
                        FormLib.PopulateTable(FormLib.TableTypes.OpenList, ref OpenListTable, FileList);
                    }
                    else
                    {
                        FormLib.PopulateTable(FormLib.TableTypes.Default, ref OpenListTable, FileList);
                    }
                    dgv_OpenList.DataSource = dv; //Bind the data to grid view

                }
                else //xml
                {
                }
                sr.Close();

                LastValidLoadedFileType = fi.Extension;

                OpenListPopulated = true;
                IsPreviewed = false;


            }
            else
            {
                //error
            }



        }

        private void B_Flatten_Click(object sender, EventArgs ea)
        {
            if (OpenListPopulated && ExportPathSet)
            {

                DialogResult UserInput = ShowConfirmationDialog("Are you sure?", "Are you sure you want to flatten this folder?");
                switch (UserInput)
                {
                    case DialogResult.OK:
                    case DialogResult.Yes:
                        //flatten
                        tspb_Flatten.Maximum = FileList.Count;
                        tspb_Flatten.Value = 0;
                        tspb_Flatten.Step = 1;
                        tspb_Flatten.Visible = true;
                        ErrorForm.Songs.Clear();
                        foreach (XmlNode file in FileList)
                        {
                            string filename = file.Attributes.GetNamedItem(FormLib.XML_STR_SRC).Value;
                            int lastFileSlash = filename.LastIndexOf('\\');

                            string fullDestination = ExportPath + "\\" + filename.Substring(lastFileSlash + 1);

                            if (!File.Exists(fullDestination))
                            {
                                try
                                {
                                    File.Copy(filename, fullDestination, false);
                                }
                                catch (Exception e)
                                {
                                    ShowException(GetException(e), filename);
                                }
                            }
                            else
                            {
                                ErrorForm.Songs.Add(file.Clone());
                            }
                            tspb_Flatten.PerformStep();
                        }
                        MessageBox.Show("Flattening Complete", "Complete");
                        if (ErrorForm.Songs.Count > 0)
                        {
                            b_ShowErrors.Enabled = true;
                            ErrorForm.ShowDialog();
                        }
                        tspb_Flatten.Visible = false;
                        break;
                    case DialogResult.Cancel:
                    case DialogResult.No:
                    default:
                        //don't flatten
                        break;
                }
            }
            else
            {
                MessageBox.Show("You must first select a List File and Export Location.", "Hang on...");
            }

        }

        private void B_FolderExport_Click(object sender, EventArgs e)
        {
            IsExport = true;
            b_ShowErrors.Enabled = false;
            fbd_FolderExport.ShowDialog();

            ExportPath = fbd_FolderExport.SelectedPath;
            ss_Main_l_ExportDestination.Text = "Export Folder set to " + ExportPath;
            string[] FilesInExport = Directory.GetFiles(ExportPath);
            FileInfo[] ExportFileInfo = new FileInfo[FilesInExport.Length];
            for (int i = 0; i < FilesInExport.Length; i++)
            {
                ExportFileInfo[i] = new FileInfo(FilesInExport[i]);
            }

            ExportTable = FormLib.MakeTable(FormLib.TableTypes.ExportList);

            FormLib.PopulateTable(FormLib.TableTypes.ExportList, ref ExportTable, FormLib.MakeFileList(ExportFileInfo));

            DataView dv = new DataView(ExportTable);
            dgv_ExportPreview.DataSource = dv;

            IsExport = false;
            ExportPathSet = true;
        }

        private void B_ExportPreview_Click(object sender, EventArgs e)
        {
            if (OpenListPopulated)
            {

                if (FileList.Count > 0 && !IsPreviewed)
                {

                    FormLib.PopulateTable(FormLib.TableTypes.ExportList, ref ExportTable, FileList);
                    IsPreviewed = true;
                }

                SearchForDuplicates(dgv_ExportPreview);
            }
            else
            {
                MessageBox.Show("You must first select a list file.", "Hang on...");
            }

        }

        private void CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ss_Main_l_RowInfo.Text = "Row Index: " + ((DataGridView)sender).SelectedCells[0].RowIndex;
        }

        #endregion

        private void B_ShowErrors_Click(object sender, EventArgs e)
        {
            ErrorForm.ShowDialog();
        }
    }
}

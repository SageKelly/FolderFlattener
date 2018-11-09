using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml;

namespace Folder_Flattener
{
    static class FormLib
    {

        public const string XML_STR_SRC = "src";
        public const string XML_STR_FILE_TYPE = "fileType";
        public const string XML_STR_DATE_MODIFIED = "dateModified";

        public enum TableTypes
        {
            OpenList,
            ExportList,
            ErrorList,
            Default
        }

        private static string[] WPL_ARR_ROW = new string[6]
         {
             "Song Title",
            "Album Title",
            "Album Artist",
            "Song Artist",
            "File Type",
            "Date Modified"
         };
        private static string[] BASIC_ARR_ROW = new string[3]
        {
            "File Name",
            "File Type",
            "Date Modified"
        };

        private static string[] FILE_ROW = new string[1]
        {
            "File Name"
        };

        public static DataTable MakeTable(TableTypes TableType)
        {
            DataTable Result = null;
            switch (TableType)
            {
                case TableTypes.OpenList:
                    Result = MakeDataTable(WPL_ARR_ROW);
                    break;
                case TableTypes.ExportList:
                    Result = MakeDataTable(BASIC_ARR_ROW);
                    break;
                case TableTypes.ErrorList:
                    Result = MakeDataTable(FILE_ROW);
                    break;
                case TableTypes.Default:
                default:
                    Result = MakeDataTable(BASIC_ARR_ROW);
                    break;
            }

            return Result;
        }

        private static DataTable MakeDataTable(string[] RowColumns)
        {
            DataTable Table = new DataTable();
            foreach (string column in RowColumns)
            {
                Table.Columns.Add(new DataColumn()
                {
                    ColumnName = column,
                    DataType = column.GetType()
                });
            }
            return Table;
        }

        private static string FilterFileNameNumbers(string Filename, bool KeepFullName = true)
        {
            int LastSlashIndex = Filename.LastIndexOf(@"\");
            string SongTitleWithNum = Filename.Substring(LastSlashIndex + 1);
            Regex NumberRegex = new Regex(@"^(\d+-\d+-\s|\d+\s-\s|(\d+\s)?)?");
            string SongTitle = NumberRegex.Replace(SongTitleWithNum, "");

            string result;
            if (KeepFullName)
            {
                result = Filename.Substring(0, LastSlashIndex + 1) + SongTitle;
            }
            else
            {
                result = SongTitle;
            }

            return result;
        }


        public static List<XmlNode> MakeFileList(FileInfo[] List)
        {
            XmlDocument XDoc = new XmlDocument();
            List<XmlNode> Result = new List<XmlNode>();
            foreach (FileInfo file in List)
            {
                XmlNode node = XDoc.CreateNode(XmlNodeType.Element, "song", "local");

                XmlAttribute FilenameAttr = XDoc.CreateAttribute(XML_STR_SRC);
                FilenameAttr.Value = file.Name;
                XmlAttribute ExtensionAttr = XDoc.CreateAttribute(XML_STR_FILE_TYPE);
                ExtensionAttr.Value = file.Extension;
                XmlAttribute ModifiedAttr = XDoc.CreateAttribute(XML_STR_DATE_MODIFIED);
                ModifiedAttr.Value = file.LastWriteTime.ToString();

                node.Attributes.Append(FilenameAttr);
                node.Attributes.Append(ExtensionAttr);
                node.Attributes.Append(ModifiedAttr);

                Result.Add(node);
            }
            return Result;
        }

        public static void  PopulateTable(TableTypes TableType, ref DataTable Table, List<XmlNode> NodeList)
        {
            switch (TableType)
            {
                case TableTypes.OpenList:
                    foreach (XmlNode song in NodeList) //Populate the table
                    {
                        Table.LoadDataRow(new object[]
                       {
                           FilterFileNameNumbers(song.Attributes.GetNamedItem(XML_STR_SRC).Value, false),
                           //song.Attributes.GetNamedItem("trackTitle").Value,
                           song.Attributes.GetNamedItem("albumTitle").Value,
                           song.Attributes.GetNamedItem("albumArtist").Value,
                           song.Attributes.GetNamedItem("trackArtist").Value,
                           song.Attributes.GetNamedItem(XML_STR_FILE_TYPE).Value,
                           song.Attributes.GetNamedItem(XML_STR_DATE_MODIFIED).Value,
                       }, true);
                    }
                    break;
                case TableTypes.ErrorList:
                    foreach (XmlNode song in NodeList)
                    {
                        Table.LoadDataRow(new object[]
                        {
                            song.Attributes.GetNamedItem(XML_STR_SRC).Value
                        }, true);
                    }
                    break;
                case TableTypes.ExportList:
                case TableTypes.Default:
                default:
                    foreach (XmlNode song in NodeList)
                    {
                        Table.LoadDataRow(new object[]
                        {
                            FilterFileNameNumbers(song.Attributes.GetNamedItem(XML_STR_SRC).Value, false),
                            song.Attributes.GetNamedItem(XML_STR_FILE_TYPE).Value,
                            song.Attributes.GetNamedItem(XML_STR_DATE_MODIFIED).Value,
                        }, true);
                    }
                    break;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Folder_Flattener
{
    public partial class SongErrors : Form
    {
        #region Variables

        public List<XmlNode> Songs = new List<XmlNode>();

        DataTable SongTable;

        #endregion

        public SongErrors()
        {
            InitializeComponent();
            this.Move += LoadTable;
        }

        private void LoadTable(object sender, EventArgs e)
        {
            SongTable = FormLib.MakeTable(FormLib.TableTypes.ErrorList);
            DataView dv = new DataView(SongTable);
            dgv_Errors.DataSource = dv;
        }
    }
}

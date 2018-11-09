using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Folder_Flattener
{
    public partial class ConfirmationForm : Form
    {

        public string Question
        {
            get
            {
                return l_Question.Text;
            }
            set
            {
                if(l_Question.Text != value)
                {
                    l_Question.Text = value;
                }
            }
        }

        public ConfirmationForm()
        {
            InitializeComponent();
        }


    }
}

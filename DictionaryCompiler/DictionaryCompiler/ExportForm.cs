using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using MaterialSkin.Animations;
using MaterialSkin;

namespace DictionaryCompiler
{
    public partial class ExportForm : MaterialForm
    {
        public ExportForm()
        {
            InitializeComponent();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void openFolderBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Yes;
        }
    }
}

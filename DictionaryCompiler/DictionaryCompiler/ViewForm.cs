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
using System.IO;

namespace DictionaryCompiler
{
    public partial class ViewForm : MaterialForm
    {
        public ViewForm()
        {
            InitializeComponent();
        }

        private void View_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders);
        }
    }
}

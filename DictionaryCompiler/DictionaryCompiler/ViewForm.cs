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
            int sir = 60;
            for (int i = 0; i < dataGridView1.ColumnCount; i++)
            {
                sir += dataGridView1.Columns[i].Width;
            }
            this.Width= sir;
        }
    }
}

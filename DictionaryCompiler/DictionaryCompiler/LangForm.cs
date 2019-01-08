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
    public partial class LangForm : MaterialForm
    {
        public LangForm()
        {
            InitializeComponent();

            MiscFunctions.CheckFile("langs.txt");
            StreamReader sr = File.OpenText("langs.txt");
            while (sr.Peek() >= 0)
            {
                string line = sr.ReadLine();
                comboBox1.Items.Add(line);
            }
            sr.Close();
        }

        private void materialRaisedButton3_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "")
                MessageBox.Show("Please select a language.");
            else
                DialogResult = DialogResult.Yes;
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

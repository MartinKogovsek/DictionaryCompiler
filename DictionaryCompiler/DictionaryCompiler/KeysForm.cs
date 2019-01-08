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
    public partial class KeysForm : MaterialForm
    {
        public string selectedApiKey;

        public KeysForm()
        {
            InitializeComponent();
        }

        private void KeysForm_Load(object sender, EventArgs e)
        {
            MiscFunctions.CheckFile("apikeys.txt");

            StreamReader sr = File.OpenText("apikeys.txt");
            while (sr.Peek() >= 0)
            {
                string line = sr.ReadLine();
                string[] words = line.Split(';');
                dataGridView1.Rows.Add(dataGridView1.RowCount, words[1], words[2]);
            }
            sr.Close();
        }

        private void materialRaisedButton3_Click(object sender, EventArgs e) //select
        {
            if (selectedApiKey == null)
                MessageBox.Show("Please select an api key");
            else
                DialogResult = DialogResult.Yes;
        }

        private void materialRaisedButton2_Click(object sender, EventArgs e) //add
        {
            dataGridView1.Rows.Add(dataGridView1.RowCount, "enter a tag","enter a key");
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e) //delete
        {
            try
            {
                DataGridViewRow row = dataGridView1.CurrentRow;
                dataGridView1.Rows.Remove(row);
            }
            catch(Exception ex)
            {
                MessageBox.Show("No rows left to delete!" + ex);
            }
        }

        private void materialRaisedButton4_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            StreamReader sr = File.OpenText("apikeys.txt");
            while (sr.Peek() >= 0)
            {
                string line = sr.ReadLine();
                string[] words = line.Split(';');
                dataGridView1.Rows.Add(dataGridView1.RowCount, words[1], words[2]);
            }
            sr.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                selectedApiKey = dataGridView1.Rows[e.RowIndex].Cells["apiKeyC"].Value.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("You can't select this row!");
            }

        }

        private void materialRaisedButton5_Click(object sender, EventArgs e)
        {
            StreamWriter sw = File.CreateText("apikeys.txt");
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                sw.WriteLine(dataGridView1.Rows[i].Cells[0].Value.ToString() + ";"
                    + dataGridView1.Rows[i].Cells[1].Value.ToString() + ";"
                    + dataGridView1.Rows[i].Cells[2].Value.ToString());
            }
            sw.Close();
        }
    }
}

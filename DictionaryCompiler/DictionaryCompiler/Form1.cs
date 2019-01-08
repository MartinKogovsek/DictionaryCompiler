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
using System.Diagnostics;
using System.Threading;
using Google.Cloud.Translation.V2;

namespace DictionaryCompiler
{
    public partial class Form1 : MaterialForm
    {
        public string PathIn { get; set; }
        public string PathOut { get; set; }

        public IncludeStatus includeStatus = new IncludeStatus();
        public List<string> dic = new List<string>();
        public Stopwatch sw = new Stopwatch();

        public string ApiKeyConst = null;

        public Form1()
        {
            InitializeComponent();

            #region skin
            var skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new ColorScheme(Primary.LightBlue800, Primary.LightBlue900, Primary.LightBlue500, Accent.LightBlue200, TextShade.WHITE);
            #endregion

            inputTextBox.Text = MiscFunctions.GetDesktopPath() + @"\words.txt";
            outputTextBox.Text = MiscFunctions.GetDesktopPath();
        }

        private void compileBtn_Click(object sender, EventArgs e)
        {
            if (apiKeyTextBox.Text == "Please select or write an api key")
            {
                MessageBox.Show("Please enter a valid api key!");
            }
            else
            {
                sw.Start();
                dic.Clear();
                PathIn = inputTextBox.Text;
                ApiKeyConst = apiKeyTextBox.Text;

                if (countCheck.Checked == true)
                    includeStatus.CountCheck = true;
                if (orderCheck.Checked == true)
                    includeStatus.OrderCheck = true;
                if (engWordsCheck.Checked == true)
                    includeStatus.EngWordsCheck = true;
                if (sloWordsCheck.Checked == true)
                    includeStatus.SloWordsCheck = true;
                if (meaningCheck.Checked == true)
                    includeStatus.MeaningCheck = true;
                if (pronCheck.Checked == true)
                    includeStatus.PronCheck = true;
                if (urlCheck.Checked == true)
                    includeStatus.UrlCheck = true;

                try
                {
                    List<string> progressLenghtCheck = MiscFunctions.GatherWords(PathIn);
                    progressBar.Maximum = progressLenghtCheck.Count();
                    progressBar.SuperscriptText = "/" + progressLenghtCheck.Count();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + " (GetProgressBarLength.0)");
                }

                BackgroundWorker worker = new BackgroundWorker();

                if (engWordsCheck.Checked == false && sloWordsCheck.Checked == false && meaningCheck.Checked == false && pronCheck.Checked == false && urlCheck.Checked == false)
                {
                    MessageBox.Show("No include option checked! Do so at setting tab!");
                    //TimerLabel.Content = "Took: --- ms";
                    //ItemsCountLabel.Content = "composed: --- words";
                    //ListOutput.Items.Add("You must select at least one include checkbox!");
                }
                else
                {
                    materialTabControl1.SelectTab("tabPage2");
                    worker.RunWorkerCompleted += Worker_RunWorkerCompleted;
                    worker.WorkerReportsProgress = true;
                    worker.DoWork += Worker_DoWork;
                    worker.ProgressChanged += Worker_ProgressChanged;
                    worker.RunWorkerAsync();
                }
            }
        }

        private void Worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar.Value = e.ProgressPercentage;
            progressBar.Text = e.ProgressPercentage.ToString();
        }

        private void Worker_DoWork(object sender, DoWorkEventArgs e)
        {
            var worker = sender as BackgroundWorker;
            worker.ReportProgress(0);

            List<string> list = new List<string>();
            try
            {
                list = MiscFunctions.GatherWords(PathIn);
                if (includeStatus.OrderCheck)
                    list.Sort();
                try
                {
                    Word word;
                    int count = 0;
                    foreach (var item in list)
                    {
                        count++;
                        word = new Word();

                        if (includeStatus.CountCheck)
                            word.WordCount = count + ";";
                        if (includeStatus.EngWordsCheck)
                            word.EngWord = item + ";";
                        if (includeStatus.SloWordsCheck)
                            word.SloWord = Translation.TranslateAsync(item, ApiKeyConst, langTextBox.Text) + ";";
                        if (includeStatus.MeaningCheck)
                            word.Meaning = "Meaning" + ";";
                        if (includeStatus.PronCheck)
                            word.Pron = "Pronunciation" + ";";
                        if (includeStatus.UrlCheck)
                        {
                            string tempUrl = string.Format("https://www.google.com/search?q={0}&tbm=isch&q=", item);
                            word.UrlText = tempUrl;
                        }
                        dic.Add(word.ConcatenateProperties());
                        worker.ReportProgress(count);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + " (compileScript.1)");
                    dic.Add(ex.Message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " (compileScript.0)");
            }
        }

        private void Worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            sw.Stop();
            sw.Reset();
            materialTabControl1.SelectTab("tabPage3");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void browseSrcPathBtn_Click(object sender, EventArgs e)
        {
            inputTextBox.Text = MiscFunctions.GetPath("file");
        }

        private void keysBtn_Click(object sender, EventArgs e)
        {
            KeysForm keysForm = new KeysForm();
            if (keysForm.ShowDialog() == DialogResult.Yes)
            {
                apiKeyTextBox.Text = keysForm.selectedApiKey;
            }
        }

        private void viewBtn_Click(object sender, EventArgs e)
        {
            ViewForm viewForm = new ViewForm();
            int c = 0;
            if (includeStatus.CountCheck){
                viewForm.dataGridView1.Columns.Add("checkC", "#");
                c++;
            }
            if (includeStatus.EngWordsCheck){
                viewForm.dataGridView1.Columns.Add("firstC", "Original");
                c++;
            }
            if (includeStatus.SloWordsCheck){
                viewForm.dataGridView1.Columns.Add("secondC", langTextBox.Text);
                c++;
            }
            if (includeStatus.MeaningCheck){
                viewForm.dataGridView1.Columns.Add("meaningC", "Meaning");
                c++;
            }
            if (includeStatus.PronCheck){
                viewForm.dataGridView1.Columns.Add("pronC", "Pronunciation");
                c++;
            }
            if (includeStatus.UrlCheck){
                viewForm.dataGridView1.Columns.Add("urlC", "URL");
                c++;
            }
            foreach (var item in dic)
            {
                string[] s = item.Split(';');

                if (c == 1)
                    viewForm.dataGridView1.Rows.Add(s[0]);
                if (c == 2)
                    viewForm.dataGridView1.Rows.Add(s[0], s[1]);
                if (c == 3)
                    viewForm.dataGridView1.Rows.Add(s[0], s[1], s[2]);
                if (c == 4)
                    viewForm.dataGridView1.Rows.Add(s[0], s[1], s[2], s[3]);
                if (c == 5)
                    viewForm.dataGridView1.Rows.Add(s[0], s[1], s[2], s[3], s[4]);
                if (c == 6)
                    viewForm.dataGridView1.Rows.Add(s[0], s[1], s[2], s[3], s[4], s[5]);
            }
            if (viewForm.ShowDialog() == DialogResult.Yes) { }
        }

        private void exportBtn_Click(object sender, EventArgs e)
        {
            ExportForm exportForm = new ExportForm();
            PathOut = outputTextBox.Text + "\\";

            if (dic.Count > 0)
            {
                exportForm.Text = "Export status";
                if (!txtCheck.Checked && !xlsxCheck.Checked)
                    MessageBox.Show("Please select one of the export options!");
                else
                {
                    if (txtCheck.Checked)
                    {
                        if (overwriteCheck.Checked)
                        {
                            File.WriteAllLines(PathOut + outputNameTextBox.Text + ".txt", dic);
                            exportForm.txtStatusLabel.Text = "Success!";
                        }
                        if (File.Exists(PathOut + outputNameTextBox.Text + ".txt") && !overwriteCheck.Checked)
                            exportForm.txtStatusLabel.Text = "File already exists!";
                    }
                    else
                        exportForm.txtStatusLabel.Text = "Not selected!";

                    if (xlsxCheck.Checked)
                    {
                        if (overwriteCheck.Checked)
                        {
                            ToExcel.ExportToExcel(PathOut, outputNameTextBox.Text);
                            exportForm.xlsxStatusLabel.Text = "Success!";
                        }
                        if (File.Exists(PathOut + outputNameTextBox.Text + ".xlsx") && !overwriteCheck.Checked)
                            exportForm.xlsxStatusLabel.Text = "File already exists!";
                    }
                    else
                        exportForm.xlsxStatusLabel.Text = "Not selected!";
                }
            }
            else
                exportForm.Text = "Dictionary is empty!";

            if (exportForm.ShowDialog() == DialogResult.Yes) { Process.Start("explorer.exe", PathOut); }
        }

        private void browseOutPathBtn_Click(object sender, EventArgs e)
        {
            outputTextBox.Text = MiscFunctions.GetPath("folder");
        }

        private void openWordsFileBtn_Click(object sender, EventArgs e)
        {
            Process.Start("notepad.exe", inputTextBox.Text);
        }

        private void openConfigBtn_Click(object sender, EventArgs e)
        {
            Process.Start("notepad.exe", "apikeys.txt");
        }

        private void langBtn_Click(object sender, EventArgs e)
        {
            LangForm langForm = new LangForm();
            if (langForm.ShowDialog() == DialogResult.Yes)
            {
                langTextBox.Text = langForm.comboBox1.Text;
            }
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.ShowDialog();
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            List<string> list = MiscFunctions.GatherWords(inputTextBox.Text);
            foreach (var item in list)
            {
                Process.Start("https://translate.google.com/#view=home&op=translate&sl=en&tl=sl&text=" + item);
            }
        }
    }
}

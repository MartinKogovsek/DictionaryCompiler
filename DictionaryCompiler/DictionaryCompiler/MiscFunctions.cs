using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace DictionaryCompiler
{
    class MiscFunctions
    {

        public static string GetDesktopPath()
        {
            string desktopPath = null;
            try
            {
                desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                return desktopPath;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " (GetDesktopPath.0)");
            }
            return desktopPath;
        }

        public static string GetPath(string type)
        {
            var filePath = string.Empty;
            if (type == "folder")
            {
                using (FolderBrowserDialog openFolderDialog = new FolderBrowserDialog())
                {
                    if (openFolderDialog.ShowDialog() == DialogResult.OK)
                    {
                        filePath = openFolderDialog.SelectedPath;
                    }
                }
            }
            if (type == "file")
            {
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.InitialDirectory = "c:\\";
                    openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                    openFileDialog.FilterIndex = 2;
                    openFileDialog.RestoreDirectory = true;
                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        filePath = openFileDialog.FileName;
                    }
                }
            }
            return filePath;
        }

        public static List<string> GatherWords(string path)
        {
            try
            {
                List<string> list = new List<string>();
                list = File.ReadAllLines(path).ToList();
                list = list.ConvertAll(low => low.ToLowerInvariant());
                return list;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return null;
            }
        }

        public static void CheckFile(string file)
        {
            if (!File.Exists(file))
            {
                StreamWriter sw = File.CreateText(file);
                sw.Close();
            }
        }

    }
}

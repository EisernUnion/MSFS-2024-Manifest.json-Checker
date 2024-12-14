using Newtonsoft.Json.Linq;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;
using System.Diagnostics;
using System.Data;

namespace MainifestFix
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_SelectFolder_Click(object sender, EventArgs e)
        {
            if (fbd_LookupFolder.ShowDialog() == DialogResult.OK)
            {
                label_SelectedPath.Text = fbd_LookupFolder.SelectedPath;
            }
        }

        private void button_Run_Click(object sender, EventArgs e)
        {
            CheckManifestFiles();
            MessageBox.Show("Done!");
        }

        public void CheckManifestFiles()
        {
            var pathToJson = Path.Combine(label_SelectedPath.Text);
            string[] fileEntries = Directory.GetFiles(pathToJson, "manifest.json", SearchOption.AllDirectories);

            int cntFiles = fileEntries.Length;
            label_Counter.Text = cntFiles.ToString() + " files to check";

            ProcessDirectory(pathToJson, cntFiles);

        }

        public void ProcessDirectory(string targetDirectory, int cntFiles)
        {
            string vers = "";

            if (checkBox2020.Checked)
            {
                vers = "2020";
            }
            else if (checkBox2024.Checked)
            {
                vers = "2024";
            }

            // Process the list of files found in the directory.
            string[] fileEntries = Directory.GetFiles(targetDirectory, "manifest.json");

            foreach (string fileName in fileEntries)
            {
                if (checkBox_Remove.Checked)
                {
                    ProcessFileRemoveBuilder(fileName, cntFiles);
                }
                else
                {
                    ProcessFileAddBuilder(fileName, cntFiles, vers);
                }
            }

            // Recurse into subdirectories of this directory.
            string[] subdirectoryEntries = Directory.GetDirectories(targetDirectory);
            foreach (string subdirectory in subdirectoryEntries)
            {
                ProcessDirectory(subdirectory, cntFiles);
            }

        }

        public void ProcessFileAddBuilder(string path, int cnt, string vers)
        {
            try
            {

                // Load the content of the file as a string
                string json = File.ReadAllText(path);

                // Parse the JSON to a Newtonsoft.Json.Linq.JObject
                JObject obj = JObject.Parse(json);

                bool check = obj.ContainsKey("builder");
                if (check == false)
                {
                    // Add the property
                    if (vers == "2024")
                    {
                        obj["builder"] = "Microsoft Flight Simulator 2024";
                    }
                    else if (vers == "2020")
                    {
                        obj["builder"] = "Microsoft Flight Simulator 2020";
                    }


                    // Convert back to a JSON string
                    string newJson = obj.ToString();

                    // Save the string back to the file
                    File.WriteAllText(path, newJson);
                    listBox_Output.Items.Add(path);
                }
                else if (check == true)
                {

                }
            }
            catch
            {

            }
            label_Counter.Text = listBox_Output.Items.Count.ToString() + " / " + cnt.ToString();
        }

        public void ProcessFileRemoveBuilder(string path, int cnt)
        {
            try
            {
                string json = File.ReadAllText(path);
                JObject obj = JObject.Parse(json);

                bool check = obj.ContainsKey("builder");
                if (check == false)
                {

                }
                else if (check == true)
                {
                    obj.Property("builder").Remove();
                    string newJson = obj.ToString();
                    File.WriteAllText(path, newJson);
                    listBox_Output.Items.Add(path);
                }
            }
            catch
            {
                MessageBox.Show("error: " + path);
            }
            label_Counter.Text = listBox_Output.Items.Count.ToString() + " / " + cnt.ToString();
        }

        private void checkBox2024_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2024.Checked)
            {
                if (label_SelectedPath.Text != "-")
                {
                    checkBox2020.Checked = false;
                    checkBox_Remove.Checked = false;
                    button_Run.Enabled = true;
                }
            }
        }

        private void checkBox2020_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2020.Checked)
            {
                if (label_SelectedPath.Text != "-")
                {
                    checkBox2024.Checked = false;
                    checkBox_Remove.Checked = false;
                    button_Run.Enabled = true;
                }
            }
            else
            {
                button_Run.Enabled = false;
            }
        }

        private void checkBox_Remove_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Remove.Checked)
            {
                if (label_SelectedPath.Text != "-")
                {
                    checkBox2024.Checked = false;
                    checkBox2020.Checked = false;
                    button_Run.Enabled = true;
                }
            }
            else
            {
                button_Run.Enabled = false;
            }
        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            checkBox2024.Checked = false;
            checkBox2020.Checked = false;
            checkBox_Remove.Checked = false;
            button_Run.Enabled = false;
            label_SelectedPath.Text = "-";
            label_Counter.Text = "-";
            listBox_Output.Items.Clear();
        }

        private void label_SelectedPath_TextChanged(object sender, EventArgs e)
        {
            if (checkBox2020.Checked)
            {
                button_Run.Enabled = true;
            }
            else if (checkBox_Remove.Checked)
            {
                button_Run.Enabled = true;
            }
        }
    }
}

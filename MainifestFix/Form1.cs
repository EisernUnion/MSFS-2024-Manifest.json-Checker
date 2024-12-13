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

        public  void CheckManifestFiles()
        {
            var pathToJson = Path.Combine(label_SelectedPath.Text);
            string[] fileEntries = Directory.GetFiles(pathToJson, "manifest.json", SearchOption.AllDirectories);
            
            int cntFiles = fileEntries.Length;
            label_Counter.Text = cntFiles.ToString() + " files to check";

            ProcessDirectory(pathToJson, cntFiles);
            
        }

        public void ProcessDirectory(string targetDirectory, int cntFiles)
        {
            // Process the list of files found in the directory.
            string[] fileEntries = Directory.GetFiles(targetDirectory, "manifest.json");
          
   

            foreach (string fileName in fileEntries)
            {

          
                ProcessFile(fileName, cntFiles);

            }
               
            // Recurse into subdirectories of this directory.
            string[] subdirectoryEntries = Directory.GetDirectories(targetDirectory);
            foreach (string subdirectory in subdirectoryEntries)
            {
                ProcessDirectory(subdirectory, cntFiles);
            }

        }

        public void ProcessFile(string path, int cnt)
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
                    obj["builder"] = "Microsoft Flight Simulator 2024";

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
    }
}

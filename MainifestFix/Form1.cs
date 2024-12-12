using Newtonsoft.Json.Linq;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;
using System.Diagnostics;

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
        }

        public void CheckManifestFiles()
        {
            var pathToJson = Path.Combine(label_SelectedPath.Text);
            ProcessDirectory(pathToJson);

        }

        public static void ProcessDirectory(string targetDirectory)
        {
            // Process the list of files found in the directory.
            string[] fileEntries = Directory.GetFiles(targetDirectory, "manifest.json");
            foreach (string fileName in fileEntries)
            {
                ProcessFile(fileName);
            }
               
            // Recurse into subdirectories of this directory.
            string[] subdirectoryEntries = Directory.GetDirectories(targetDirectory);
            foreach (string subdirectory in subdirectoryEntries)
            {
                ProcessDirectory(subdirectory);
            }

            MessageBox.Show("Done");
        }

        public static void ProcessFile(string path)
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
            }
            else if (check == true)
            {
                Debug.WriteLine(path);
            }
        }
    }
}

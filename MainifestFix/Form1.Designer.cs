namespace MainifestFix
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            fbd_LookupFolder = new FolderBrowserDialog();
            button_SelectFolder = new Button();
            label_SelectedPath = new Label();
            button_Run = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // button_SelectFolder
            // 
            button_SelectFolder.Location = new Point(21, 63);
            button_SelectFolder.Name = "button_SelectFolder";
            button_SelectFolder.Size = new Size(112, 34);
            button_SelectFolder.TabIndex = 0;
            button_SelectFolder.Text = "Folder";
            button_SelectFolder.UseVisualStyleBackColor = true;
            button_SelectFolder.Click += button_SelectFolder_Click;
            // 
            // label_SelectedPath
            // 
            label_SelectedPath.AutoSize = true;
            label_SelectedPath.Location = new Point(21, 104);
            label_SelectedPath.Name = "label_SelectedPath";
            label_SelectedPath.Size = new Size(19, 25);
            label_SelectedPath.TabIndex = 1;
            label_SelectedPath.Text = "-";
            // 
            // button_Run
            // 
            button_Run.Location = new Point(21, 161);
            button_Run.Name = "button_Run";
            button_Run.Size = new Size(112, 34);
            button_Run.TabIndex = 2;
            button_Run.Text = "Run";
            button_Run.UseVisualStyleBackColor = true;
            button_Run.Click += button_Run_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 24);
            label1.Name = "label1";
            label1.Size = new Size(368, 25);
            label1.TabIndex = 3;
            label1.Text = "Select the Folder containing the files to check";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 259);
            Controls.Add(label1);
            Controls.Add(button_Run);
            Controls.Add(label_SelectedPath);
            Controls.Add(button_SelectFolder);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FolderBrowserDialog fbd_LookupFolder;
        private Button button_SelectFolder;
        private Label label_SelectedPath;
        private Button button_Run;
        private Label label1;
    }
}

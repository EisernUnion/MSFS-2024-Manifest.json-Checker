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
            labelStatus = new Label();
            listBox_Output = new ListBox();
            label2 = new Label();
            label_Counter = new Label();
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
            button_Run.Location = new Point(21, 153);
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
            // labelStatus
            // 
            labelStatus.AutoSize = true;
            labelStatus.Location = new Point(27, 210);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new Size(0, 25);
            labelStatus.TabIndex = 4;
            // 
            // listBox_Output
            // 
            listBox_Output.BackColor = SystemColors.HighlightText;
            listBox_Output.BorderStyle = BorderStyle.None;
            listBox_Output.FormattingEnabled = true;
            listBox_Output.HorizontalScrollbar = true;
            listBox_Output.ItemHeight = 25;
            listBox_Output.Location = new Point(22, 245);
            listBox_Output.Name = "listBox_Output";
            listBox_Output.Size = new Size(877, 175);
            listBox_Output.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ControlDark;
            label2.Location = new Point(18, 219);
            label2.Name = "label2";
            label2.Size = new Size(120, 25);
            label2.TabIndex = 6;
            label2.Text = "Modified files";
            // 
            // label_Counter
            // 
            label_Counter.AutoSize = true;
            label_Counter.Location = new Point(147, 157);
            label_Counter.Name = "label_Counter";
            label_Counter.Size = new Size(19, 25);
            label_Counter.TabIndex = 7;
            label_Counter.Text = "-";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(911, 430);
            Controls.Add(label_Counter);
            Controls.Add(label2);
            Controls.Add(listBox_Output);
            Controls.Add(labelStatus);
            Controls.Add(label1);
            Controls.Add(button_Run);
            Controls.Add(label_SelectedPath);
            Controls.Add(button_SelectFolder);
            Name = "Form1";
            Text = "Manifest.json-Fix";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FolderBrowserDialog fbd_LookupFolder;
        private Button button_SelectFolder;
        private Label label_SelectedPath;
        private Button button_Run;
        private Label label1;
        private Label labelStatus;
        private ListBox listBox_Output;
        private Label label2;
        private Label label_Counter;
    }
}

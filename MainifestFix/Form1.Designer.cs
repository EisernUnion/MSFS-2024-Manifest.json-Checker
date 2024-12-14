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
            checkBox_Remove = new CheckBox();
            checkBox2020 = new CheckBox();
            checkBox2024 = new CheckBox();
            label3 = new Label();
            button_Clear = new Button();
            SuspendLayout();
            // 
            // button_SelectFolder
            // 
            button_SelectFolder.Location = new Point(19, 63);
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
            label_SelectedPath.Location = new Point(19, 104);
            label_SelectedPath.Name = "label_SelectedPath";
            label_SelectedPath.Size = new Size(19, 25);
            label_SelectedPath.TabIndex = 1;
            label_SelectedPath.Text = "-";
            label_SelectedPath.TextChanged += label_SelectedPath_TextChanged;
            // 
            // button_Run
            // 
            button_Run.Enabled = false;
            button_Run.Location = new Point(19, 291);
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
            label1.Location = new Point(19, 24);
            label1.Name = "label1";
            label1.Size = new Size(368, 25);
            label1.TabIndex = 3;
            label1.Text = "Select the Folder containing the files to check";
            // 
            // labelStatus
            // 
            labelStatus.AutoSize = true;
            labelStatus.Location = new Point(26, 336);
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
            listBox_Output.Location = new Point(21, 368);
            listBox_Output.Name = "listBox_Output";
            listBox_Output.Size = new Size(877, 175);
            listBox_Output.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ControlDark;
            label2.Location = new Point(17, 342);
            label2.Name = "label2";
            label2.Size = new Size(120, 25);
            label2.TabIndex = 6;
            label2.Text = "Modified files";
            // 
            // label_Counter
            // 
            label_Counter.AutoSize = true;
            label_Counter.Location = new Point(146, 295);
            label_Counter.Name = "label_Counter";
            label_Counter.Size = new Size(19, 25);
            label_Counter.TabIndex = 7;
            label_Counter.Text = "-";
            // 
            // checkBox_Remove
            // 
            checkBox_Remove.AutoSize = true;
            checkBox_Remove.Location = new Point(212, 194);
            checkBox_Remove.Name = "checkBox_Remove";
            checkBox_Remove.Size = new Size(175, 29);
            checkBox_Remove.TabIndex = 8;
            checkBox_Remove.Text = "Remove \"Builder\"";
            checkBox_Remove.UseVisualStyleBackColor = true;
            checkBox_Remove.CheckedChanged += checkBox_Remove_CheckedChanged;
            // 
            // checkBox2020
            // 
            checkBox2020.AutoSize = true;
            checkBox2020.Location = new Point(19, 194);
            checkBox2020.Name = "checkBox2020";
            checkBox2020.Size = new Size(176, 29);
            checkBox2020.TabIndex = 11;
            checkBox2020.Text = "Add Builder 2020";
            checkBox2020.UseVisualStyleBackColor = true;
            checkBox2020.CheckedChanged += checkBox2020_CheckedChanged;
            // 
            // checkBox2024
            // 
            checkBox2024.AutoSize = true;
            checkBox2024.Location = new Point(21, 229);
            checkBox2024.Name = "checkBox2024";
            checkBox2024.Size = new Size(137, 29);
            checkBox2024.TabIndex = 12;
            checkBox2024.Text = "Builder 2024";
            checkBox2024.UseVisualStyleBackColor = true;
            checkBox2024.Visible = false;
            checkBox2024.CheckedChanged += checkBox2024_CheckedChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 146);
            label3.Name = "label3";
            label3.Size = new Size(589, 25);
            label3.TabIndex = 13;
            label3.Text = "Choose 1 action. Either add 'Builder' or remove existing 'Builder' property";
            // 
            // button_Clear
            // 
            button_Clear.Location = new Point(786, 569);
            button_Clear.Name = "button_Clear";
            button_Clear.Size = new Size(112, 34);
            button_Clear.TabIndex = 14;
            button_Clear.Text = "Clear";
            button_Clear.UseVisualStyleBackColor = true;
            button_Clear.Click += button_Clear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(959, 615);
            Controls.Add(button_Clear);
            Controls.Add(label3);
            Controls.Add(checkBox2024);
            Controls.Add(checkBox2020);
            Controls.Add(checkBox_Remove);
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
        private CheckBox checkBox_Remove;
        private CheckBox checkBox2020;
        private CheckBox checkBox2024;
        private Label label3;
        private Button button_Clear;
    }
}

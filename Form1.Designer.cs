namespace My_Own_Scanner_Attempt
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.valueTypeComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.valueTextBox = new System.Windows.Forms.TextBox();
            this.scanButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.addressColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.valueColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.infoButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // valueTypeComboBox
            // 
            this.valueTypeComboBox.BackColor = System.Drawing.SystemColors.Window;
            this.valueTypeComboBox.FormattingEnabled = true;
            this.valueTypeComboBox.Items.AddRange(new object[] {
            "Byte",
            "2 Byte",
            "4 Byte",
            "QWord",
            "Float",
            "Double",
            "String",
            "Array of Bytes",
            "2 Byte Big Endian",
            "4 Byte Big Endian",
            "Float Big Endian ",
            "Double Big Endian"});
            this.valueTypeComboBox.Location = new System.Drawing.Point(55, 48);
            this.valueTypeComboBox.Name = "valueTypeComboBox";
            this.valueTypeComboBox.Size = new System.Drawing.Size(100, 21);
            this.valueTypeComboBox.TabIndex = 0;
            this.valueTypeComboBox.Text = "Value type";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Value:";
            // 
            // valueTextBox
            // 
            this.valueTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.valueTextBox.Location = new System.Drawing.Point(55, 22);
            this.valueTextBox.Name = "valueTextBox";
            this.valueTextBox.Size = new System.Drawing.Size(100, 20);
            this.valueTextBox.TabIndex = 2;
            // 
            // scanButton
            // 
            this.scanButton.Location = new System.Drawing.Point(55, 75);
            this.scanButton.Name = "scanButton";
            this.scanButton.Size = new System.Drawing.Size(50, 23);
            this.scanButton.TabIndex = 3;
            this.scanButton.Text = "Scan";
            this.scanButton.UseVisualStyleBackColor = true;
            this.scanButton.Click += new System.EventHandler(this.scanButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(105, 75);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(50, 23);
            this.resetButton.TabIndex = 4;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.addressColumn,
            this.valueColumn});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(161, 22);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(248, 256);
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // addressColumn
            // 
            this.addressColumn.Text = "Address";
            this.addressColumn.Width = 135;
            // 
            // valueColumn
            // 
            this.valueColumn.Text = "Value";
            this.valueColumn.Width = 110;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(4, 255);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Garbage Collector";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(5, 104);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(150, 23);
            this.progressBar1.TabIndex = 7;
            // 
            // infoButton
            // 
            this.infoButton.Location = new System.Drawing.Point(110, 255);
            this.infoButton.Name = "infoButton";
            this.infoButton.Size = new System.Drawing.Size(45, 24);
            this.infoButton.TabIndex = 8;
            this.infoButton.Text = "Info";
            this.infoButton.UseVisualStyleBackColor = true;
            this.infoButton.Click += new System.EventHandler(this.infoButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 290);
            this.Controls.Add(this.infoButton);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.scanButton);
            this.Controls.Add(this.valueTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.valueTypeComboBox);
            this.Name = "Form1";
            this.Text = "Scanner/Debugger";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.ComboBox valueTypeComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox valueTextBox;
        private System.Windows.Forms.Button scanButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader addressColumn;
        private System.Windows.Forms.ColumnHeader valueColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button infoButton;
    }
}


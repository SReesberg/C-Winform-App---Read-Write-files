
namespace Exercise1Weekdays
{
    partial class MainForm
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
            this.btnSave = new System.Windows.Forms.Button();
            this.DayList = new System.Windows.Forms.ListBox();
            this.TextBoxFile = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(726, 857);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(162, 63);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // DayList
            // 
            this.DayList.FormattingEnabled = true;
            this.DayList.ItemHeight = 25;
            this.DayList.Location = new System.Drawing.Point(38, 68);
            this.DayList.Name = "DayList";
            this.DayList.Size = new System.Drawing.Size(343, 754);
            this.DayList.TabIndex = 1;
            this.DayList.SelectedIndexChanged += new System.EventHandler(this.DayList_SelectedIndexChanged);
            // 
            // TextBoxFile
            // 
            this.TextBoxFile.Location = new System.Drawing.Point(408, 68);
            this.TextBoxFile.Name = "TextBoxFile";
            this.TextBoxFile.Size = new System.Drawing.Size(843, 754);
            this.TextBoxFile.TabIndex = 2;
            this.TextBoxFile.Text = "";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1344, 995);
            this.Controls.Add(this.TextBoxFile);
            this.Controls.Add(this.DayList);
            this.Controls.Add(this.btnSave);
            this.Name = "MainForm";
            this.Text = "My Week Days";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ListBox DayList;
        private System.Windows.Forms.RichTextBox TextBoxFile;
    }
}


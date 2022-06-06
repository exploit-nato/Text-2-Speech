namespace nato_text_2_speech
{
    partial class Main
    {
        private System.ComponentModel.IContainer components = null;
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) /* then */ components.Dispose();
            base.Dispose(disposing);
        }
        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.text_field = new System.Windows.Forms.TextBox();
            this.date_and_time_lbl = new System.Windows.Forms.Label();
            this.date_and_time = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.import_file_btn = new System.Windows.Forms.Button();
            this.speak_btn = new System.Windows.Forms.Button();
            this.speed_selection = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // text_field
            // 
            this.text_field.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.text_field.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_field.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.text_field.Location = new System.Drawing.Point(12, 12);
            this.text_field.MaxLength = 999999999;
            this.text_field.Multiline = true;
            this.text_field.Name = "text_field";
            this.text_field.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.text_field.Size = new System.Drawing.Size(1065, 562);
            this.text_field.TabIndex = 1;
            // 
            // date_and_time_lbl
            // 
            this.date_and_time_lbl.AutoSize = true;
            this.date_and_time_lbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.date_and_time_lbl.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_and_time_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.date_and_time_lbl.Location = new System.Drawing.Point(11, 586);
            this.date_and_time_lbl.Name = "date_and_time_lbl";
            this.date_and_time_lbl.Size = new System.Drawing.Size(121, 25);
            this.date_and_time_lbl.TabIndex = 2;
            this.date_and_time_lbl.Text = "Date && Time:";
            // 
            // date_and_time
            // 
            this.date_and_time.AutoSize = true;
            this.date_and_time.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.date_and_time.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_and_time.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.date_and_time.Location = new System.Drawing.Point(138, 586);
            this.date_and_time.Name = "date_and_time";
            this.date_and_time.Size = new System.Drawing.Size(117, 25);
            this.date_and_time.TabIndex = 3;
            this.date_and_time.Text = "Date && Time";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // import_file_btn
            // 
            this.import_file_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.import_file_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.import_file_btn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.import_file_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.import_file_btn.Location = new System.Drawing.Point(518, 582);
            this.import_file_btn.Name = "import_file_btn";
            this.import_file_btn.Size = new System.Drawing.Size(162, 33);
            this.import_file_btn.TabIndex = 5;
            this.import_file_btn.Text = "Import File";
            this.import_file_btn.UseVisualStyleBackColor = false;
            this.import_file_btn.Click += new System.EventHandler(this.import_file_btn_Click);
            // 
            // speak_btn
            // 
            this.speak_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.speak_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.speak_btn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.speak_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.speak_btn.Location = new System.Drawing.Point(686, 582);
            this.speak_btn.Name = "speak_btn";
            this.speak_btn.Size = new System.Drawing.Size(162, 33);
            this.speak_btn.TabIndex = 4;
            this.speak_btn.Text = "Speak";
            this.speak_btn.UseVisualStyleBackColor = false;
            this.speak_btn.Click += new System.EventHandler(this.speak_btn_Click);
            // 
            // speed_selection
            // 
            this.speed_selection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.speed_selection.Cursor = System.Windows.Forms.Cursors.Hand;
            this.speed_selection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.speed_selection.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.speed_selection.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.speed_selection.FormattingEnabled = true;
            this.speed_selection.Items.AddRange(new object[] {
            "Default",
            "Extra Fast",
            "Fast",
            "Medium",
            "Slow",
            "Extra Slow"});
            this.speed_selection.Location = new System.Drawing.Point(925, 586);
            this.speed_selection.Name = "speed_selection";
            this.speed_selection.Size = new System.Drawing.Size(152, 25);
            this.speed_selection.TabIndex = 6;
            this.speed_selection.SelectedIndexChanged += new System.EventHandler(this.speed_selection_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.label1.Location = new System.Drawing.Point(851, 586);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Speed:";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1086, 627);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.speed_selection);
            this.Controls.Add(this.import_file_btn);
            this.Controls.Add(this.speak_btn);
            this.Controls.Add(this.date_and_time);
            this.Controls.Add(this.date_and_time_lbl);
            this.Controls.Add(this.text_field);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "3XPL017_N4T0#2918 | Text-2-Speech";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion
        private System.Windows.Forms.TextBox text_field;
        private System.Windows.Forms.Label date_and_time_lbl;
        private System.Windows.Forms.Label date_and_time;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button import_file_btn;
        private System.Windows.Forms.Button speak_btn;
        private System.Windows.Forms.ComboBox speed_selection;
        private System.Windows.Forms.Label label1;
    }
}

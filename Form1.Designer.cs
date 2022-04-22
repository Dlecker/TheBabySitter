namespace The_Baby_Sitter
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
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.BedtimeListBox1 = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.candyFromBaby = new System.Windows.Forms.Label();
            this.startTime = new System.Windows.Forms.ComboBox();
            this.endTime = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(95, 228);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Calculate Price Gouging";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Quote babysitting fee";
            // 
            // BedtimeListBox1
            // 
            this.BedtimeListBox1.FormattingEnabled = true;
            this.BedtimeListBox1.Items.AddRange(new object[] {
            "none",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.BedtimeListBox1.Location = new System.Drawing.Point(290, 84);
            this.BedtimeListBox1.Name = "BedtimeListBox1";
            this.BedtimeListBox1.Size = new System.Drawing.Size(121, 139);
            this.BedtimeListBox1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(290, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Select bed time";
            // 
            // candyFromBaby
            // 
            this.candyFromBaby.AutoSize = true;
            this.candyFromBaby.Location = new System.Drawing.Point(95, 238);
            this.candyFromBaby.Name = "candyFromBaby";
            this.candyFromBaby.Size = new System.Drawing.Size(0, 13);
            this.candyFromBaby.TabIndex = 11;
            // 
            // startTime
            // 
            this.startTime.FormattingEnabled = true;
            this.startTime.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "1",
            "2",
            "3"});
            this.startTime.Location = new System.Drawing.Point(98, 82);
            this.startTime.Name = "startTime";
            this.startTime.Size = new System.Drawing.Size(121, 21);
            this.startTime.TabIndex = 14;
            this.startTime.Text = "Start Time";
            // 
            // endTime
            // 
            this.endTime.FormattingEnabled = true;
            this.endTime.Items.AddRange(new object[] {
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "1",
            "2",
            "3",
            "4"});
            this.endTime.Location = new System.Drawing.Point(95, 152);
            this.endTime.Name = "endTime";
            this.endTime.Size = new System.Drawing.Size(121, 21);
            this.endTime.TabIndex = 15;
            this.endTime.Text = "End Time";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(75, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(363, 26);
            this.label3.TabIndex = 16;
            this.label3.Text = "Bodacious Babysitting Calculator";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.endTime);
            this.Controls.Add(this.startTime);
            this.Controls.Add(this.candyFromBaby);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BedtimeListBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox BedtimeListBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label candyFromBaby;
        private System.Windows.Forms.ComboBox startTime;
        private System.Windows.Forms.ComboBox endTime;
        private System.Windows.Forms.Label label3;
    }
}


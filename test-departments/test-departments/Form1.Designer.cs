namespace test_departments
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
            this.label_dep_count = new System.Windows.Forms.Label();
            this.label_stamp_count = new System.Windows.Forms.Label();
            this.textBoxDepCount = new System.Windows.Forms.TextBox();
            this.textBoxStampCount = new System.Windows.Forms.TextBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.labelDepsData = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_dep_count
            // 
            this.label_dep_count.AutoSize = true;
            this.label_dep_count.Location = new System.Drawing.Point(76, 114);
            this.label_dep_count.Name = "label_dep_count";
            this.label_dep_count.Size = new System.Drawing.Size(144, 17);
            this.label_dep_count.TabIndex = 0;
            this.label_dep_count.Text = "Количество отделов";
            // 
            // label_stamp_count
            // 
            this.label_stamp_count.AutoSize = true;
            this.label_stamp_count.Location = new System.Drawing.Point(75, 148);
            this.label_stamp_count.Name = "label_stamp_count";
            this.label_stamp_count.Size = new System.Drawing.Size(145, 17);
            this.label_stamp_count.TabIndex = 1;
            this.label_stamp_count.Text = "Количество печатей";
            // 
            // textBoxDepCount
            // 
            this.textBoxDepCount.Location = new System.Drawing.Point(250, 109);
            this.textBoxDepCount.Name = "textBoxDepCount";
            this.textBoxDepCount.Size = new System.Drawing.Size(100, 22);
            this.textBoxDepCount.TabIndex = 2;
            this.textBoxDepCount.Text = "3";
            // 
            // textBoxStampCount
            // 
            this.textBoxStampCount.Location = new System.Drawing.Point(250, 145);
            this.textBoxStampCount.Name = "textBoxStampCount";
            this.textBoxStampCount.Size = new System.Drawing.Size(100, 22);
            this.textBoxStampCount.TabIndex = 2;
            this.textBoxStampCount.Text = "5";
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(78, 221);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(142, 57);
            this.buttonStart.TabIndex = 3;
            this.buttonStart.Text = "Начать";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // labelDepsData
            // 
            this.labelDepsData.AutoSize = true;
            this.labelDepsData.Location = new System.Drawing.Point(427, 114);
            this.labelDepsData.Name = "labelDepsData";
            this.labelDepsData.Size = new System.Drawing.Size(46, 17);
            this.labelDepsData.TabIndex = 4;
            this.labelDepsData.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelDepsData);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.textBoxStampCount);
            this.Controls.Add(this.textBoxDepCount);
            this.Controls.Add(this.label_stamp_count);
            this.Controls.Add(this.label_dep_count);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_dep_count;
        private System.Windows.Forms.Label label_stamp_count;
        private System.Windows.Forms.TextBox textBoxDepCount;
        private System.Windows.Forms.TextBox textBoxStampCount;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Label labelDepsData;
    }
}


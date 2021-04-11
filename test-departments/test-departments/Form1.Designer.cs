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
            this.listViewDeps = new System.Windows.Forms.ListView();
            this.columnHeaderID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderNextDepK = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderStampI = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderStampJ = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderNextDepP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderStampS = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderStampT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderStampR = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.checkBoxInline = new System.Windows.Forms.CheckBox();
            this.checkBoxRandom = new System.Windows.Forms.CheckBox();
            this.textBoxEnd = new System.Windows.Forms.TextBox();
            this.textBoxStart = new System.Windows.Forms.TextBox();
            this.labelEnd = new System.Windows.Forms.Label();
            this.labelStart = new System.Windows.Forms.Label();
            this.buttonVasya = new System.Windows.Forms.Button();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label_dep_count
            // 
            this.label_dep_count.AutoSize = true;
            this.label_dep_count.Location = new System.Drawing.Point(33, 42);
            this.label_dep_count.Name = "label_dep_count";
            this.label_dep_count.Size = new System.Drawing.Size(144, 17);
            this.label_dep_count.TabIndex = 0;
            this.label_dep_count.Text = "Количество отделов";
            // 
            // label_stamp_count
            // 
            this.label_stamp_count.AutoSize = true;
            this.label_stamp_count.Location = new System.Drawing.Point(32, 76);
            this.label_stamp_count.Name = "label_stamp_count";
            this.label_stamp_count.Size = new System.Drawing.Size(145, 17);
            this.label_stamp_count.TabIndex = 1;
            this.label_stamp_count.Text = "Количество печатей";
            // 
            // textBoxDepCount
            // 
            this.textBoxDepCount.Location = new System.Drawing.Point(207, 41);
            this.textBoxDepCount.Name = "textBoxDepCount";
            this.textBoxDepCount.Size = new System.Drawing.Size(100, 22);
            this.textBoxDepCount.TabIndex = 2;
            this.textBoxDepCount.Text = "15";
            this.textBoxDepCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxStampCount
            // 
            this.textBoxStampCount.Location = new System.Drawing.Point(207, 77);
            this.textBoxStampCount.Name = "textBoxStampCount";
            this.textBoxStampCount.Size = new System.Drawing.Size(100, 22);
            this.textBoxStampCount.TabIndex = 2;
            this.textBoxStampCount.Text = "20";
            this.textBoxStampCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(34, 312);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(142, 57);
            this.buttonStart.TabIndex = 3;
            this.buttonStart.Text = "Сгенерировать отделы";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // listViewDeps
            // 
            this.listViewDeps.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderID,
            this.columnHeaderNextDepK,
            this.columnHeaderStampI,
            this.columnHeaderStampJ,
            this.columnHeaderNextDepP,
            this.columnHeaderStampS,
            this.columnHeaderStampT,
            this.columnHeaderStampR});
            this.listViewDeps.Dock = System.Windows.Forms.DockStyle.Right;
            this.listViewDeps.HideSelection = false;
            this.listViewDeps.Location = new System.Drawing.Point(402, 0);
            this.listViewDeps.Name = "listViewDeps";
            this.listViewDeps.Size = new System.Drawing.Size(813, 561);
            this.listViewDeps.TabIndex = 5;
            this.listViewDeps.UseCompatibleStateImageBehavior = false;
            this.listViewDeps.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderID
            // 
            this.columnHeaderID.Text = "Id";
            this.columnHeaderID.Width = 40;
            // 
            // columnHeaderNextDepK
            // 
            this.columnHeaderNextDepK.Text = "nextDepK";
            this.columnHeaderNextDepK.Width = 80;
            // 
            // columnHeaderStampI
            // 
            this.columnHeaderStampI.Text = "StampI";
            this.columnHeaderStampI.Width = 80;
            // 
            // columnHeaderStampJ
            // 
            this.columnHeaderStampJ.Text = "StampJ";
            this.columnHeaderStampJ.Width = 80;
            // 
            // columnHeaderNextDepP
            // 
            this.columnHeaderNextDepP.Text = "nextDepP";
            this.columnHeaderNextDepP.Width = 80;
            // 
            // columnHeaderStampS
            // 
            this.columnHeaderStampS.Text = "StampS";
            this.columnHeaderStampS.Width = 80;
            // 
            // columnHeaderStampT
            // 
            this.columnHeaderStampT.Text = "StampT";
            this.columnHeaderStampT.Width = 80;
            // 
            // columnHeaderStampR
            // 
            this.columnHeaderStampR.Text = "StampR";
            this.columnHeaderStampR.Width = 80;
            // 
            // checkBoxInline
            // 
            this.checkBoxInline.AutoSize = true;
            this.checkBoxInline.Checked = true;
            this.checkBoxInline.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxInline.Location = new System.Drawing.Point(34, 208);
            this.checkBoxInline.Name = "checkBoxInline";
            this.checkBoxInline.Size = new System.Drawing.Size(63, 21);
            this.checkBoxInline.TabIndex = 6;
            this.checkBoxInline.Text = "Inline";
            this.checkBoxInline.UseVisualStyleBackColor = true;
            this.checkBoxInline.CheckedChanged += new System.EventHandler(this.checkBoxInline_CheckedChanged);
            // 
            // checkBoxRandom
            // 
            this.checkBoxRandom.AutoSize = true;
            this.checkBoxRandom.Location = new System.Drawing.Point(34, 248);
            this.checkBoxRandom.Name = "checkBoxRandom";
            this.checkBoxRandom.Size = new System.Drawing.Size(253, 21);
            this.checkBoxRandom.TabIndex = 7;
            this.checkBoxRandom.Text = "Полностью рандомная генерация";
            this.checkBoxRandom.UseVisualStyleBackColor = true;
            this.checkBoxRandom.CheckedChanged += new System.EventHandler(this.checkBoxRandom_CheckedChanged);
            // 
            // textBoxEnd
            // 
            this.textBoxEnd.Location = new System.Drawing.Point(207, 160);
            this.textBoxEnd.Name = "textBoxEnd";
            this.textBoxEnd.Size = new System.Drawing.Size(100, 22);
            this.textBoxEnd.TabIndex = 10;
            this.textBoxEnd.Text = "3";
            this.textBoxEnd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxStart
            // 
            this.textBoxStart.Location = new System.Drawing.Point(207, 124);
            this.textBoxStart.Name = "textBoxStart";
            this.textBoxStart.Size = new System.Drawing.Size(100, 22);
            this.textBoxStart.TabIndex = 11;
            this.textBoxStart.Text = "1";
            this.textBoxStart.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelEnd
            // 
            this.labelEnd.AutoSize = true;
            this.labelEnd.Location = new System.Drawing.Point(32, 163);
            this.labelEnd.Name = "labelEnd";
            this.labelEnd.Size = new System.Drawing.Size(49, 17);
            this.labelEnd.TabIndex = 9;
            this.labelEnd.Text = "Конец";
            // 
            // labelStart
            // 
            this.labelStart.AutoSize = true;
            this.labelStart.Location = new System.Drawing.Point(33, 129);
            this.labelStart.Name = "labelStart";
            this.labelStart.Size = new System.Drawing.Size(58, 17);
            this.labelStart.TabIndex = 8;
            this.labelStart.Text = "Начало";
            // 
            // buttonVasya
            // 
            this.buttonVasya.Enabled = false;
            this.buttonVasya.Location = new System.Drawing.Point(223, 312);
            this.buttonVasya.Name = "buttonVasya";
            this.buttonVasya.Size = new System.Drawing.Size(142, 57);
            this.buttonVasya.TabIndex = 12;
            this.buttonVasya.Text = "Отправить Васю";
            this.buttonVasya.UseVisualStyleBackColor = true;
            this.buttonVasya.Click += new System.EventHandler(this.buttonVasya_Click);
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(35, 396);
            this.textBoxResult.Multiline = true;
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult.Size = new System.Drawing.Size(331, 153);
            this.textBoxResult.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1215, 561);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.buttonVasya);
            this.Controls.Add(this.textBoxEnd);
            this.Controls.Add(this.textBoxStart);
            this.Controls.Add(this.labelEnd);
            this.Controls.Add(this.labelStart);
            this.Controls.Add(this.checkBoxRandom);
            this.Controls.Add(this.checkBoxInline);
            this.Controls.Add(this.listViewDeps);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.textBoxStampCount);
            this.Controls.Add(this.textBoxDepCount);
            this.Controls.Add(this.label_stamp_count);
            this.Controls.Add(this.label_dep_count);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Departments";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_dep_count;
        private System.Windows.Forms.Label label_stamp_count;
        private System.Windows.Forms.TextBox textBoxDepCount;
        private System.Windows.Forms.TextBox textBoxStampCount;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.ListView listViewDeps;
        private System.Windows.Forms.ColumnHeader columnHeaderID;
        private System.Windows.Forms.ColumnHeader columnHeaderNextDepK;
        private System.Windows.Forms.ColumnHeader columnHeaderStampI;
        private System.Windows.Forms.ColumnHeader columnHeaderStampJ;
        private System.Windows.Forms.ColumnHeader columnHeaderStampT;
        private System.Windows.Forms.ColumnHeader columnHeaderStampR;
        private System.Windows.Forms.CheckBox checkBoxInline;
        private System.Windows.Forms.CheckBox checkBoxRandom;
        private System.Windows.Forms.TextBox textBoxEnd;
        private System.Windows.Forms.TextBox textBoxStart;
        private System.Windows.Forms.Label labelEnd;
        private System.Windows.Forms.Label labelStart;
        private System.Windows.Forms.Button buttonVasya;
        private System.Windows.Forms.ColumnHeader columnHeaderNextDepP;
        private System.Windows.Forms.ColumnHeader columnHeaderStampS;
        private System.Windows.Forms.TextBox textBoxResult;
    }
}


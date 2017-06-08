namespace MovieViewing
{
    partial class AddMovie
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
            this.btnClose = new MetroFramework.Controls.MetroButton();
            this.btnBrowse = new MetroFramework.Controls.MetroButton();
            this.tbPicturePath = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.cbTime1 = new MetroFramework.Controls.MetroComboBox();
            this.cbTime2 = new MetroFramework.Controls.MetroComboBox();
            this.cbTime3 = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.txtPrice = new MetroFramework.Controls.MetroTextBox();
            this.btnSubmit = new MetroFramework.Controls.MetroButton();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtTitle = new MetroFramework.Controls.MetroTextBox();
            this.txtGenre = new MetroFramework.Controls.MetroTextBox();
            this.txtRunTime = new MetroFramework.Controls.MetroTextBox();
            this.txtAuditorium = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(224, 415);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(125, 23);
            this.btnClose.TabIndex = 69;
            this.btnClose.Text = "Close";
            this.btnClose.UseSelectable = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click_1);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(224, 330);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(125, 23);
            this.btnBrowse.TabIndex = 68;
            this.btnBrowse.Text = "BROWSE...";
            this.btnBrowse.UseSelectable = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click_1);
            // 
            // tbPicturePath
            // 
            // 
            // 
            // 
            this.tbPicturePath.CustomButton.Image = null;
            this.tbPicturePath.CustomButton.Location = new System.Drawing.Point(235, 1);
            this.tbPicturePath.CustomButton.Name = "";
            this.tbPicturePath.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbPicturePath.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbPicturePath.CustomButton.TabIndex = 1;
            this.tbPicturePath.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbPicturePath.CustomButton.UseSelectable = true;
            this.tbPicturePath.CustomButton.Visible = false;
            this.tbPicturePath.Lines = new string[0];
            this.tbPicturePath.Location = new System.Drawing.Point(92, 369);
            this.tbPicturePath.MaxLength = 32767;
            this.tbPicturePath.Name = "tbPicturePath";
            this.tbPicturePath.PasswordChar = '\0';
            this.tbPicturePath.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbPicturePath.SelectedText = "";
            this.tbPicturePath.SelectionLength = 0;
            this.tbPicturePath.SelectionStart = 0;
            this.tbPicturePath.ShortcutsEnabled = true;
            this.tbPicturePath.Size = new System.Drawing.Size(257, 23);
            this.tbPicturePath.TabIndex = 67;
            this.tbPicturePath.UseSelectable = true;
            this.tbPicturePath.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbPicturePath.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(92, 330);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(46, 19);
            this.metroLabel9.TabIndex = 66;
            this.metroLabel9.Text = "Poster";
            // 
            // cbTime1
            // 
            this.cbTime1.FormattingEnabled = true;
            this.cbTime1.ItemHeight = 23;
            this.cbTime1.Items.AddRange(new object[] {
            "unselected",
            "12:00",
            "14:00",
            "16:00",
            "18:00",
            "20:00",
            "22:00"});
            this.cbTime1.Location = new System.Drawing.Point(224, 161);
            this.cbTime1.Name = "cbTime1";
            this.cbTime1.Size = new System.Drawing.Size(125, 29);
            this.cbTime1.TabIndex = 65;
            this.cbTime1.UseSelectable = true;
            // 
            // cbTime2
            // 
            this.cbTime2.FormattingEnabled = true;
            this.cbTime2.ItemHeight = 23;
            this.cbTime2.Items.AddRange(new object[] {
            "unselected",
            "12:00",
            "14:00",
            "16:00",
            "18:00",
            "20:00",
            "22:00"});
            this.cbTime2.Location = new System.Drawing.Point(224, 201);
            this.cbTime2.Name = "cbTime2";
            this.cbTime2.Size = new System.Drawing.Size(125, 29);
            this.cbTime2.TabIndex = 64;
            this.cbTime2.UseSelectable = true;
            // 
            // cbTime3
            // 
            this.cbTime3.FormattingEnabled = true;
            this.cbTime3.ItemHeight = 23;
            this.cbTime3.Items.AddRange(new object[] {
            "unselected",
            "12:00",
            "14:00",
            "16:00",
            "18:00",
            "20:00",
            "22:00"});
            this.cbTime3.Location = new System.Drawing.Point(224, 236);
            this.cbTime3.Name = "cbTime3";
            this.cbTime3.Size = new System.Drawing.Size(125, 29);
            this.cbTime3.TabIndex = 63;
            this.cbTime3.UseSelectable = true;
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(92, 300);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(38, 19);
            this.metroLabel10.TabIndex = 62;
            this.metroLabel10.Text = "Price";
            // 
            // txtPrice
            // 
            // 
            // 
            // 
            this.txtPrice.CustomButton.Image = null;
            this.txtPrice.CustomButton.Location = new System.Drawing.Point(103, 1);
            this.txtPrice.CustomButton.Name = "";
            this.txtPrice.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPrice.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPrice.CustomButton.TabIndex = 1;
            this.txtPrice.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPrice.CustomButton.UseSelectable = true;
            this.txtPrice.CustomButton.Visible = false;
            this.txtPrice.Lines = new string[0];
            this.txtPrice.Location = new System.Drawing.Point(224, 300);
            this.txtPrice.MaxLength = 32767;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.PasswordChar = '\0';
            this.txtPrice.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPrice.SelectedText = "";
            this.txtPrice.SelectionLength = 0;
            this.txtPrice.SelectionStart = 0;
            this.txtPrice.ShortcutsEnabled = true;
            this.txtPrice.Size = new System.Drawing.Size(125, 23);
            this.txtPrice.TabIndex = 54;
            this.txtPrice.UseSelectable = true;
            this.txtPrice.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPrice.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(92, 415);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(125, 23);
            this.btnSubmit.TabIndex = 61;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseSelectable = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(92, 271);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(75, 19);
            this.metroLabel8.TabIndex = 60;
            this.metroLabel8.Text = "Auditorium";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(92, 103);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(44, 19);
            this.metroLabel6.TabIndex = 58;
            this.metroLabel6.Text = "Genre";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(92, 132);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(64, 19);
            this.metroLabel5.TabIndex = 57;
            this.metroLabel5.Text = "Run Time";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(92, 161);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(84, 19);
            this.metroLabel4.TabIndex = 56;
            this.metroLabel4.Text = "Session Time";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(92, 201);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(84, 19);
            this.metroLabel3.TabIndex = 55;
            this.metroLabel3.Text = "Session Time";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(92, 236);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(84, 19);
            this.metroLabel2.TabIndex = 53;
            this.metroLabel2.Text = "Session Time";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(92, 74);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(33, 19);
            this.metroLabel1.TabIndex = 51;
            this.metroLabel1.Text = "Title";
            // 
            // txtTitle
            // 
            // 
            // 
            // 
            this.txtTitle.CustomButton.Image = null;
            this.txtTitle.CustomButton.Location = new System.Drawing.Point(103, 1);
            this.txtTitle.CustomButton.Name = "";
            this.txtTitle.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtTitle.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTitle.CustomButton.TabIndex = 1;
            this.txtTitle.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTitle.CustomButton.UseSelectable = true;
            this.txtTitle.CustomButton.Visible = false;
            this.txtTitle.Lines = new string[0];
            this.txtTitle.Location = new System.Drawing.Point(224, 74);
            this.txtTitle.MaxLength = 32767;
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.PasswordChar = '\0';
            this.txtTitle.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTitle.SelectedText = "";
            this.txtTitle.SelectionLength = 0;
            this.txtTitle.SelectionStart = 0;
            this.txtTitle.ShortcutsEnabled = true;
            this.txtTitle.Size = new System.Drawing.Size(125, 23);
            this.txtTitle.TabIndex = 48;
            this.txtTitle.UseSelectable = true;
            this.txtTitle.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTitle.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtGenre
            // 
            // 
            // 
            // 
            this.txtGenre.CustomButton.Image = null;
            this.txtGenre.CustomButton.Location = new System.Drawing.Point(103, 1);
            this.txtGenre.CustomButton.Name = "";
            this.txtGenre.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtGenre.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtGenre.CustomButton.TabIndex = 1;
            this.txtGenre.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtGenre.CustomButton.UseSelectable = true;
            this.txtGenre.CustomButton.Visible = false;
            this.txtGenre.Lines = new string[0];
            this.txtGenre.Location = new System.Drawing.Point(224, 103);
            this.txtGenre.MaxLength = 32767;
            this.txtGenre.Name = "txtGenre";
            this.txtGenre.PasswordChar = '\0';
            this.txtGenre.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtGenre.SelectedText = "";
            this.txtGenre.SelectionLength = 0;
            this.txtGenre.SelectionStart = 0;
            this.txtGenre.ShortcutsEnabled = true;
            this.txtGenre.Size = new System.Drawing.Size(125, 23);
            this.txtGenre.TabIndex = 49;
            this.txtGenre.UseSelectable = true;
            this.txtGenre.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtGenre.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtRunTime
            // 
            // 
            // 
            // 
            this.txtRunTime.CustomButton.Image = null;
            this.txtRunTime.CustomButton.Location = new System.Drawing.Point(103, 1);
            this.txtRunTime.CustomButton.Name = "";
            this.txtRunTime.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtRunTime.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtRunTime.CustomButton.TabIndex = 1;
            this.txtRunTime.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtRunTime.CustomButton.UseSelectable = true;
            this.txtRunTime.CustomButton.Visible = false;
            this.txtRunTime.Lines = new string[0];
            this.txtRunTime.Location = new System.Drawing.Point(224, 132);
            this.txtRunTime.MaxLength = 32767;
            this.txtRunTime.Name = "txtRunTime";
            this.txtRunTime.PasswordChar = '\0';
            this.txtRunTime.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtRunTime.SelectedText = "";
            this.txtRunTime.SelectionLength = 0;
            this.txtRunTime.SelectionStart = 0;
            this.txtRunTime.ShortcutsEnabled = true;
            this.txtRunTime.Size = new System.Drawing.Size(125, 23);
            this.txtRunTime.TabIndex = 50;
            this.txtRunTime.UseSelectable = true;
            this.txtRunTime.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtRunTime.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtAuditorium
            // 
            // 
            // 
            // 
            this.txtAuditorium.CustomButton.Image = null;
            this.txtAuditorium.CustomButton.Location = new System.Drawing.Point(103, 1);
            this.txtAuditorium.CustomButton.Name = "";
            this.txtAuditorium.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtAuditorium.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAuditorium.CustomButton.TabIndex = 1;
            this.txtAuditorium.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAuditorium.CustomButton.UseSelectable = true;
            this.txtAuditorium.CustomButton.Visible = false;
            this.txtAuditorium.Lines = new string[0];
            this.txtAuditorium.Location = new System.Drawing.Point(224, 271);
            this.txtAuditorium.MaxLength = 32767;
            this.txtAuditorium.Name = "txtAuditorium";
            this.txtAuditorium.PasswordChar = '\0';
            this.txtAuditorium.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAuditorium.SelectedText = "";
            this.txtAuditorium.SelectionLength = 0;
            this.txtAuditorium.SelectionStart = 0;
            this.txtAuditorium.ShortcutsEnabled = true;
            this.txtAuditorium.Size = new System.Drawing.Size(125, 23);
            this.txtAuditorium.TabIndex = 52;
            this.txtAuditorium.UseSelectable = true;
            this.txtAuditorium.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAuditorium.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // AddMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 483);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.tbPicturePath);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.cbTime1);
            this.Controls.Add(this.cbTime2);
            this.Controls.Add(this.cbTime3);
            this.Controls.Add(this.metroLabel10);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.txtGenre);
            this.Controls.Add(this.txtRunTime);
            this.Controls.Add(this.txtAuditorium);
            this.Name = "AddMovie";
            this.Text = "AddMovie";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnClose;
        private MetroFramework.Controls.MetroButton btnBrowse;
        private MetroFramework.Controls.MetroTextBox tbPicturePath;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroComboBox cbTime1;
        private MetroFramework.Controls.MetroComboBox cbTime2;
        private MetroFramework.Controls.MetroComboBox cbTime3;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroTextBox txtPrice;
        private MetroFramework.Controls.MetroButton btnSubmit;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtTitle;
        private MetroFramework.Controls.MetroTextBox txtGenre;
        private MetroFramework.Controls.MetroTextBox txtRunTime;
        private MetroFramework.Controls.MetroTextBox txtAuditorium;

    }
}
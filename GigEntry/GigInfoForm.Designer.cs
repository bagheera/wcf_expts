namespace GigEntry
{
    partial class GigInfoForm
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
            this.cmdSave = new System.Windows.Forms.Button();
            this.cmdGet = new System.Windows.Forms.Button();
            this.layoutEventInput = new System.Windows.Forms.TableLayoutPanel();
            this.lblUrl = new System.Windows.Forms.Label();
            this.lblDateEnd = new System.Windows.Forms.Label();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.lblDateStart = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.layoutEventInput.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdSave
            // 
            this.cmdSave.Location = new System.Drawing.Point(120, 316);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(75, 23);
            this.cmdSave.TabIndex = 6;
            this.cmdSave.Text = "&Save";
            this.cmdSave.UseVisualStyleBackColor = true;
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // cmdGet
            // 
            this.cmdGet.Location = new System.Drawing.Point(201, 316);
            this.cmdGet.Name = "cmdGet";
            this.cmdGet.Size = new System.Drawing.Size(75, 23);
            this.cmdGet.TabIndex = 8;
            this.cmdGet.Text = "&Get";
            this.cmdGet.UseVisualStyleBackColor = true;
            this.cmdGet.Click += new System.EventHandler(this.cmdGet_Click);
            // 
            // layoutEventInput
            // 
            this.layoutEventInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.layoutEventInput.AutoSize = true;
            this.layoutEventInput.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.layoutEventInput.ColumnCount = 2;
            this.layoutEventInput.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.66667F));
            this.layoutEventInput.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.33333F));
            this.layoutEventInput.Controls.Add(this.lblUrl, 0, 5);
            this.layoutEventInput.Controls.Add(this.lblDateEnd, 0, 4);
            this.layoutEventInput.Controls.Add(this.dtpEnd, 1, 4);
            this.layoutEventInput.Controls.Add(this.lblDateStart, 0, 3);
            this.layoutEventInput.Controls.Add(this.lblId, 0, 0);
            this.layoutEventInput.Controls.Add(this.lblTitle, 0, 1);
            this.layoutEventInput.Controls.Add(this.lblDescription, 0, 2);
            this.layoutEventInput.Controls.Add(this.txtId, 1, 0);
            this.layoutEventInput.Controls.Add(this.txtTitle, 1, 1);
            this.layoutEventInput.Controls.Add(this.txtDescription, 1, 2);
            this.layoutEventInput.Controls.Add(this.dtpStart, 1, 3);
            this.layoutEventInput.Controls.Add(this.txtUrl, 1, 5);
            this.layoutEventInput.Location = new System.Drawing.Point(31, 23);
            this.layoutEventInput.Name = "layoutEventInput";
            this.layoutEventInput.RowCount = 6;
            this.layoutEventInput.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.178278F));
            this.layoutEventInput.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.178278F));
            this.layoutEventInput.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.35223F));
            this.layoutEventInput.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.77743F));
            this.layoutEventInput.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.4375F));
            this.layoutEventInput.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.441718F));
            this.layoutEventInput.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34.66258F));
            this.layoutEventInput.Size = new System.Drawing.Size(337, 268);
            this.layoutEventInput.TabIndex = 9;
            // 
            // lblUrl
            // 
            this.lblUrl.AutoSize = true;
            this.lblUrl.Location = new System.Drawing.Point(3, 241);
            this.lblUrl.Name = "lblUrl";
            this.lblUrl.Size = new System.Drawing.Size(23, 13);
            this.lblUrl.TabIndex = 10;
            this.lblUrl.Text = "Url:";
            this.lblUrl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDateEnd
            // 
            this.lblDateEnd.AutoSize = true;
            this.lblDateEnd.Location = new System.Drawing.Point(3, 207);
            this.lblDateEnd.Name = "lblDateEnd";
            this.lblDateEnd.Size = new System.Drawing.Size(55, 13);
            this.lblDateEnd.TabIndex = 8;
            this.lblDateEnd.Text = "Date End:";
            this.lblDateEnd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtpEnd
            // 
            this.dtpEnd.Location = new System.Drawing.Point(102, 210);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(232, 20);
            this.dtpEnd.TabIndex = 9;
            this.dtpEnd.Value = new System.DateTime(2006, 8, 19, 0, 0, 0, 0);
            // 
            // lblDateStart
            // 
            this.lblDateStart.AutoSize = true;
            this.lblDateStart.Location = new System.Drawing.Point(3, 172);
            this.lblDateStart.Name = "lblDateStart";
            this.lblDateStart.Size = new System.Drawing.Size(58, 13);
            this.lblDateStart.TabIndex = 6;
            this.lblDateStart.Text = "Date Start:";
            this.lblDateStart.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(3, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(21, 13);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "ID:";
            this.lblId.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(3, 33);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(30, 13);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Title:";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(3, 66);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(63, 13);
            this.lblDescription.TabIndex = 2;
            this.lblDescription.Text = "Description:";
            this.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(102, 3);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(71, 20);
            this.txtId.TabIndex = 3;
            this.txtId.Text = "1000";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(102, 36);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(232, 20);
            this.txtTitle.TabIndex = 4;
            this.txtTitle.Text = "CD Release Party";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(102, 69);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(232, 79);
            this.txtDescription.TabIndex = 5;
            this.txtDescription.Text = "Join the band for a rockin\' party to celebrate our second CD release!";
            // 
            // dtpStart
            // 
            this.dtpStart.Location = new System.Drawing.Point(102, 175);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(232, 20);
            this.dtpStart.TabIndex = 7;
            this.dtpStart.Value = new System.DateTime(2006, 8, 19, 0, 0, 0, 0);
            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(102, 244);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(232, 20);
            this.txtUrl.TabIndex = 12;
            this.txtUrl.Text = "http://www.evildoersmusic.net";
            // 
            // GigInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 353);
            this.Controls.Add(this.layoutEventInput);
            this.Controls.Add(this.cmdGet);
            this.Controls.Add(this.cmdSave);
            this.Name = "GigInfoForm";
            this.Text = "Gig Entry";
            this.layoutEventInput.ResumeLayout(false);
            this.layoutEventInput.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdSave;
        private System.Windows.Forms.Button cmdGet;
        private System.Windows.Forms.TableLayoutPanel layoutEventInput;
        private System.Windows.Forms.Label lblUrl;
        private System.Windows.Forms.Label lblDateEnd;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.Label lblDateStart;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.TextBox txtUrl;
    }
}
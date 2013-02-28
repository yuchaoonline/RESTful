namespace RESTful.UIClient
{
    partial class ImgForm
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
            this.pctBox = new System.Windows.Forms.PictureBox();
            this.cbBoxImgNames = new System.Windows.Forms.ComboBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.openFileDlg = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pctBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pctBox
            // 
            this.pctBox.Location = new System.Drawing.Point(22, 49);
            this.pctBox.Name = "pctBox";
            this.pctBox.Size = new System.Drawing.Size(310, 325);
            this.pctBox.TabIndex = 0;
            this.pctBox.TabStop = false;
            // 
            // cbBoxImgNames
            // 
            this.cbBoxImgNames.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBoxImgNames.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.cbBoxImgNames.FormattingEnabled = true;
            this.cbBoxImgNames.Location = new System.Drawing.Point(22, 12);
            this.cbBoxImgNames.Name = "cbBoxImgNames";
            this.cbBoxImgNames.Size = new System.Drawing.Size(310, 27);
            this.cbBoxImgNames.TabIndex = 1;
            this.cbBoxImgNames.SelectedIndexChanged += new System.EventHandler(this.cbBoxImgNames_SelectedIndexChanged);
            // 
            // btnInsert
            // 
            this.btnInsert.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.btnInsert.Location = new System.Drawing.Point(32, 388);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(121, 30);
            this.btnInsert.TabIndex = 10;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.btnDelete.Location = new System.Drawing.Point(196, 388);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(121, 30);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // openFileDlg
            // 
            this.openFileDlg.FileName = "openFileDialog1";
            // 
            // ImgForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 435);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.cbBoxImgNames);
            this.Controls.Add(this.pctBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ImgForm";
            this.Opacity = 0.95D;
            this.Text = "ImgForm";
            this.Load += new System.EventHandler(this.ImgForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pctBox;
        private System.Windows.Forms.ComboBox cbBoxImgNames;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.OpenFileDialog openFileDlg;
    }
}
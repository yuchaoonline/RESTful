namespace RESTful.UIClient
{
    partial class Demo01
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvUser = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpBirth = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.cbBoxSex = new System.Windows.Forms.ComboBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnImage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUser
            // 
            this.dgvUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUser.Location = new System.Drawing.Point(8, 205);
            this.dgvUser.Name = "dgvUser";
            this.dgvUser.RowTemplate.Height = 23;
            this.dgvUser.Size = new System.Drawing.Size(609, 252);
            this.dgvUser.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.label1.Location = new System.Drawing.Point(36, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.label2.Location = new System.Drawing.Point(15, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.label3.Location = new System.Drawing.Point(51, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Sex:";
            // 
            // dtpBirth
            // 
            this.dtpBirth.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.dtpBirth.Location = new System.Drawing.Point(127, 162);
            this.dtpBirth.Name = "dtpBirth";
            this.dtpBirth.Size = new System.Drawing.Size(289, 24);
            this.dtpBirth.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.label4.Location = new System.Drawing.Point(44, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "Birth:";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.txtName.Location = new System.Drawing.Point(127, 51);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(289, 24);
            this.txtName.TabIndex = 6;
            // 
            // txtPwd
            // 
            this.txtPwd.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.txtPwd.Location = new System.Drawing.Point(127, 88);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.PasswordChar = '*';
            this.txtPwd.Size = new System.Drawing.Size(289, 24);
            this.txtPwd.TabIndex = 7;
            // 
            // cbBoxSex
            // 
            this.cbBoxSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBoxSex.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.cbBoxSex.FormattingEnabled = true;
            this.cbBoxSex.Items.AddRange(new object[] {
            "男",
            "女"});
            this.cbBoxSex.Location = new System.Drawing.Point(127, 124);
            this.cbBoxSex.Name = "cbBoxSex";
            this.cbBoxSex.Size = new System.Drawing.Size(289, 27);
            this.cbBoxSex.TabIndex = 8;
            // 
            // btnInsert
            // 
            this.btnInsert.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.btnInsert.Location = new System.Drawing.Point(445, 9);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(149, 30);
            this.btnInsert.TabIndex = 9;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.label5.Location = new System.Drawing.Point(59, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 19);
            this.label5.TabIndex = 10;
            this.label5.Text = "ID:";
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.txtID.Location = new System.Drawing.Point(127, 14);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(289, 24);
            this.txtID.TabIndex = 11;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.btnDelete.Location = new System.Drawing.Point(445, 47);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(149, 30);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.btnUpdate.Location = new System.Drawing.Point(445, 85);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(149, 30);
            this.btnUpdate.TabIndex = 13;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.btnSelect.Location = new System.Drawing.Point(445, 123);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(149, 30);
            this.btnSelect.TabIndex = 14;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnImage
            // 
            this.btnImage.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.btnImage.Location = new System.Drawing.Point(445, 161);
            this.btnImage.Name = "btnImage";
            this.btnImage.Size = new System.Drawing.Size(149, 30);
            this.btnImage.TabIndex = 15;
            this.btnImage.Text = "Image";
            this.btnImage.UseVisualStyleBackColor = true;
            this.btnImage.Click += new System.EventHandler(this.btnImage_Click);
            // 
            // Demo01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 464);
            this.Controls.Add(this.btnImage);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.cbBoxSex);
            this.Controls.Add(this.txtPwd);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpBirth);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Demo01";
            this.Opacity = 0.95D;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpBirth;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.ComboBox cbBoxSex;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnImage;
    }
}


using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Microsoft.Http;
using Newtonsoft.Json;
using RESTful.Entity;

namespace RESTful.UIClient
{
    public partial class Demo01 : Form
    {
        private const String BASE_USER_SERVICE = "http://localhost:1234/UserSvc/";
        
        /// <summary>
        /// 构造函数
        /// </summary>
        public Demo01()
        {
            InitializeComponent();
        }


        /// <summary>
        /// 窗体加载事件处理例程
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            cbBoxSex.SelectedIndex = 0;
            dtpBirth.Value = DateTime.Now.AddYears(-20);
        }


        #region 增删改查 - 按钮单击时间处理例程

        /// <summary>
        /// Insert 按钮单击事件处理例程
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnInsert_Click(object sender, EventArgs e)
        {
            String strName = txtName.Text.Trim();
            String strPwd = txtPwd.Text.Trim();
            String strSvcURI = BASE_USER_SERVICE + "User/Insert";

            if (String.IsNullOrEmpty(strName) || String.IsNullOrEmpty(strPwd))
            {
                MessageBox.Show("  UserName Or User Password Error !  ", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            String strSex = cbBoxSex.SelectedItem.ToString();
            DateTime dtBirth = dtpBirth.Value;

            UserEntity entity = new UserEntity();
            entity.UserName = strName;
            entity.UserPassword = strPwd;
            entity.UserSex = strSex;
            entity.UserBirth = dtBirth;
            entity.CreateDate = DateTime.Now;

            String strContent = JsonConvert.SerializeObject(entity);
            //Byte[] bytes = System.Text.Encoding.UTF8.GetBytes(strContent);
            HttpContent content = HttpContent.Create(strContent, "application/json");

            HttpClient client = new HttpClient();
            HttpResponseMessage responseMsg = client.Post(strSvcURI, content);
            responseMsg.EnsureStatusIsSuccessful(); 
        }


        /// <summary>
        /// Delete 按钮单击事件处理例程
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            String strUserID = txtID.Text.Trim();
            String strSvcURI = BASE_USER_SERVICE + "User/Delete/";

            if (String.IsNullOrEmpty(strUserID) == false)
            {
                try
                {
                    Int32 nUserID = Convert.ToInt32(strUserID);
                }
                catch
                {
                    MessageBox.Show("  User ID Error !  ", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                strSvcURI += strUserID;

                HttpClient client = new HttpClient();
                HttpResponseMessage responseMsg = client.Delete(strSvcURI);
                responseMsg.EnsureStatusIsSuccessful();
            }
            else
            {
                MessageBox.Show("  User ID Error !  ", "Error",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        /// <summary>
        /// Update 按钮单击事件处理例程
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            String strSvcURI = BASE_USER_SERVICE + "User/Update";
            String strID = txtID.Text.Trim();
            String strName = txtName.Text.Trim();
            String strPwd = txtPwd.Text.Trim();

            Int32 nUserID = 0;
            if (String.IsNullOrEmpty(strID) == false)
            {
                try
                {
                    nUserID = Convert.ToInt32(strID);
                }
                catch
                {
                    MessageBox.Show("  User ID Error !  ", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (String.IsNullOrEmpty(strName) || String.IsNullOrEmpty(strPwd))
                {
                    MessageBox.Show("  UserName Or User Password Error !  ", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                String strSex = cbBoxSex.SelectedItem.ToString();
                DateTime dtBirth = dtpBirth.Value;

                UserEntity entity = new UserEntity();
                entity.UserID = nUserID;
                entity.UserName = strName;
                entity.UserPassword = strPwd;
                entity.UserSex = strSex;
                entity.UserBirth = dtBirth;

                String strContent = JsonConvert.SerializeObject(entity);
                Byte[] bytes = System.Text.Encoding.UTF8.GetBytes(strContent);
                HttpContent content = HttpContent.Create(bytes, "application/json");
                
                HttpClient client = new HttpClient();
                HttpResponseMessage responseMsg = client.Put(strSvcURI, content);
                responseMsg.EnsureStatusIsSuccessful();
            }
            else
            {
                MessageBox.Show("  User ID Error !  ", "Error",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        /// <summary>
        /// Select 按钮单击事件处理例程
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSelect_Click(object sender, EventArgs e)
        {
            String strSvcURI = BASE_USER_SERVICE + "User/SelectAll";

            HttpClient client = new HttpClient();
            HttpResponseMessage responseMsg = client.Get(strSvcURI);
            responseMsg.EnsureStatusIsSuccessful();

            String strJson = responseMsg.Content.ReadAsString();

            List<UserEntity> entityList = JsonConvert.DeserializeObject<List<UserEntity>>(strJson);

            dgvUser.DataSource = entityList;
        }

        #endregion

        /// <summary>
        /// Image 按钮单击时间处理例程
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnImage_Click(object sender, EventArgs e)
        {
            ImgForm form = new ImgForm();
            form.Show();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Microsoft.Http;
using Newtonsoft.Json;

namespace RESTful.UIClient
{
    public partial class ImgForm : Form
    {
        private const String BASE_IMAGE_SERVICE = "http://localhost:1234/ImageSvc/";

        /// <summary>
        /// 构造函数
        /// </summary>
        public ImgForm()
        {
            InitializeComponent();
        }


        /// <summary>
        /// 窗体加载事件处理例程
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ImgForm_Load(object sender, EventArgs e)
        {
            BindAllImageName();

            openFileDlg.RestoreDirectory = true;
            openFileDlg.Filter = "Jpeg Files(*.jpg)|*.jpg|Gif Files(*.gif)|*.gif";
        }


        /// <summary>
        /// 绑定所有的 Image 到 ComboBox 上
        /// </summary>
        private void BindAllImageName()
        {
            String strSvcURI = BASE_IMAGE_SERVICE + "Image/SelectAll";

            HttpClient client = new HttpClient();
            HttpResponseMessage responseMsg = client.Get(strSvcURI);
            responseMsg.EnsureStatusIsSuccessful();

            String strJson = responseMsg.Content.ReadAsString();

            List<String> imgNameList = JsonConvert.DeserializeObject<List<String>>(strJson);

            cbBoxImgNames.DataSource = imgNameList;
        }


        /// <summary>
        /// 下拉列表选择改变事件处理例程
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbBoxImgNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            String strImgName = cbBoxImgNames.SelectedItem.ToString();
            String strSvcURI = String.Format("{0}Image/Select/{1}", BASE_IMAGE_SERVICE, strImgName);

            HttpClient client = new HttpClient();
            HttpResponseMessage responseMsg = client.Get(strSvcURI);
            responseMsg.EnsureStatusIsSuccessful();

            Stream stream = responseMsg.Content.ReadAsStream();
            
            pctBox.Image = (Bitmap)Bitmap.FromStream(stream);
        }


        /// <summary>
        /// Insert 按钮单击事件处理例程
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == openFileDlg.ShowDialog())
            {
                String strFilePath = openFileDlg.FileName;
                String strFileName = Path.GetFileName(strFilePath);

                String strSvcURI = String.Format("{0}Image/Insert/{1}", BASE_IMAGE_SERVICE, strFileName);

                HttpClient client = new HttpClient();
                HttpContent content = HttpContent.Create(File.OpenRead(strFilePath));

                HttpResponseMessage responseMsg = client.Post(strSvcURI, content);
                responseMsg.EnsureStatusIsSuccessful();

                BindAllImageName();
            }
        }


        /// <summary>
        /// Delete 按钮单击事件处理例程
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            String strImgName = cbBoxImgNames.SelectedItem.ToString();
            String strSvcURI = String.Format("{0}Image/Delete/{1}", BASE_IMAGE_SERVICE, strImgName);

            HttpClient client = new HttpClient();
            HttpResponseMessage responseMsg = client.Delete(strSvcURI);
            responseMsg.EnsureStatusIsSuccessful();

            BindAllImageName();
        }
    }
}

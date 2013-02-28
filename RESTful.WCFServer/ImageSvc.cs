using System;
using System.Collections.Generic;
using System.Net;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;
using RESTful.BLL;
using RESTful.Entity;
using System.IO;
using System.Web;
using System.Drawing;

namespace RESTful.WCFServer
{
    [ServiceContract]
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall)]
    public class ImageSvc
    {
        /// <summary>
        /// 往 Image 目录中新增一张新图片
        /// </summary>
        /// <param name="imgStream"></param>
        /// <param name="strImgName"></param>
        [OperationContract]
        [WebInvoke(UriTemplate = "Image/Insert/{strImgName}", Method = "POST", RequestFormat = WebMessageFormat.Json)]
        public void InsertImage(Stream imgStream, String strImgName)
        {
            String strImgDirs = String.Format(@"{0}App_Data\Image", HttpRuntime.AppDomainAppPath);
            String strImgPath = Path.Combine(strImgDirs, strImgName);

            if (File.Exists(strImgPath) == false)
            {
                Bitmap bitmap = (Bitmap)Bitmap.FromStream(imgStream);
                bitmap.Save(strImgPath);
            }
        }


        /// <summary>
        /// 从 Image 目录中删除一张图片
        /// </summary>
        /// <param name="strImgName"></param>
        [OperationContract]
        [WebInvoke(UriTemplate = "Image/Delete/{strImgName}", Method = "DELETE", RequestFormat = WebMessageFormat.Json)]
        public void DeleteImage(String strImgName)
        {
            String strImgDirs = String.Format(@"{0}App_Data\Image", HttpRuntime.AppDomainAppPath);
            String strImgPath = Path.Combine(strImgDirs, strImgName);

            WebOperationContext ctx = WebOperationContext.Current;
            ctx.OutgoingResponse.StatusCode = HttpStatusCode.OK;
            try
            {
                if (File.Exists(strImgPath) == true)
                {
                    File.Delete(strImgPath);
                }
            }
            catch (Exception ex)
            {
                ctx.OutgoingResponse.StatusCode = HttpStatusCode.ExpectationFailed;
                ctx.OutgoingResponse.StatusDescription = ex.Message;
            }
        }


        /// <summary>
        /// 从 Image 目录中查找出一张图片
        /// </summary>
        /// <param name="strImgName"></param>
        /// <returns></returns>
        [OperationContract]
        [WebGet(UriTemplate = "Image/Select/{strImgName}", ResponseFormat = WebMessageFormat.Json)]
        public Stream SelectImage(String strImgName)
        {
            String strImgDirs = String.Format(@"{0}App_Data\Image", HttpRuntime.AppDomainAppPath);
            String strImgPath = String.Format("{0}\\{1}", strImgDirs, strImgName);
            String strImgType = Path.GetExtension(strImgPath).TrimStart('.');

            WebOperationContext.Current.OutgoingResponse.ContentType = "image/" + strImgType;
            if (File.Exists(strImgPath) == true)
            {
                return File.OpenRead(strImgPath);
            }
            return null;
        }


        /// <summary>
        /// 查找出 Image 目录下的所有的图片名称
        /// </summary>
        /// <returns></returns>
        [OperationContract]
        [WebGet(UriTemplate = "Image/SelectAll", ResponseFormat = WebMessageFormat.Json)]
        public List<String> SelectAllImageNames()
        {
            List<String> rtList = new List<String>();
            String strImgDirs = String.Format(@"{0}App_Data\Image", HttpRuntime.AppDomainAppPath);
            if (Directory.Exists(strImgDirs))
            {
                DirectoryInfo dirInfo = new DirectoryInfo(strImgDirs);
                foreach(FileInfo file in dirInfo.GetFiles())
                {
                    rtList.Add(file.Name);
                }
            }
            return rtList;
        }
    }
}
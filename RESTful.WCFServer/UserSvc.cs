using System;
using System.Collections.Generic;
using System.Net;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;
using RESTful.BLL;
using RESTful.Entity;

namespace RESTful.WCFServer
{
    [ServiceContract]
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall)]
    public class UserSvc
    {
        /// <summary>
        /// 插入一条 User 记录
        /// </summary>
        /// <param name="entity"></param>
        [OperationContract]
        [WebInvoke(UriTemplate = "User/Insert", Method = "POST", RequestFormat = WebMessageFormat.Json)]
        public void InsertUser(UserEntity entity)
        {
            UserBLL.InsertUser(entity);
        }


        /// <summary>
        /// 删除一条 User 记录
        /// </summary>
        /// <param name="strUserID"></param>
        [OperationContract]
        [WebInvoke(UriTemplate = "User/Delete/{strUserID}", Method = "DELETE", RequestFormat = WebMessageFormat.Json)]
        public void DeleteUser(String strUserID)
        {
            WebOperationContext ctx = WebOperationContext.Current;
            ctx.OutgoingResponse.StatusCode = HttpStatusCode.OK;
            try
            {
                if (UserBLL.DeleteUser(Int32.Parse(strUserID)) == false)
                {
                    ctx.OutgoingResponse.StatusCode = HttpStatusCode.NoContent;
                }
                else
                {
                    ctx.OutgoingResponse.StatusCode = HttpStatusCode.Accepted;
                }
            }
            catch (Exception ex)
            {
                ctx.OutgoingResponse.StatusCode = HttpStatusCode.ExpectationFailed;
                ctx.OutgoingResponse.StatusDescription = ex.Message;
            }
        }


        /// <summary>
        /// 更新一条 User 记录
        /// </summary>
        /// <param name="entity"></param>
        [OperationContract]
        [WebInvoke(UriTemplate = "User/Update", Method = "PUT", RequestFormat = WebMessageFormat.Json)]
        public void UpdateUser(UserEntity entity)
        {            
            WebOperationContext ctx = WebOperationContext.Current;
            ctx.OutgoingResponse.StatusCode = HttpStatusCode.OK;
            try
            {
                if (UserBLL.UpdateUser(entity) == false)
                {
                    ctx.OutgoingResponse.StatusCode = HttpStatusCode.NoContent;
                }
                else
                {
                    ctx.OutgoingResponse.StatusCode = HttpStatusCode.Accepted;
                }
            }
            catch (Exception ex)
            {
                ctx.OutgoingResponse.StatusCode = HttpStatusCode.ExpectationFailed;
                ctx.OutgoingResponse.StatusDescription = ex.Message;
            }
        }


        /// <summary>
        /// 查找出一条指定 UserID 的 User 记录
        /// </summary>
        /// <param name="strUserID"></param>
        /// <returns></returns>
        [OperationContract]
        [WebGet(UriTemplate = "User/Select/{strUserID}", ResponseFormat = WebMessageFormat.Json)]
        public UserEntity SelectUser(String strUserID)
        {
            return UserBLL.SelectUser(Int32.Parse(strUserID));
        }


        /// <summary>
        /// 查找出所有的 User 记录
        /// </summary>
        /// <returns></returns>
        [OperationContract]
        [WebGet(UriTemplate = "User/SelectAll", ResponseFormat = WebMessageFormat.Json)]
        public List<UserEntity> SelectAllUser()
        {
            return UserBLL.SelectUser();
        }
    }
}
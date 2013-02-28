using System;
using System.Data;
using RESTful.DAL;
using RESTful.Entity;
using System.Collections.Generic;

namespace RESTful.BLL
{
    public class UserBLL
    {
        /// <summary>
        /// 插入一条 User 记录
        /// </summary>
        /// <param name="strName"></param>
        /// <param name="strPwd"></param>
        /// <param name="strSex"></param>
        /// <param name="dtBirth"></param>
        /// <returns></returns>
        public static bool InsertUser(String strName, String strPwd, String strSex, DateTime dtBirth)
        {
            UserEntity entity = new UserEntity();

            entity.UserName = strName;
            entity.UserPassword = strPwd;
            entity.UserSex = strSex;
            entity.UserBirth = dtBirth;
            entity.CreateDate = DateTime.Now;

            UserDAL dal = new UserDAL();

            return dal.InsertUser(entity);
        }


        /// <summary>
        /// 插入一条 User 记录
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public static bool InsertUser(UserEntity entity)
        {
            UserDAL dal = new UserDAL();

            return dal.InsertUser(entity);
        }



        /// <summary>
        /// 删除一条 User 记录
        /// </summary>
        /// <param name="nUserID"></param>
        /// <returns></returns>
        public static bool DeleteUser(Int32 nID)
        {
            UserEntity entity = new UserEntity();

            entity.UserID = nID;

            UserDAL dal = new UserDAL();

            return dal.DeleteUser(entity);
        }


        /// <summary>
        /// 更新一条 User 记录
        /// </summary>
        /// <param name="nID"></param>
        /// <param name="strName"></param>
        /// <param name="strPwd"></param>
        /// <param name="strSex"></param>
        /// <param name="dtBirth"></param>
        /// <returns></returns>
        public static bool UpdateUser(Int32 nID, String strName, String strPwd, String strSex, DateTime dtBirth)
        {
            UserEntity entity = new UserEntity();

            entity.UserID = nID;
            entity.UserName = strName;
            entity.UserPassword = strPwd;
            entity.UserSex = strSex;
            entity.UserBirth = dtBirth;

            UserDAL dal = new UserDAL();

            return dal.UpdateUser(entity);
        }


        /// <summary>
        /// 更新一条 User 记录
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public static bool UpdateUser(UserEntity entity)
        {
            UserDAL dal = new UserDAL();

            return dal.UpdateUser(entity);
        }


        /// <summary>
        /// 查找出一条 User 记录
        /// </summary>
        /// <param name="nID"></param>
        /// <returns></returns>
        public static UserEntity SelectUser(Int32 nID)
        {
            UserDAL dal = new UserDAL();

            return dal.SelectUser(nID);
        }


        /// <summary>
        /// 查找出所有的 User 记录
        /// </summary>
        /// <returns></returns>
        public static List<UserEntity> SelectUser()
        {
            UserDAL dal = new UserDAL();

            return dal.SelectUser();
        }
    }
}

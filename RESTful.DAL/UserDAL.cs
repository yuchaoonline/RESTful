using System;
using System.Data;
using System.Data.SQLite;
using RESTful.Entity;
using System.Collections.Generic;

namespace RESTful.DAL
{
    public class UserDAL
    {
        private SQLiteHelper sqlHelper;

        /// <summary>
        /// 构造函数
        /// </summary>
        public UserDAL()
        {
            sqlHelper = new SQLiteHelper();
        }


        /// <summary>
        /// 插入一条 User 记录
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public bool InsertUser(UserEntity entity)
        {
            String strSql = "INSERT INTO RESTful_User(UserName, UserPassword, UserSex, UserBirth, CreateDate) " +
                "VALUES(@UserName, @UserPassword, @UserSex, @UserBirth, @CreateDate)";

            SQLiteParameter[] paraArray = new SQLiteParameter[5];

            paraArray[0] = sqlHelper.InitSQLiteParameter("@UserName", ParameterDirection.Input, entity.UserName);
            paraArray[1] = sqlHelper.InitSQLiteParameter("@UserPassword", ParameterDirection.Input, entity.UserPassword);
            paraArray[2] = sqlHelper.InitSQLiteParameter("@UserSex", ParameterDirection.Input, entity.UserSex);
            paraArray[3] = sqlHelper.InitSQLiteParameter("@UserBirth", ParameterDirection.Input, entity.UserBirth);
            paraArray[4] = sqlHelper.InitSQLiteParameter("@CreateDate", ParameterDirection.Input, entity.CreateDate);

            try
            {
                if (sqlHelper.ExecuteNonQuery(strSql, CommandType.Text, paraArray) > 0)
                {
                    return true;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }


        /// <summary>
        /// 删除一条 User 记录
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public bool DeleteUser(UserEntity entity)
        {
            String strSql = "DELETE FROM RESTful_User WHERE UserID = @UserID";

            SQLiteParameter[] paraArray = new SQLiteParameter[1];

            paraArray[0] = sqlHelper.InitSQLiteParameter("@UserID", ParameterDirection.Input, entity.UserID);

            try
            {
                if (sqlHelper.ExecuteNonQuery(strSql, CommandType.Text, paraArray) > 0)
                {
                    return true;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }


        /// <summary>
        /// 更新一条 User 记录
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public bool UpdateUser(UserEntity entity)
        {
            String strSql = "UPDATE RESTful_User SET UserName = @UserName, " + 
                "UserPassword = @UserPassword, UserSex = @UserSex, UserBirth = @UserBirth " + 
                "WHERE UserID = @UserID";

            SQLiteParameter[] paraArray = new SQLiteParameter[5];

            paraArray[0] = sqlHelper.InitSQLiteParameter("@UserID", ParameterDirection.Input, entity.UserID);
            paraArray[1] = sqlHelper.InitSQLiteParameter("@UserName", ParameterDirection.Input, entity.UserName);
            paraArray[2] = sqlHelper.InitSQLiteParameter("@UserPassword", ParameterDirection.Input, entity.UserPassword);
            paraArray[3] = sqlHelper.InitSQLiteParameter("@UserSex", ParameterDirection.Input, entity.UserSex);
            paraArray[4] = sqlHelper.InitSQLiteParameter("@UserBirth", ParameterDirection.Input, entity.UserBirth);

            try
            {
                if (sqlHelper.ExecuteNonQuery(strSql, CommandType.Text, paraArray) > 0)
                {
                    return true;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }


        /// <summary>
        /// 查找一条 User 记录
        /// </summary>
        /// <param name="nUserID"></param>
        /// <returns></returns>
        public UserEntity SelectUser(Int32 nUserID)
        {
            String strSql = "SELECT UserID, UserName, UserPassword, UserSex, UserBirth, CreateDate " + 
                "FROM RESTful_User " + 
                "WHERE UserID = @UserID";
            
            SQLiteParameter[] paraArray = new SQLiteParameter[1];

            paraArray[0] = sqlHelper.InitSQLiteParameter("@UserID", ParameterDirection.Input, nUserID);

            UserEntity rtUser = null;
            using (SQLiteDataReader sqlDr = sqlHelper.ExecuteReader(strSql, CommandType.Text, paraArray))
            {
                if (sqlDr.Read())
                {
                    rtUser = new UserEntity();

                    rtUser.UserID = sqlDr.GetInt32(0);
                    rtUser.UserName = sqlDr.IsDBNull(1) == true ? String.Empty : sqlDr.GetString(1);
                    rtUser.UserPassword = sqlDr.IsDBNull(2) == true ? String.Empty : sqlDr.GetString(2);
                    rtUser.UserSex = sqlDr.IsDBNull(3) == true ? String.Empty : sqlDr.GetString(3);
                    rtUser.UserBirth = sqlDr.IsDBNull(4) == true ? DateTime.Now : sqlDr.GetDateTime(4);
                    rtUser.CreateDate = sqlDr.IsDBNull(5) == true ? DateTime.Now : sqlDr.GetDateTime(5);
                }
            }
            return rtUser;
        }


        /// <summary>
        /// 查找出所有的 User 记录
        /// </summary>
        /// <returns></returns>
        public List<UserEntity> SelectUser()
        {
            String strSql = "SELECT UserID, UserName, UserPassword, UserSex, UserBirth, CreateDate " +
                "FROM RESTful_User";

            List<UserEntity> rtUserList = new List<UserEntity>();
            using (SQLiteDataReader sqlDr = sqlHelper.ExecuteReader(strSql, CommandType.Text))
            {
                while (sqlDr.Read())
                {
                    UserEntity rtUser = new UserEntity();

                    rtUser.UserID = sqlDr.GetInt32(0);
                    rtUser.UserName = sqlDr.IsDBNull(1) == true ? String.Empty : sqlDr.GetString(1);
                    rtUser.UserPassword = sqlDr.IsDBNull(2) == true ? String.Empty : sqlDr.GetString(2);
                    rtUser.UserSex = sqlDr.IsDBNull(3) == true ? String.Empty : sqlDr.GetString(3);
                    rtUser.UserBirth = sqlDr.IsDBNull(4) == true ? DateTime.Now : sqlDr.GetDateTime(4);
                    rtUser.CreateDate = sqlDr.IsDBNull(5) == true ? DateTime.Now : sqlDr.GetDateTime(5);

                    rtUserList.Add(rtUser);
                }
            }

            return rtUserList;
        }
    }
}

using System;

namespace RESTful.Entity
{
    public class UserEntity
    {
        public virtual Int32 UserID { get; set; }

        public virtual String UserName { get; set; }

        public virtual String UserPassword { get; set; }

        public virtual String UserSex { get; set; }

        public virtual DateTime UserBirth { get; set; }

        public virtual DateTime CreateDate { get; set; }
    }
}

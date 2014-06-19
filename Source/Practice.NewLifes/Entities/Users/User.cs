﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Xml.Serialization;
using XCode;
using XCode.Configuration;
using XCode.DataAccessLayer;

namespace Practice.NewLifes.Entities.Users
{
    /// <summary></summary>
    [Serializable]
    [DataObject]
    [Description("")]
    [BindTable("User", Description = "", ConnName = "sqllite", DbType = DatabaseType.SQLite)]
    public partial class User : IUser
    {
        #region 属性
        private Int64 _Id;
        /// <summary></summary>
        [DisplayName("Id")]
        [Description("")]
        [DataObjectField(false, false, false, 8)]
        [BindColumn(1, "Id", "", null, "integer", 19, 0, false)]
        public virtual Int64 Id
        {
            get { return _Id; }
            set { if (OnPropertyChanging(__.Id, value)) { _Id = value; OnPropertyChanged(__.Id); } }
        }

        private Guid _UserGuid;
        /// <summary></summary>
        [DisplayName("UserGuid")]
        [Description("")]
        [DataObjectField(false, false, false, 16)]
        [BindColumn(2, "UserGuid", "", null, "guid", 0, 0, false)]
        public virtual Guid UserGuid
        {
            get { return _UserGuid; }
            set { if (OnPropertyChanging(__.UserGuid, value)) { _UserGuid = value; OnPropertyChanged(__.UserGuid); } }
        }

        private String _Name;
        /// <summary></summary>
        [DisplayName("Name")]
        [Description("")]
        [DataObjectField(false, false, false, 2147483647)]
        [BindColumn(3, "Name", "", null, "varchar(2147483647)", 100, 0, false)]
        public virtual String Name
        {
            get { return _Name; }
            set { if (OnPropertyChanging(__.Name, value)) { _Name = value; OnPropertyChanged(__.Name); } }
        }

        private String _Password;
        /// <summary></summary>
        [DisplayName("Password")]
        [Description("")]
        [DataObjectField(false, false, true, 2147483647)]
        [BindColumn(4, "Password", "", null, "varchar(2147483647)", 128, 0, false)]
        public virtual String Password
        {
            get { return _Password; }
            set { if (OnPropertyChanging(__.Password, value)) { _Password = value; OnPropertyChanged(__.Password); } }
        }

        private String _PasswordSalt;
        /// <summary></summary>
        [DisplayName("PasswordSalt")]
        [Description("")]
        [DataObjectField(false, false, true, 2147483647)]
        [BindColumn(5, "PasswordSalt", "", null, "varchar(2147483647)", 100, 0, false)]
        public virtual String PasswordSalt
        {
            get { return _PasswordSalt; }
            set { if (OnPropertyChanging(__.PasswordSalt, value)) { _PasswordSalt = value; OnPropertyChanged(__.PasswordSalt); } }
        }

        private String _Email;
        /// <summary></summary>
        [DisplayName("Email")]
        [Description("")]
        [DataObjectField(false, false, true, 2147483647)]
        [BindColumn(6, "Email", "", null, "varchar(2147483647)", 100, 0, false)]
        public virtual String Email
        {
            get { return _Email; }
            set { if (OnPropertyChanging(__.Email, value)) { _Email = value; OnPropertyChanged(__.Email); } }
        }

        private String _PhoneNumber;
        /// <summary></summary>
        [DisplayName("PhoneNumber")]
        [Description("")]
        [DataObjectField(false, false, true, 2147483647)]
        [BindColumn(7, "PhoneNumber", "", null, "varchar(2147483647)", 50, 0, false)]
        public virtual String PhoneNumber
        {
            get { return _PhoneNumber; }
            set { if (OnPropertyChanging(__.PhoneNumber, value)) { _PhoneNumber = value; OnPropertyChanged(__.PhoneNumber); } }
        }

        private DateTime _CreateTime;
        /// <summary></summary>
        [DisplayName("CreateTime")]
        [Description("")]
        [DataObjectField(false, false, false, 8)]
        [BindColumn(8, "CreateTime", "", null, "datetime", 0, 0, false)]
        public virtual DateTime CreateTime
        {
            get { return _CreateTime; }
            set { if (OnPropertyChanging(__.CreateTime, value)) { _CreateTime = value; OnPropertyChanged(__.CreateTime); } }
        }

        private DateTime _LastLoginDateTime;
        /// <summary></summary>
        [DisplayName("LastLoginDateTime")]
        [Description("")]
        [DataObjectField(false, false, true, 8)]
        [BindColumn(9, "LastLoginDateTime", "", null, "datetime", 0, 0, false)]
        public virtual DateTime LastLoginDateTime
        {
            get { return _LastLoginDateTime; }
            set { if (OnPropertyChanging(__.LastLoginDateTime, value)) { _LastLoginDateTime = value; OnPropertyChanged(__.LastLoginDateTime); } }
        }

        private Boolean _IsDelete;
        /// <summary></summary>
        [DisplayName("IsDelete")]
        [Description("")]
        [DataObjectField(false, false, false, 1)]
        [BindColumn(10, "IsDelete", "", "0", "bool", 0, 0, false)]
        public virtual Boolean IsDelete
        {
            get { return _IsDelete; }
            set { if (OnPropertyChanging(__.IsDelete, value)) { _IsDelete = value; OnPropertyChanged(__.IsDelete); } }
        }
        #endregion

        #region 获取/设置 字段值
        /// <summary>
        /// 获取/设置 字段值。
        /// 一个索引，基类使用反射实现。
        /// 派生实体类可重写该索引，以避免反射带来的性能损耗
        /// </summary>
        /// <param name="name">字段名</param>
        /// <returns></returns>
        public override Object this[String name]
        {
            get
            {
                switch (name)
                {
                    case __.Id : return _Id;
                    case __.UserGuid : return _UserGuid;
                    case __.Name : return _Name;
                    case __.Password : return _Password;
                    case __.PasswordSalt : return _PasswordSalt;
                    case __.Email : return _Email;
                    case __.PhoneNumber : return _PhoneNumber;
                    case __.CreateTime : return _CreateTime;
                    case __.LastLoginDateTime : return _LastLoginDateTime;
                    case __.IsDelete : return _IsDelete;
                    default: return base[name];
                }
            }
            set
            {
                switch (name)
                {
                    case __.Id : _Id = Convert.ToInt64(value); break;
                    case __.UserGuid : _UserGuid = (Guid)value; break;
                    case __.Name : _Name = Convert.ToString(value); break;
                    case __.Password : _Password = Convert.ToString(value); break;
                    case __.PasswordSalt : _PasswordSalt = Convert.ToString(value); break;
                    case __.Email : _Email = Convert.ToString(value); break;
                    case __.PhoneNumber : _PhoneNumber = Convert.ToString(value); break;
                    case __.CreateTime : _CreateTime = Convert.ToDateTime(value); break;
                    case __.LastLoginDateTime : _LastLoginDateTime = Convert.ToDateTime(value); break;
                    case __.IsDelete : _IsDelete = Convert.ToBoolean(value); break;
                    default: base[name] = value; break;
                }
            }
        }
        #endregion

        #region 字段名
        /// <summary>取得字段信息的快捷方式</summary>
        public partial class _
        {
            ///<summary></summary>
            public static readonly Field Id = FindByName(__.Id);

            ///<summary></summary>
            public static readonly Field UserGuid = FindByName(__.UserGuid);

            ///<summary></summary>
            public static readonly Field Name = FindByName(__.Name);

            ///<summary></summary>
            public static readonly Field Password = FindByName(__.Password);

            ///<summary></summary>
            public static readonly Field PasswordSalt = FindByName(__.PasswordSalt);

            ///<summary></summary>
            public static readonly Field Email = FindByName(__.Email);

            ///<summary></summary>
            public static readonly Field PhoneNumber = FindByName(__.PhoneNumber);

            ///<summary></summary>
            public static readonly Field CreateTime = FindByName(__.CreateTime);

            ///<summary></summary>
            public static readonly Field LastLoginDateTime = FindByName(__.LastLoginDateTime);

            ///<summary></summary>
            public static readonly Field IsDelete = FindByName(__.IsDelete);

            static Field FindByName(String name) { return Meta.Table.FindByName(name); }
        }

        /// <summary>取得字段名称的快捷方式</summary>
        partial class __
        {
            ///<summary></summary>
            public const String Id = "Id";

            ///<summary></summary>
            public const String UserGuid = "UserGuid";

            ///<summary></summary>
            public const String Name = "Name";

            ///<summary></summary>
            public const String Password = "Password";

            ///<summary></summary>
            public const String PasswordSalt = "PasswordSalt";

            ///<summary></summary>
            public const String Email = "Email";

            ///<summary></summary>
            public const String PhoneNumber = "PhoneNumber";

            ///<summary></summary>
            public const String CreateTime = "CreateTime";

            ///<summary></summary>
            public const String LastLoginDateTime = "LastLoginDateTime";

            ///<summary></summary>
            public const String IsDelete = "IsDelete";

        }
        #endregion
    }

    /// <summary>接口</summary>
    public partial interface IUser
    {
        #region 属性
        /// <summary></summary>
        Int64 Id { get; set; }

        /// <summary></summary>
        Guid UserGuid { get; set; }

        /// <summary></summary>
        String Name { get; set; }

        /// <summary></summary>
        String Password { get; set; }

        /// <summary></summary>
        String PasswordSalt { get; set; }

        /// <summary></summary>
        String Email { get; set; }

        /// <summary></summary>
        String PhoneNumber { get; set; }

        /// <summary></summary>
        DateTime CreateTime { get; set; }

        /// <summary></summary>
        DateTime LastLoginDateTime { get; set; }

        /// <summary></summary>
        Boolean IsDelete { get; set; }
        #endregion

        #region 获取/设置 字段值
        /// <summary>获取/设置 字段值。</summary>
        /// <param name="name">字段名</param>
        /// <returns></returns>
        Object this[String name] { get; set; }
        #endregion
    }
}
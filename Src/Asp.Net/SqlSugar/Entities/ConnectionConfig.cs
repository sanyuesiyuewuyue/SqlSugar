﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace SqlSugar
{
    public class ConnectionConfig
    {
        /// <summary>
        ///DbType.SqlServer Or Other
        /// </summary>
        public DbType DbType { get; set; }
        /// <summary>
        ///Database Connection string
        /// </summary>
        public string ConnectionString { get; set; }
        /// <summary>
        /// true does not need to close the connection
        /// </summary>
        public bool IsAutoCloseConnection { get; set; }
        /// <summary>
        /// Default SystemTable,If you do not have system table permissions, use attribute
        /// </summary>
        public InitKeyType InitKeyType = InitKeyType.SystemTable;
        /// <summary>
        /// Configure External Services replace default services,For example, Redis storage
        /// </summary>
        public ConfigureExternalServices ConfigureExternalServices = _DefaultServices;
        private static ConfigureExternalServices _DefaultServices = new ConfigureExternalServices();
    }
    
    public class ConfigureExternalServices
    {
        public ISerializeService SerializeService =DefaultServices.Serialize;
        public ICacheService ReflectionInoCache = DefaultServices.ReflectionInoCache;
    }
}

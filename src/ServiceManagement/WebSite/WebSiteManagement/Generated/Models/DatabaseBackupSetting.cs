// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;

namespace Microsoft.WindowsAzure.Management.WebSites.Models
{
    /// <summary>
    /// A specific backup.
    /// </summary>
    public partial class DatabaseBackupSetting
    {
        private string _connectionString;
        
        /// <summary>
        /// Optional. Contains a connection string to a database which is being
        /// backed up/restored. If the restore should happen to a new
        /// database, the database name inside is the new one.
        /// </summary>
        public string ConnectionString
        {
            get { return this._connectionString; }
            set { this._connectionString = value; }
        }
        
        private string _connectionStringName;
        
        /// <summary>
        /// Optional.  Contains a connection string name that is linked to the
        /// SiteConfig.ConnectionStrings.This is used during restore with
        /// overwrite connection strings options.
        /// </summary>
        public string ConnectionStringName
        {
            get { return this._connectionStringName; }
            set { this._connectionStringName = value; }
        }
        
        private string _databaseType;
        
        /// <summary>
        /// Optional. The database type (either SqlAzure or MySql)
        /// </summary>
        public string DatabaseType
        {
            get { return this._databaseType; }
            set { this._databaseType = value; }
        }
        
        private string _name;
        
        /// <summary>
        /// Optional. Always contains the original database name (it is used as
        /// a key for association with a dump in the backup package) - even if
        /// it is a restore to a new&different database.
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the DatabaseBackupSetting class.
        /// </summary>
        public DatabaseBackupSetting()
        {
        }
    }
}

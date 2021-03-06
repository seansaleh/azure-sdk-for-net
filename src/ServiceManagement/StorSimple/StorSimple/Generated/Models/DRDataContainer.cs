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
using System.Collections.Generic;
using System.Linq;
using Microsoft.WindowsAzure.Management.StorSimple.Models;

namespace Microsoft.WindowsAzure.Management.StorSimple.Models
{
    /// <summary>
    /// Represents the volume container information required for device failover
    /// </summary>
    public partial class DRDataContainer
    {
        private CloudType _cloudType;
        
        /// <summary>
        /// Required. The CloudType of the associated SAC
        /// </summary>
        public CloudType CloudType
        {
            get { return this._cloudType; }
            set { this._cloudType = value; }
        }
        
        private string _dataContainerId;
        
        /// <summary>
        /// Required. The volume container identifier
        /// </summary>
        public string DataContainerId
        {
            get { return this._dataContainerId; }
            set { this._dataContainerId = value; }
        }
        
        private string _instanceId;
        
        /// <summary>
        /// Optional. The instance identifier
        /// </summary>
        public string InstanceId
        {
            get { return this._instanceId; }
            set { this._instanceId = value; }
        }
        
        private string _location;
        
        /// <summary>
        /// Required. The location of the associated SAC
        /// </summary>
        public string Location
        {
            get { return this._location; }
            set { this._location = value; }
        }
        
        private string _name;
        
        /// <summary>
        /// Required. The name of the entity
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }
        
        private OperationInProgress _operationInProgress;
        
        /// <summary>
        /// Optional. The current operation in progress
        /// </summary>
        public OperationInProgress OperationInProgress
        {
            get { return this._operationInProgress; }
            set { this._operationInProgress = value; }
        }
        
        private bool _owned;
        
        /// <summary>
        /// Required. Flag indicating whether this data container is owned by
        /// the current device
        /// </summary>
        public bool Owned
        {
            get { return this._owned; }
            set { this._owned = value; }
        }
        
        private string _ownerDeviceId;
        
        /// <summary>
        /// Required. The owner of this DC. In case of a DR workflow failure,
        /// it is possible that the ownership is transferred, but the DC is
        /// still present with the original device
        /// </summary>
        public string OwnerDeviceId
        {
            get { return this._ownerDeviceId; }
            set { this._ownerDeviceId = value; }
        }
        
        private IList<DRVolume> _volumeList;
        
        /// <summary>
        /// Required. List of DR volumes
        /// </summary>
        public IList<DRVolume> VolumeList
        {
            get { return this._volumeList; }
            set { this._volumeList = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the DRDataContainer class.
        /// </summary>
        public DRDataContainer()
        {
            this.VolumeList = new List<DRVolume>();
        }
    }
}

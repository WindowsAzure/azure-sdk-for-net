// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;
using Microsoft.Azure.Management.Automation.Models;

namespace Microsoft.Azure.Management.Automation.Models
{
    /// <summary>
    /// Definition of the credential.
    /// </summary>
    public partial class Credential
    {
        private string _name;
        
        /// <summary>
        /// Optional. Gets or sets the name of the credential.
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }
        
        private CredentialProperties _properties;
        
        /// <summary>
        /// Optional. Gets or sets the properties of the credential.
        /// </summary>
        public CredentialProperties Properties
        {
            get { return this._properties; }
            set { this._properties = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the Credential class.
        /// </summary>
        public Credential()
        {
        }
    }
}

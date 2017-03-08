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
    /// The parameters supplied to the patch variable operation.
    /// </summary>
    public partial class VariablePatchParameters
    {
        private string _name;
        
        /// <summary>
        /// Required. Gets or sets the name of the variable.
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }
        
        private VariablePatchProperties _properties;
        
        /// <summary>
        /// Optional. Gets or sets the value of the variable.
        /// </summary>
        public VariablePatchProperties Properties
        {
            get { return this._properties; }
            set { this._properties = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the VariablePatchParameters class.
        /// </summary>
        public VariablePatchParameters()
        {
        }
        
        /// <summary>
        /// Initializes a new instance of the VariablePatchParameters class
        /// with required arguments.
        /// </summary>
        public VariablePatchParameters(string name)
            : this()
        {
            if (name == null)
            {
                throw new ArgumentNullException("name");
            }
            this.Name = name;
        }
    }
}

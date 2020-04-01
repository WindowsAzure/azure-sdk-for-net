// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Analytics.Synapse.Development.Models
{
    /// <summary> SSIS package execution log location. </summary>
    public partial class SsisLogLocation
    {
        /// <summary> Initializes a new instance of SsisLogLocation. </summary>
        /// <param name="logPath"> The SSIS package execution log path. Type: string (or Expression with resultType string). </param>
        public SsisLogLocation(object logPath)
        {
            if (logPath == null)
            {
                throw new ArgumentNullException(nameof(logPath));
            }

            LogPath = logPath;
            Type = "File";
        }

        /// <summary> Initializes a new instance of SsisLogLocation. </summary>
        /// <param name="logPath"> The SSIS package execution log path. Type: string (or Expression with resultType string). </param>
        /// <param name="type"> The type of SSIS log location. </param>
        /// <param name="accessCredential"> The package execution log access credential. </param>
        /// <param name="logRefreshInterval"> Specifies the interval to refresh log. The default interval is 5 minutes. Type: string (or Expression with resultType string), pattern: ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])). </param>
        internal SsisLogLocation(object logPath, string type, SsisAccessCredential accessCredential, object logRefreshInterval)
        {
            LogPath = logPath;
            Type = type;
            AccessCredential = accessCredential;
            LogRefreshInterval = logRefreshInterval;
        }

        /// <summary> The SSIS package execution log path. Type: string (or Expression with resultType string). </summary>
        public object LogPath { get; set; }
        /// <summary> The type of SSIS log location. </summary>
        public string Type { get; set; }
        /// <summary> The package execution log access credential. </summary>
        public SsisAccessCredential AccessCredential { get; set; }
        /// <summary> Specifies the interval to refresh log. The default interval is 5 minutes. Type: string (or Expression with resultType string), pattern: ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])). </summary>
        public object LogRefreshInterval { get; set; }
    }
}

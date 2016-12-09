// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
namespace Microsoft.Azure.Management.AppService.Fluent
{
    using Microsoft.Azure.Management.AppService.Fluent.Models;
    using Microsoft.Azure.Management.Resource.Fluent.Core;

    /// <summary>
    /// A web app source control in a web app.
    /// </summary>
    public interface IWebAppSourceControl  :
        IWrapper<Microsoft.Azure.Management.AppService.Fluent.Models.SiteSourceControlInner>,
        IChildResource<Microsoft.Azure.Management.AppService.Fluent.IWebAppBase<object>>
    {
        Microsoft.Azure.Management.AppService.Fluent.RepositoryType RepositoryType { get; }

        string Branch { get; }

        string RepositoryUrl { get; }

        bool IsManualIntegration { get; }

        bool DeploymentRollbackEnabled { get; }
    }
}
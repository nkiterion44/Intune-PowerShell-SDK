// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.workbookSessionInfo&quot; (or one of its derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.workbookSessionInfo&quot; (or one of its derived types).</para>
    /// </summary>
    [Cmdlet("New", "WorkbookSessionInfoObject", DefaultParameterSetName = @"microsoft.graph.workbookSessionInfo")]
    [ODataType("microsoft.graph.workbookSessionInfo")]
    public class New_WorkbookSessionInfoObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;persistChanges&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookSessionInfo&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.workbookSessionInfo", HelpMessage = @"The &quot;persistChanges&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean persistChanges { get; set; }
    }
}
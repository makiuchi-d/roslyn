﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Threading;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis.ExternalAccess.VSTypeScript.Api;

namespace Microsoft.CodeAnalysis.ExternalAccess.VSTypeScript
{
    /// <summary>
    /// Language service that allows a language to participate in the editor's inline rename feature.
    /// </summary>
    internal interface IVSTypeScriptEditorInlineRenameService
    {
        Task<IVSTypeScriptInlineRenameInfo> GetRenameInfoAsync(Document document, int position, CancellationToken cancellationToken);
    }
}

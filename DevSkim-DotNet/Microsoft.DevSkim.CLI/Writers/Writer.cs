﻿// Copyright (C) Microsoft. All rights reserved.
// Licensed under the MIT License.

using System.IO;

namespace Microsoft.DevSkim.CLI.Writers
{
    public abstract class Writer
    {
#nullable disable
        
        public TextWriter TextWriter { get; set; }
#nullable restore
        public abstract void WriteIssue(IssueRecord issue);
        public abstract void FlushAndClose();
    }
}

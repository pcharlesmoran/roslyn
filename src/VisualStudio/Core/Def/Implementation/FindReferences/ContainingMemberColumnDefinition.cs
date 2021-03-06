﻿// Copyright (c) Microsoft.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.

using System.ComponentModel.Composition;
using Microsoft.CodeAnalysis.FindSymbols.Finders;
using Microsoft.VisualStudio.Composition;
using Microsoft.VisualStudio.Shell.TableControl;
using Microsoft.VisualStudio.Utilities;

namespace Microsoft.VisualStudio.LanguageServices.Implementation.FindReferences
{
    /// <summary>
    /// Custom column to display the containing member for the Find All References window.
    /// </summary>
    [Export(typeof(ITableColumnDefinition))]
    [Name(ColumnName)]
    internal class ContainingMemberColumnDefinition : TableColumnDefinitionBase
    {
        public const string ColumnName = AbstractReferenceFinder.ContainingMemberInfoPropertyName;
        public override bool IsFilterable => true;
        public override string Name => ColumnName;
        public override string DisplayName => ServicesVSResources.Containing_member;
    }
}

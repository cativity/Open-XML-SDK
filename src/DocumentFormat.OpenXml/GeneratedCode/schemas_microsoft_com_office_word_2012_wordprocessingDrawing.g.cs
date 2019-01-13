﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
using System;
using System.Collections.Generic;
using System.IO.Packaging;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Drawing;

namespace DocumentFormat.OpenXml.Office2013.Word.Drawing
{
/// <summary>
/// <para>Defines the WebVideoProperty Class.</para>
/// <para>This class is available in Office 2013 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is wp15:webVideoPr.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class WebVideoProperty : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 13435;
    /// <inheritdoc/>
    public override string LocalName => "webVideoPr";
    internal override byte NamespaceId => 75;
    internal override int ElementTypeId => ElementTypeIdConst;
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2013;

    
    
        /// <summary>
    /// <para> embeddedHtml.</para>
    /// <para>Represents the following attribute in the schema: embeddedHtml </para>
    /// </summary>
    [SchemaAttr(0, "embeddedHtml")]
    [SchemaIndex(0)]
    public StringValue EmbeddedHtml { get; set; }
    /// <summary>
    /// <para> h.</para>
    /// <para>Represents the following attribute in the schema: h </para>
    /// </summary>
    [SchemaAttr(0, "h")]
    [SchemaIndex(1)]
    public UInt32Value Height { get; set; }
    /// <summary>
    /// <para> w.</para>
    /// <para>Represents the following attribute in the schema: w </para>
    /// </summary>
    [SchemaAttr(0, "w")]
    [SchemaIndex(2)]
    public UInt32Value Width { get; set; }

    /// <summary>
    /// Initializes a new instance of the WebVideoProperty class.
    /// </summary>
    public WebVideoProperty():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<WebVideoProperty>(deep);

}
}
 
 

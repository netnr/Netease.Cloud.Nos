﻿using System;
using System.Xml.Serialization;

namespace Netease.Cloud.NOS.Model.XmlModel
{
    [XmlRoot("CompleteMultipartUpload")]
    public class CompleteMultipartUploadRequestModel
    {
        [XmlElement("Part")]
        public CompletePart[] Parts { get; set; }

        [XmlRoot("Part")]
        public class CompletePart
        {
            [XmlElement("PartNumber")]
            public int PartNumber { get; set; }

            [XmlElement("ETag")]
            public string ETag { get; set; }
        }
    }
}

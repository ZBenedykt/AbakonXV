﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;

namespace AbakonDataModel
{
    [ComplexType]
    public class InfoFile
    {
        public int Attributes { get; set; }
        public DateTime CreationTime { get; set; }
        public DateTime CreationTimeUtc { get; set; }
        public string Directory { get; set; }
        public string DirectoryName { get; set; }
        public string Extension { get; set; }
        public string FullName { get; set; }
        public bool IsReadOnly { get; set; }
        public DateTime LastAccessTime { get; set; }
        public DateTime LastAccessTimeUtc { get; set; }
        public DateTime LastWriteTime { get; set; }
        public DateTime LastWriteTimeUtc { get; set; }
        public long Length { get; set; }
        public string Name { get; set; }
    }
}

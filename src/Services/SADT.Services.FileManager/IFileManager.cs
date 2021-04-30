﻿using SADT.Core.Enums;

namespace SADT.Services.FileManager
{
    public interface IFileManager
    {
        public LoadEventType LoadEventType { get; set; }

        public TransformerType TransformerType { get; set; }

        public string NameProject { get; set; }

        public string PathToProject { get; set; }
    }
}
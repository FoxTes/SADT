﻿using SADT.Core.Enums;
using System;

namespace SADT.Services.FileManager
{
    public interface IFileManager
    {
        event EventHandler ProjectChanged;

        public LoadEventType LoadEventType { get; set; }

        public TransformerType TransformerType { get; set; }

        public string NameProject { get; set; }

        public string PathToProject { get; set; }

        public void NotificationProjectChange();
    }
}

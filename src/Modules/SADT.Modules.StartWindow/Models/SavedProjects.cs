using SADT.Core.Enums;
using System;

namespace SADT.Modules.StartWindow.Models
{
    public class SavedProjects
    {
        public TransformerType TypeTransformer { get; set; }

        public string NameProject { get; set; }

        public string PathToProject { get; set; }

        public DateTime DateCreate { get; set; }

        public bool IsPinned { get; set; }
    }
}

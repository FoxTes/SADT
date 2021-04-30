using SADT.Core.Enums;
using System;

namespace SADT.Modules.StartWindow.Models
{
    public class SaveProject
    {
        public TransformerType TypeTransformer { get; set; }

        public string NameProject { get; set; }

        public string PathProject { get; set; }

        public DateTime DateCreate { get; set; }
    }
}

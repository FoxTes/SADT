using SADT.Core.Enums;
using SADT.DataAccess.Sqlite.Entitys.Base;
using System;

namespace SADT.DataAccess.Sqlite.Entitys
{
    public class LastProject : BaseEntity
    {
        public TransformerType TypeTransformer { get; set; }

        public string NameProject { get; set; }

        public string PathProject { get; set; }

        public DateTime DateCreate { get; set; }
    }
}

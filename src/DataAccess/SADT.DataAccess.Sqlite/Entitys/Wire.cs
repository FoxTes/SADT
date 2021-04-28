using SADT.DataAccess.Sqlite.Entitys.Base;
using System.Collections.Generic;

namespace SADT.DataAccess.Sqlite.Entitys
{
    public class Wire : BaseEntity
    {
        public string Name { get; set; }

        public List<PressurePoint> PressurePoints { get; set; }
    }
}

using SADT.DataAccess.Sqlite.Entitys.Base;
using System.Collections.Generic;

namespace SADT.DataAccess.Sqlite.Entitys.Wire
{
    public class Wire : BaseEntity
    {
        public string Name { get; set; }

        public List<PressurePoint> PressurePoints { get; set; }
    }
}

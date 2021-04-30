using SADT.DataAccess.Sqlite.Entitys.Base;

namespace SADT.DataAccess.Sqlite.Entitys.Wire
{
    public class PressurePoint : BaseEntity
    {
        public double Pressure { get; set; }

        public int WireId { get; set; }

        public Wire Wire { get; set; }
    }
}

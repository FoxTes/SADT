using System.ComponentModel;
using SADT.Modules.TechnicalTask.EnumExtension;
using SADT.Modules.TechnicalTask.Properties;

namespace SADT.Modules.TechnicalTask.Enums
{
    /// <summary>
    /// Частота, Гц.
    /// </summary>
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum Frequency
    {
        /// <summary>
        /// 50.
        /// </summary>
        [LocalizedDescription("Frequency50", typeof(Resources))]
        Hz50,

        /// <summary>
        /// 60.
        /// </summary>
        [LocalizedDescription("Frequency60", typeof(Resources))]
        Hz60
    }
}

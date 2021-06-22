using System.ComponentModel;
using SADT.Modules.TechnicalTask.EnumExtension;
using SADT.Modules.TechnicalTask.Properties;

namespace SADT.Modules.TechnicalTask.Enums
{
    /// <summary>
    /// Число фаз.
    /// </summary>
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum PhaseNumber
    {
        /// <summary>
        /// 1.
        /// </summary>
        [LocalizedDescription("PhaseNumber1", typeof(Resources))]
        Number1,

        /// <summary>
        /// 3.
        /// </summary>
        [LocalizedDescription("PhaseNumber3", typeof(Resources))]
        Number3
    }
}

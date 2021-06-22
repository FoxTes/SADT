using System.ComponentModel;
using SADT.Modules.TechnicalTask.EnumExtension;
using SADT.Modules.TechnicalTask.Properties;

namespace SADT.Modules.TechnicalTask.Enums
{
    /// <summary>
    /// Категория исполнения внешней изоляции.
    /// </summary>
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ExternalInsulation
    {
        /// <summary>
        /// I.
        /// </summary>
        [LocalizedDescription("InternalInsulationI", typeof(Resources))]
        I,

        /// <summary>
        /// II.
        /// </summary>
        [LocalizedDescription("InternalInsulationII", typeof(Resources))]
        II,

        /// <summary>
        /// II*.
        /// </summary>
        [LocalizedDescription("InternalInsulationIIx", typeof(Resources))]
        IIx,

        /// <summary>
        /// III.
        /// </summary>
        [LocalizedDescription("InternalInsulationIII", typeof(Resources))]
        III,

        /// <summary>
        /// IV.
        /// </summary>
        [LocalizedDescription("InternalInsulationIV", typeof(Resources))]
        IV
    }
}

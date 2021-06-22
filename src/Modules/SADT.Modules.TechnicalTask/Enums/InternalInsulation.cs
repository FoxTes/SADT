using System.ComponentModel;
using SADT.Modules.TechnicalTask.EnumExtension;
using SADT.Modules.TechnicalTask.Properties;

namespace SADT.Modules.TechnicalTask.Enums
{
    /// <summary>
    /// Уровень исполнения внутренней изоляции.
    /// </summary>
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum InternalInsulation
    {
        /// <summary>
        /// а.
        /// </summary>
        [LocalizedDescription("InternalInsulationa", typeof(Resources))]
        Typea,

        /// <summary>
        /// б.
        /// </summary>
        [LocalizedDescription("InternalInsulationb", typeof(Resources))]
        Typeb
    }
}

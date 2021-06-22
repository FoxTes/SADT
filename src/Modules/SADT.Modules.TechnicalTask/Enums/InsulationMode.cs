using System.ComponentModel;
using SADT.Modules.TechnicalTask.EnumExtension;
using SADT.Modules.TechnicalTask.Properties;

namespace SADT.Modules.TechnicalTask.Enums
{
    /// <summary>
    /// Режим технологической обработки изоляции.
    /// </summary>
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum InsulationMode
    {
        /// <summary>
        /// А.
        /// </summary>
        [LocalizedDescription("InsulationModeA", typeof(Resources))]
        TypeA
    }
}

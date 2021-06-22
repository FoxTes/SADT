using System.ComponentModel;
using SADT.Modules.TechnicalTask.EnumExtension;
using SADT.Modules.TechnicalTask.Properties;

namespace SADT.Modules.TechnicalTask.Enums
{
    /// <summary>
    /// Режим нагрузки.
    /// </summary>
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum LoadMode
    {
        /// <summary>
        /// 2.5.
        /// </summary>
        [LocalizedDescription("LoadModeLong", typeof(Resources))]
        Long,

        /// <summary>
        /// 4.0.
        /// </summary>
        [LocalizedDescription("LoadModeShort", typeof(Resources))]
        Short
    }  
}

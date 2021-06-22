using System.ComponentModel;
using SADT.Modules.TechnicalTask.EnumExtension;
using SADT.Modules.TechnicalTask.Properties;

namespace SADT.Modules.TechnicalTask.Enums
{
    /// <summary>
    /// Схема соединения ВН.
    /// </summary>
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ConnectionTypeHighVoltage
    {
        /// <summary>
        /// Y.
        /// </summary>
        [LocalizedDescription("ConnectionTypeHighVoltageY", typeof(Resources))]
        Y,

        /// <summary>
        /// Yн.
        /// </summary>
        [LocalizedDescription("ConnectionTypeHighVoltageYn", typeof(Resources))]
        Yn,        

        /// <summary>
        /// D.
        /// </summary>
        [LocalizedDescription("ConnectionTypeHighVoltageD", typeof(Resources))]
        D
    }  
}

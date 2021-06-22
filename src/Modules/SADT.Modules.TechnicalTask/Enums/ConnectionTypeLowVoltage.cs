using System.ComponentModel;
using SADT.Modules.TechnicalTask.EnumExtension;
using SADT.Modules.TechnicalTask.Properties;

namespace SADT.Modules.TechnicalTask.Enums
{
    /// <summary>
    /// Схема соединения.
    /// </summary>
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ConnectionTypeLowVoltage
    {
        /// <summary>
        /// Y.
        /// </summary>
        [LocalizedDescription("ConnectionTypeLowVoltageY", typeof(Resources))]
        Y,

        /// <summary>
        /// Yн.
        /// </summary>
        [LocalizedDescription("ConnectionTypeLowVoltageYn", typeof(Resources))]
        Yn,        

        /// <summary>
        /// D.
        /// </summary>
        [LocalizedDescription("ConnectionTypeLowVoltageD", typeof(Resources))]
        D,

        /// <summary>
        /// Z.
        /// </summary>
        [LocalizedDescription("ConnectionTypeLowVoltageZ", typeof(Resources))]
        Z
    }  
}

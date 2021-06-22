using System.ComponentModel;
using SADT.Modules.TechnicalTask.EnumExtension;
using SADT.Modules.TechnicalTask.Properties;

namespace SADT.Modules.TechnicalTask.Enums
{
    /// <summary>
    /// Климатическое исполнение.
    /// </summary>
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ClimaticPerformance
    {
        /// <summary>
        /// У.
        /// </summary>
        [LocalizedDescription("ClimaticPerformanceY", typeof(Resources))]
        Y,

        /// <summary>
        /// ХЛ.
        /// </summary>
        [LocalizedDescription("ClimaticPerformanceHL", typeof(Resources))]
        HL,

        /// <summary>
        /// УХЛ.
        /// </summary>
        [LocalizedDescription("ClimaticPerformanceYHL", typeof(Resources))]
        YHL,

        /// <summary>
        /// Т.
        /// </summary>
        [LocalizedDescription("ClimaticPerformanceT", typeof(Resources))]
        T
    }  
}

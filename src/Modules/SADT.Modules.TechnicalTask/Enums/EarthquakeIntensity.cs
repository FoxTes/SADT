using System.ComponentModel;
using SADT.Modules.TechnicalTask.EnumExtension;
using SADT.Modules.TechnicalTask.Properties;

namespace SADT.Modules.TechnicalTask.Enums
{
    /// <summary>
    /// Интенсивность землетрясения, баллы по MSK-64.
    /// </summary>
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum EarthquakeIntensity
    {
        /// <summary>
        /// 1.
        /// </summary>
        [LocalizedDescription("EarthquakeIntensity1", typeof(Resources))]
        Intensity1,

        /// <summary>
        /// 2.
        /// </summary>
        [LocalizedDescription("EarthquakeIntensity2", typeof(Resources))]
        Intensity2,

        /// <summary>
        /// 3.
        /// </summary>
        [LocalizedDescription("EarthquakeIntensity3", typeof(Resources))]
        Intensity3,

        /// <summary>
        /// 4.
        /// </summary>
        [LocalizedDescription("EarthquakeIntensity4", typeof(Resources))]
        Intensity4,

        /// <summary>
        /// 5.
        /// </summary>
        [LocalizedDescription("EarthquakeIntensity5", typeof(Resources))]
        Intensity5,

        /// <summary>
        /// 6.
        /// </summary>
        [LocalizedDescription("EarthquakeIntensity6", typeof(Resources))]
        Intensity6,

        /// <summary>
        /// 7.
        /// </summary>
        [LocalizedDescription("EarthquakeIntensity7", typeof(Resources))]
        Intensity7,

        /// <summary>
        /// 8.
        /// </summary>
        [LocalizedDescription("EarthquakeIntensity8", typeof(Resources))]
        Intensity8,

        /// <summary>
        /// 9.
        /// </summary>
        [LocalizedDescription("EarthquakeIntensity9", typeof(Resources))]
        Intensity9
    }
}

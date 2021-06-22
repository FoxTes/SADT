using System.ComponentModel;
using SADT.Modules.TechnicalTask.EnumExtension;
using SADT.Modules.TechnicalTask.Properties;

namespace SADT.Modules.TechnicalTask.Enums
{
    /// <summary>
    /// Класс напряжения, В.
    /// </summary>
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum VoltageClass
    {
        /// <summary>
        /// 1000.
        /// </summary>
        [LocalizedDescription("VoltageClass1000", typeof(Resources))]
        Class1000,

        /// <summary>
        /// 3000.
        /// </summary>
        [LocalizedDescription("VoltageClass3000", typeof(Resources))]
        Class3000,

        /// <summary>
        /// 6000.
        /// </summary>
        [LocalizedDescription("VoltageClass6000", typeof(Resources))]
        Class6000,

        /// <summary>
        /// 10000.
        /// </summary>
        [LocalizedDescription("VoltageClass10000", typeof(Resources))]
        Class10000,

        /// <summary>
        /// 15000.
        /// </summary>
        [LocalizedDescription("VoltageClass15000", typeof(Resources))]
        Class15000,

        /// <summary>
        /// 20000.
        /// </summary>
        [LocalizedDescription("VoltageClass20000", typeof(Resources))]
        Class20000,

        /// <summary>
        /// 24000.
        /// </summary>
        [LocalizedDescription("VoltageClass24000", typeof(Resources))]
        Class24000,

        /// <summary>
        /// 27000.
        /// </summary>
        [LocalizedDescription("VoltageClass27000", typeof(Resources))]
        Class27000,

        /// <summary>
        /// 35000.
        /// </summary>
        [LocalizedDescription("VoltageClass35000", typeof(Resources))]
        Class35000,

    }
}

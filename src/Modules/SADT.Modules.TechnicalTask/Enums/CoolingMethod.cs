using System.ComponentModel;
using SADT.Modules.TechnicalTask.EnumExtension;
using SADT.Modules.TechnicalTask.Properties;

namespace SADT.Modules.TechnicalTask.Enums
{
    /// <summary>
    /// Способ охлаждения трансформатора.
    /// </summary>
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum CoolingMethod
    {
        /// <summary>
        /// М.
        /// </summary>
        [LocalizedDescription("CoolingMethodM", typeof(Resources))]
        M,

        /// <summary>
        /// Д.
        /// </summary>
        [LocalizedDescription("CoolingMethodD", typeof(Resources))]
        D,

        /// <summary>
        /// МЦ.
        /// </summary>
        [LocalizedDescription("CoolingMethodMC", typeof(Resources))]
        MC,

        /// <summary>
        /// НМЦ.
        /// </summary>
        [LocalizedDescription("CoolingMethodNMC", typeof(Resources))]
        NMC,

        /// <summary>
        /// ДЦ.
        /// </summary>
        [LocalizedDescription("CoolingMethodDC", typeof(Resources))]
        DC,

        /// <summary>
        /// НДЦ.
        /// </summary>
        [LocalizedDescription("CoolingMethodNDC", typeof(Resources))]
        NDC,

        /// <summary>
        /// Ц.
        /// </summary>
        [LocalizedDescription("CoolingMethodC", typeof(Resources))]
        C,

        /// <summary>
        /// НЦ.
        /// </summary>
        [LocalizedDescription("CoolingMethodNC", typeof(Resources))]
        NC
    }  
}

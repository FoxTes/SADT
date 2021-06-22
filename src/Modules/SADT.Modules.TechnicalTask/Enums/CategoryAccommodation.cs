using System.ComponentModel;
using SADT.Modules.TechnicalTask.EnumExtension;
using SADT.Modules.TechnicalTask.Properties;

namespace SADT.Modules.TechnicalTask.Enums
{
    /// <summary>
    /// Категория размещения.
    /// </summary>
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum CategoryAccommodation
    {
        /// <summary>
        /// 1.
        /// </summary>
        [LocalizedDescription("CategoryAccommodation1", typeof(Resources))]
        Type1,

        /// <summary>
        /// 1.1.
        /// </summary>
        [LocalizedDescription("CategoryAccommodation11", typeof(Resources))]
        Type11,

        /// <summary>
        /// 2.
        /// </summary>
        [LocalizedDescription("CategoryAccommodation2", typeof(Resources))]
        Type2,

        /// <summary>
        /// 2.1.
        /// </summary>
        [LocalizedDescription("CategoryAccommodation21", typeof(Resources))]
        Type21,

        /// <summary>
        /// 3.
        /// </summary>
        [LocalizedDescription("CategoryAccommodation3", typeof(Resources))]
        Type3,

        /// <summary>
        /// 3.1.
        /// </summary>
        [LocalizedDescription("CategoryAccommodation31", typeof(Resources))]
        Type31,

        /// <summary>
        /// 4.
        /// </summary>
        [LocalizedDescription("CategoryAccommodation4", typeof(Resources))]
        Type4,

        /// <summary>
        /// 4.1.
        /// </summary>
        [LocalizedDescription("CategoryAccommodation41", typeof(Resources))]
        Type41,

        /// <summary>
        /// 4.2.
        /// </summary>
        [LocalizedDescription("CategoryAccommodation42", typeof(Resources))]
        Type42,

        /// <summary>
        /// 5.
        /// </summary>
        [LocalizedDescription("CategoryAccommodation5", typeof(Resources))]
        Type5,

        /// <summary>
        /// 5.1.
        /// </summary>
        [LocalizedDescription("CategoryAccommodation51", typeof(Resources))]
        Type51
    }  
}

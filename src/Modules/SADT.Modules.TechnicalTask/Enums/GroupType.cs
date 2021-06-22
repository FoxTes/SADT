using System.ComponentModel;
using SADT.Modules.TechnicalTask.EnumExtension;
using SADT.Modules.TechnicalTask.Properties;

namespace SADT.Modules.TechnicalTask.Enums
{
    /// <summary>
    /// Группа соединения.
    /// </summary>
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum GroupType
    {
        /// <summary>
        /// 0.
        /// </summary>
        [LocalizedDescription("GroupType0", typeof(Resources))]
        Type0,

        /// <summary>
        /// 1.
        /// </summary>
        [LocalizedDescription("GroupType1", typeof(Resources))]
        Type1,

        /// <summary>
        /// 2.
        /// </summary>
        [LocalizedDescription("GroupType2", typeof(Resources))]
        Type2,

        /// <summary>
        /// 3.
        /// </summary>
        [LocalizedDescription("GroupType3", typeof(Resources))]
        Type3,

        /// <summary>
        /// 4.
        /// </summary>
        [LocalizedDescription("GroupType4", typeof(Resources))]
        Type4,

        /// <summary>
        /// 5.
        /// </summary>
        [LocalizedDescription("GroupType5", typeof(Resources))]
        Type5,

        /// <summary>
        /// 6.
        /// </summary>
        [LocalizedDescription("GroupType6", typeof(Resources))]
        Type6,

        /// <summary>
        /// 7.
        /// </summary>
        [LocalizedDescription("GroupType7", typeof(Resources))]
        Type7,

        /// <summary>
        /// 8.
        /// </summary>
        [LocalizedDescription("GroupType8", typeof(Resources))]
        Type8,

        /// <summary>
        /// 9.
        /// </summary>
        [LocalizedDescription("GroupType9", typeof(Resources))]
        Type9,

        /// <summary>
        /// 10.
        /// </summary>
        [LocalizedDescription("GroupType10", typeof(Resources))]
        Type10,

        /// <summary>
        /// 11.
        /// </summary>
        [LocalizedDescription("GroupType11", typeof(Resources))]
        Type11
    }  
}

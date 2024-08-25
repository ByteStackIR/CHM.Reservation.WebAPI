using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Enum
{
    public enum RelationType : sbyte
    {

        [Description("تحت تکفل")]
        DEPENDENTS = -1,



        /// <summary>
        /// خود
        /// </summary>
        [Description("خود")]
        SELF = 0,

        /// <summary>
        /// همسر
        /// </summary>
        [Description("همسر")]
        HAMSAR = 1,


        /// <summary>
        /// فرزند
        /// </summary>
        [Description("فرزند")]
        FARZAND = 2,

        /// <summary>
        /// پدر
        /// </summary>
        [Description("پدر")]
        PEDAR = 3,
        /// <summary>
        /// مادر
        /// </summary>
        [Description("مادر")]
        MADAR = 4,
        /// <summary>
        /// پدر زن
        /// </summary>
        [Description("پدر زن")]
        PEDAR2 = 5,
        /// <summary>
        /// مادر زن
        /// </summary>
        [Description("مادر زن")]
        MADAR2 = 6,





        [Description("آزاد")]
        INDEPENDENTS = -2,

        /// <summary>
        /// برادر
        /// </summary>
        [Description("برادر")]
        BARADAR = 7,
        /// <summary>
        /// خواهر
        /// </summary>
        [Description("خواهر")]
        KHAHAR = 8,

        /// <summary>
        /// عروس
        /// </summary>
        [Description("عروس")]

        AROS = 9,
        /// <summary>
        /// داماد
        /// </summary>
        [Description("داماد")]
        DAMAD = 10,

        AMO = 11,
        DAEI = 12,
        KHALEH = 13,
        AMMEH = 14,

        /// <summary>
        /// آزاد
        /// </summary>
        [Description("آزاد")]
        AZAD = 26,



    }
}

﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IIS.9
{
    using System;
    using System.Xml;
    using ICSSoft.STORMNET;
    
    
    // *** Start programmer edit section *** (Using statements)

    // *** End programmer edit section *** (Using statements)


    /// <summary>
    /// Сотрудник.
    /// </summary>
    // *** Start programmer edit section *** (Сотрудник CustomAttributes)

    // *** End programmer edit section *** (Сотрудник CustomAttributes)
    [AutoAltered()]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("СотрудникE", new string[] {
            "ТабНом as \'ТабНомер\'",
            "Имя as \'Имя\'",
            "Фамил as \'Фамилия\'",
            "Отчест as \'Отчество\'",
            "НомПасп as \'НомерПасп\'",
            "Серия as \'СерияПасп\'",
            "Должности as \'Должность\'"})]
    [View("СотрудникL", new string[] {
            "ТабНом as \'ТабНомер\'",
            "Имя as \'Имя \'",
            "Фамил as \'Фамилия\'",
            "Серия as \'СерияПаспорта\'",
            "Отчест as \'Отчество\'",
            "НомПасп as \'НомерПас\'",
            "Должности as \'Должность\'"})]
    public class Сотрудник : ICSSoft.STORMNET.DataObject
    {
        
        private string fФамил;
        
        private string fТабНом;
        
        private int fНомПасп;
        
        private string fИмя;
        
        private string fОтчест;
        
        private int fСерия;
        
        private IIS.9.Должности fДолжности;
        
        // *** Start programmer edit section *** (Сотрудник CustomMembers)

        // *** End programmer edit section *** (Сотрудник CustomMembers)

        
        /// <summary>
        /// Имя.
        /// </summary>
        // *** Start programmer edit section *** (Сотрудник.Имя CustomAttributes)

        // *** End programmer edit section *** (Сотрудник.Имя CustomAttributes)
        [StrLen(255)]
        public virtual string Имя
        {
            get
            {
                // *** Start programmer edit section *** (Сотрудник.Имя Get start)

                // *** End programmer edit section *** (Сотрудник.Имя Get start)
                string result = this.fИмя;
                // *** Start programmer edit section *** (Сотрудник.Имя Get end)

                // *** End programmer edit section *** (Сотрудник.Имя Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Сотрудник.Имя Set start)

                // *** End programmer edit section *** (Сотрудник.Имя Set start)
                this.fИмя = value;
                // *** Start programmer edit section *** (Сотрудник.Имя Set end)

                // *** End programmer edit section *** (Сотрудник.Имя Set end)
            }
        }
        
        /// <summary>
        /// НомПасп.
        /// </summary>
        // *** Start programmer edit section *** (Сотрудник.НомПасп CustomAttributes)

        // *** End programmer edit section *** (Сотрудник.НомПасп CustomAttributes)
        public virtual int НомПасп
        {
            get
            {
                // *** Start programmer edit section *** (Сотрудник.НомПасп Get start)

                // *** End programmer edit section *** (Сотрудник.НомПасп Get start)
                int result = this.fНомПасп;
                // *** Start programmer edit section *** (Сотрудник.НомПасп Get end)

                // *** End programmer edit section *** (Сотрудник.НомПасп Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Сотрудник.НомПасп Set start)

                // *** End programmer edit section *** (Сотрудник.НомПасп Set start)
                this.fНомПасп = value;
                // *** Start programmer edit section *** (Сотрудник.НомПасп Set end)

                // *** End programmer edit section *** (Сотрудник.НомПасп Set end)
            }
        }
        
        /// <summary>
        /// Отчест.
        /// </summary>
        // *** Start programmer edit section *** (Сотрудник.Отчест CustomAttributes)

        // *** End programmer edit section *** (Сотрудник.Отчест CustomAttributes)
        [StrLen(255)]
        public virtual string Отчест
        {
            get
            {
                // *** Start programmer edit section *** (Сотрудник.Отчест Get start)

                // *** End programmer edit section *** (Сотрудник.Отчест Get start)
                string result = this.fОтчест;
                // *** Start programmer edit section *** (Сотрудник.Отчест Get end)

                // *** End programmer edit section *** (Сотрудник.Отчест Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Сотрудник.Отчест Set start)

                // *** End programmer edit section *** (Сотрудник.Отчест Set start)
                this.fОтчест = value;
                // *** Start programmer edit section *** (Сотрудник.Отчест Set end)

                // *** End programmer edit section *** (Сотрудник.Отчест Set end)
            }
        }
        
        /// <summary>
        /// Серия.
        /// </summary>
        // *** Start programmer edit section *** (Сотрудник.Серия CustomAttributes)

        // *** End programmer edit section *** (Сотрудник.Серия CustomAttributes)
        public virtual int Серия
        {
            get
            {
                // *** Start programmer edit section *** (Сотрудник.Серия Get start)

                // *** End programmer edit section *** (Сотрудник.Серия Get start)
                int result = this.fСерия;
                // *** Start programmer edit section *** (Сотрудник.Серия Get end)

                // *** End programmer edit section *** (Сотрудник.Серия Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Сотрудник.Серия Set start)

                // *** End programmer edit section *** (Сотрудник.Серия Set start)
                this.fСерия = value;
                // *** Start programmer edit section *** (Сотрудник.Серия Set end)

                // *** End programmer edit section *** (Сотрудник.Серия Set end)
            }
        }
        
        /// <summary>
        /// ТабНом.
        /// </summary>
        // *** Start programmer edit section *** (Сотрудник.ТабНом CustomAttributes)

        // *** End programmer edit section *** (Сотрудник.ТабНом CustomAttributes)
        [StrLen(255)]
        public virtual string ТабНом
        {
            get
            {
                // *** Start programmer edit section *** (Сотрудник.ТабНом Get start)

                // *** End programmer edit section *** (Сотрудник.ТабНом Get start)
                string result = this.fТабНом;
                // *** Start programmer edit section *** (Сотрудник.ТабНом Get end)

                // *** End programmer edit section *** (Сотрудник.ТабНом Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Сотрудник.ТабНом Set start)

                // *** End programmer edit section *** (Сотрудник.ТабНом Set start)
                this.fТабНом = value;
                // *** Start programmer edit section *** (Сотрудник.ТабНом Set end)

                // *** End programmer edit section *** (Сотрудник.ТабНом Set end)
            }
        }
        
        /// <summary>
        /// Фамил.
        /// </summary>
        // *** Start programmer edit section *** (Сотрудник.Фамил CustomAttributes)

        // *** End programmer edit section *** (Сотрудник.Фамил CustomAttributes)
        [StrLen(255)]
        public virtual string Фамил
        {
            get
            {
                // *** Start programmer edit section *** (Сотрудник.Фамил Get start)

                // *** End programmer edit section *** (Сотрудник.Фамил Get start)
                string result = this.fФамил;
                // *** Start programmer edit section *** (Сотрудник.Фамил Get end)

                // *** End programmer edit section *** (Сотрудник.Фамил Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Сотрудник.Фамил Set start)

                // *** End programmer edit section *** (Сотрудник.Фамил Set start)
                this.fФамил = value;
                // *** Start programmer edit section *** (Сотрудник.Фамил Set end)

                // *** End programmer edit section *** (Сотрудник.Фамил Set end)
            }
        }
        
        /// <summary>
        /// Сотрудник.
        /// </summary>
        // *** Start programmer edit section *** (Сотрудник.Должности CustomAttributes)

        // *** End programmer edit section *** (Сотрудник.Должности CustomAttributes)
        [PropertyStorage(new string[] {
                "Должности"})]
        [NotNull()]
        public virtual IIS.9.Должности Должности
        {
            get
            {
                // *** Start programmer edit section *** (Сотрудник.Должности Get start)

                // *** End programmer edit section *** (Сотрудник.Должности Get start)
                IIS.9.Должности result = this.fДолжности;
                // *** Start programmer edit section *** (Сотрудник.Должности Get end)

                // *** End programmer edit section *** (Сотрудник.Должности Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Сотрудник.Должности Set start)

                // *** End programmer edit section *** (Сотрудник.Должности Set start)
                this.fДолжности = value;
                // *** Start programmer edit section *** (Сотрудник.Должности Set end)

                // *** End programmer edit section *** (Сотрудник.Должности Set end)
            }
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "СотрудникE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View СотрудникE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("СотрудникE", typeof(IIS.9.Сотрудник));
                }
            }
            
            /// <summary>
            /// "СотрудникL" view.
            /// </summary>
            public static ICSSoft.STORMNET.View СотрудникL
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("СотрудникL", typeof(IIS.9.Сотрудник));
                }
            }
        }
    }
}

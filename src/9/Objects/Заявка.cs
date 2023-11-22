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
    /// Заявка на работы.
    /// </summary>
    // *** Start programmer edit section *** (Заявка CustomAttributes)

    // *** End programmer edit section *** (Заявка CustomAttributes)
    [AutoAltered()]
    [Caption("Заявка на работы")]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("ЗаявкаE", new string[] {
            "НомЗаяв as \'Номер заяв\'",
            "Важност as \'Важность\'",
            "Состоян as \'Состояние\'",
            "Контрагент as \'Контрагент\'",
            "Сотрудник as \'Сотрудник\'",
            "Текст as \'Текст\'"})]
    [View("ЗаявкаL", new string[] {
            "НомЗаяв as \'Номер заявки\'",
            "Важност as \'Важность\'",
            "Состоян as \'Состояние\'",
            "Контрагент as \'Контрагент\'",
            "Сотрудник as \'Сотрудник\'",
            "Текст as \'Текст\'"})]
    [View("ЗаявкаНаРаботыE", new string[] {
            "Текст as \'Текст\'",
            "Важност",
            "НомЗаяв",
            "Состоян",
            "Контрагент",
            "Сотрудник"})]
    [View("ЗаявкаНаРаботыL", new string[] {
            "НомЗаяв",
            "Состоян",
            "Важност",
            "Текст as \'Текст\'",
            "Контрагент",
            "Сотрудник"})]
    public class Заявка : ICSSoft.STORMNET.DataObject
    {
        
        private string fТекст;
        
        private string fСостоян;
        
        private string fВажност;
        
        private string fНомЗаяв;
        
        private IIS.9.Контрагент fКонтрагент;
        
        private IIS.9.Сотрудник fСотрудник;
        
        // *** Start programmer edit section *** (Заявка CustomMembers)

        // *** End programmer edit section *** (Заявка CustomMembers)

        
        /// <summary>
        /// Важност.
        /// </summary>
        // *** Start programmer edit section *** (Заявка.Важност CustomAttributes)

        // *** End programmer edit section *** (Заявка.Важност CustomAttributes)
        [StrLen(255)]
        public virtual string Важност
        {
            get
            {
                // *** Start programmer edit section *** (Заявка.Важност Get start)

                // *** End programmer edit section *** (Заявка.Важност Get start)
                string result = this.fВажност;
                // *** Start programmer edit section *** (Заявка.Важност Get end)

                // *** End programmer edit section *** (Заявка.Важност Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Заявка.Важност Set start)

                // *** End programmer edit section *** (Заявка.Важност Set start)
                this.fВажност = value;
                // *** Start programmer edit section *** (Заявка.Важност Set end)

                // *** End programmer edit section *** (Заявка.Важност Set end)
            }
        }
        
        /// <summary>
        /// НомЗаяв.
        /// </summary>
        // *** Start programmer edit section *** (Заявка.НомЗаяв CustomAttributes)

        // *** End programmer edit section *** (Заявка.НомЗаяв CustomAttributes)
        [StrLen(255)]
        public virtual string НомЗаяв
        {
            get
            {
                // *** Start programmer edit section *** (Заявка.НомЗаяв Get start)

                // *** End programmer edit section *** (Заявка.НомЗаяв Get start)
                string result = this.fНомЗаяв;
                // *** Start programmer edit section *** (Заявка.НомЗаяв Get end)

                // *** End programmer edit section *** (Заявка.НомЗаяв Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Заявка.НомЗаяв Set start)

                // *** End programmer edit section *** (Заявка.НомЗаяв Set start)
                this.fНомЗаяв = value;
                // *** Start programmer edit section *** (Заявка.НомЗаяв Set end)

                // *** End programmer edit section *** (Заявка.НомЗаяв Set end)
            }
        }
        
        /// <summary>
        /// Состоян.
        /// </summary>
        // *** Start programmer edit section *** (Заявка.Состоян CustomAttributes)

        // *** End programmer edit section *** (Заявка.Состоян CustomAttributes)
        [StrLen(255)]
        public virtual string Состоян
        {
            get
            {
                // *** Start programmer edit section *** (Заявка.Состоян Get start)

                // *** End programmer edit section *** (Заявка.Состоян Get start)
                string result = this.fСостоян;
                // *** Start programmer edit section *** (Заявка.Состоян Get end)

                // *** End programmer edit section *** (Заявка.Состоян Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Заявка.Состоян Set start)

                // *** End programmer edit section *** (Заявка.Состоян Set start)
                this.fСостоян = value;
                // *** Start programmer edit section *** (Заявка.Состоян Set end)

                // *** End programmer edit section *** (Заявка.Состоян Set end)
            }
        }
        
        /// <summary>
        /// Текст.
        /// </summary>
        // *** Start programmer edit section *** (Заявка.Текст CustomAttributes)

        // *** End programmer edit section *** (Заявка.Текст CustomAttributes)
        [StrLen(255)]
        public virtual string Текст
        {
            get
            {
                // *** Start programmer edit section *** (Заявка.Текст Get start)

                // *** End programmer edit section *** (Заявка.Текст Get start)
                string result = this.fТекст;
                // *** Start programmer edit section *** (Заявка.Текст Get end)

                // *** End programmer edit section *** (Заявка.Текст Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Заявка.Текст Set start)

                // *** End programmer edit section *** (Заявка.Текст Set start)
                this.fТекст = value;
                // *** Start programmer edit section *** (Заявка.Текст Set end)

                // *** End programmer edit section *** (Заявка.Текст Set end)
            }
        }
        
        /// <summary>
        /// Заявка на работы.
        /// </summary>
        // *** Start programmer edit section *** (Заявка.Контрагент CustomAttributes)

        // *** End programmer edit section *** (Заявка.Контрагент CustomAttributes)
        [PropertyStorage(new string[] {
                "Контрагент"})]
        [NotNull()]
        public virtual IIS.9.Контрагент Контрагент
        {
            get
            {
                // *** Start programmer edit section *** (Заявка.Контрагент Get start)

                // *** End programmer edit section *** (Заявка.Контрагент Get start)
                IIS.9.Контрагент result = this.fКонтрагент;
                // *** Start programmer edit section *** (Заявка.Контрагент Get end)

                // *** End programmer edit section *** (Заявка.Контрагент Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Заявка.Контрагент Set start)

                // *** End programmer edit section *** (Заявка.Контрагент Set start)
                this.fКонтрагент = value;
                // *** Start programmer edit section *** (Заявка.Контрагент Set end)

                // *** End programmer edit section *** (Заявка.Контрагент Set end)
            }
        }
        
        /// <summary>
        /// Заявка на работы.
        /// </summary>
        // *** Start programmer edit section *** (Заявка.Сотрудник CustomAttributes)

        // *** End programmer edit section *** (Заявка.Сотрудник CustomAttributes)
        [PropertyStorage(new string[] {
                "Сотрудник"})]
        [NotNull()]
        public virtual IIS.9.Сотрудник Сотрудник
        {
            get
            {
                // *** Start programmer edit section *** (Заявка.Сотрудник Get start)

                // *** End programmer edit section *** (Заявка.Сотрудник Get start)
                IIS.9.Сотрудник result = this.fСотрудник;
                // *** Start programmer edit section *** (Заявка.Сотрудник Get end)

                // *** End programmer edit section *** (Заявка.Сотрудник Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Заявка.Сотрудник Set start)

                // *** End programmer edit section *** (Заявка.Сотрудник Set start)
                this.fСотрудник = value;
                // *** Start programmer edit section *** (Заявка.Сотрудник Set end)

                // *** End programmer edit section *** (Заявка.Сотрудник Set end)
            }
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "ЗаявкаE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View ЗаявкаE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("ЗаявкаE", typeof(IIS.9.Заявка));
                }
            }
            
            /// <summary>
            /// "ЗаявкаL" view.
            /// </summary>
            public static ICSSoft.STORMNET.View ЗаявкаL
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("ЗаявкаL", typeof(IIS.9.Заявка));
                }
            }
            
            /// <summary>
            /// "ЗаявкаНаРаботыE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View ЗаявкаНаРаботыE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("ЗаявкаНаРаботыE", typeof(IIS.9.Заявка));
                }
            }
            
            /// <summary>
            /// "ЗаявкаНаРаботыL" view.
            /// </summary>
            public static ICSSoft.STORMNET.View ЗаявкаНаРаботыL
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("ЗаявкаНаРаботыL", typeof(IIS.9.Заявка));
                }
            }
        }
    }
}

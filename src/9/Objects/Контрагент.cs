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
    /// Контрагент.
    /// </summary>
    // *** Start programmer edit section *** (Контрагент CustomAttributes)

    // *** End programmer edit section *** (Контрагент CustomAttributes)
    [AutoAltered()]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("КонтрагентE", new string[] {
            "Договор as \'Договор\'"})]
    [View("КонтрагентL", new string[] {
            "Договор as \'Договор\'"})]
    public class Контрагент : ICSSoft.STORMNET.DataObject
    {
        
        private int fКонтр;
        
        private string fОрганиз;
        
        private string fНаимен;
        
        private string fДоговор;
        
        // *** Start programmer edit section *** (Контрагент CustomMembers)

        // *** End programmer edit section *** (Контрагент CustomMembers)

        
        /// <summary>
        /// Договор.
        /// </summary>
        // *** Start programmer edit section *** (Контрагент.Договор CustomAttributes)

        // *** End programmer edit section *** (Контрагент.Договор CustomAttributes)
        [StrLen(255)]
        public virtual string Договор
        {
            get
            {
                // *** Start programmer edit section *** (Контрагент.Договор Get start)

                // *** End programmer edit section *** (Контрагент.Договор Get start)
                string result = this.fДоговор;
                // *** Start programmer edit section *** (Контрагент.Договор Get end)

                // *** End programmer edit section *** (Контрагент.Договор Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Контрагент.Договор Set start)

                // *** End programmer edit section *** (Контрагент.Договор Set start)
                this.fДоговор = value;
                // *** Start programmer edit section *** (Контрагент.Договор Set end)

                // *** End programmer edit section *** (Контрагент.Договор Set end)
            }
        }
        
        /// <summary>
        /// Контр.
        /// </summary>
        // *** Start programmer edit section *** (Контрагент.Контр CustomAttributes)

        // *** End programmer edit section *** (Контрагент.Контр CustomAttributes)
        public virtual int Контр
        {
            get
            {
                // *** Start programmer edit section *** (Контрагент.Контр Get start)

                // *** End programmer edit section *** (Контрагент.Контр Get start)
                int result = this.fКонтр;
                // *** Start programmer edit section *** (Контрагент.Контр Get end)

                // *** End programmer edit section *** (Контрагент.Контр Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Контрагент.Контр Set start)

                // *** End programmer edit section *** (Контрагент.Контр Set start)
                this.fКонтр = value;
                // *** Start programmer edit section *** (Контрагент.Контр Set end)

                // *** End programmer edit section *** (Контрагент.Контр Set end)
            }
        }
        
        /// <summary>
        /// Наимен.
        /// </summary>
        // *** Start programmer edit section *** (Контрагент.Наимен CustomAttributes)

        // *** End programmer edit section *** (Контрагент.Наимен CustomAttributes)
        [StrLen(255)]
        public virtual string Наимен
        {
            get
            {
                // *** Start programmer edit section *** (Контрагент.Наимен Get start)

                // *** End programmer edit section *** (Контрагент.Наимен Get start)
                string result = this.fНаимен;
                // *** Start programmer edit section *** (Контрагент.Наимен Get end)

                // *** End programmer edit section *** (Контрагент.Наимен Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Контрагент.Наимен Set start)

                // *** End programmer edit section *** (Контрагент.Наимен Set start)
                this.fНаимен = value;
                // *** Start programmer edit section *** (Контрагент.Наимен Set end)

                // *** End programmer edit section *** (Контрагент.Наимен Set end)
            }
        }
        
        /// <summary>
        /// Организ.
        /// </summary>
        // *** Start programmer edit section *** (Контрагент.Организ CustomAttributes)

        // *** End programmer edit section *** (Контрагент.Организ CustomAttributes)
        [StrLen(255)]
        public virtual string Организ
        {
            get
            {
                // *** Start programmer edit section *** (Контрагент.Организ Get start)

                // *** End programmer edit section *** (Контрагент.Организ Get start)
                string result = this.fОрганиз;
                // *** Start programmer edit section *** (Контрагент.Организ Get end)

                // *** End programmer edit section *** (Контрагент.Организ Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Контрагент.Организ Set start)

                // *** End programmer edit section *** (Контрагент.Организ Set start)
                this.fОрганиз = value;
                // *** Start programmer edit section *** (Контрагент.Организ Set end)

                // *** End programmer edit section *** (Контрагент.Организ Set end)
            }
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "КонтрагентE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View КонтрагентE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("КонтрагентE", typeof(IIS.9.Контрагент));
                }
            }
            
            /// <summary>
            /// "КонтрагентL" view.
            /// </summary>
            public static ICSSoft.STORMNET.View КонтрагентL
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("КонтрагентL", typeof(IIS.9.Контрагент));
                }
            }
        }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApp6
{
    using System;
    using System.Collections.Generic;
    
    public partial class quiz
    {
        public int id { get; set; }
        public int userID { get; set; }
        public int paragrafTrue { get; set; }
        public int paragrafFalse { get; set; }
        public int dilbilgisiTrue { get; set; }
        public int dilbilgisiFalse { get; set; }
        public int anlatimTrue { get; set; }
        public int anlatimFalse { get; set; }
        public int siirTrue { get; set; }
        public int siirFalse { get; set; }
        public int divanTrue { get; set; }
        public int divanFalse { get; set; }
        public System.DateTime date { get; set; }
        public int quizMark { get; set; }
    
        public virtual user user { get; set; }
    }
}
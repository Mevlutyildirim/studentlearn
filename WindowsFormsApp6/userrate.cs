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
    
    public partial class userrate
    {
        public int id { get; set; }
        public int userID { get; set; }
        public int paragraf { get; set; }
        public int dilbilgisi { get; set; }
        public int anlatim { get; set; }
        public int siir { get; set; }
        public int divan { get; set; }
        public System.DateTime date { get; set; }
    
        public virtual user user { get; set; }
    }
}

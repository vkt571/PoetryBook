//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PoetryBook.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbcomment
    {
        public int commentID { get; set; }
        public string comment { get; set; }
        public int authoridsof { get; set; }
        public int poetryidsof { get; set; }
    
        public virtual tbmember tbmember { get; set; }
        public virtual tbpoetry tbpoetry { get; set; }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MiniDataEntry
{
    using System;
    using System.Collections.Generic;
    
    public partial class TRABALHO
    {
        public int ID { get; set; }
        public System.DateTime DATACRIACAO { get; set; }
        public int ID_DOCUMENTO { get; set; }
    
        public virtual DOCUMENTO DOCUMENTO { get; set; }
    }
}

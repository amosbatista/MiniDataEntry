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
    
    public partial class INDEXACAO_CAMPOS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public INDEXACAO_CAMPOS()
        {
            this.DOCUMENTOes = new HashSet<DOCUMENTO>();
        }
    
        public int ID { get; set; }
        public int ID_CAMPO { get; set; }
        public string VALOR { get; set; }
    
        public virtual CAMPO CAMPO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DOCUMENTO> DOCUMENTOes { get; set; }
    }
}
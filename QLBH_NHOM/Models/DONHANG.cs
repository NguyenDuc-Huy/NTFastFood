//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QLBH_NHOM.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class DONHANG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DONHANG()
        {
            this.CHITIET_DONHANG = new HashSet<CHITIET_DONHANG>();
        }
    
        public string MADON { get; set; }
        public string MAKH { get; set; }
        public string MANV_DUYET { get; set; }
        public string MANV_GIAO { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public Nullable<System.DateTime> NGAYDAT { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public Nullable<System.DateTime> NGAYGIAO { get; set; }
        public string DIACHIGIAO { get; set; }
        public string TINHTRANG { get; set; }
        public Nullable<int> TIEN { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIET_DONHANG> CHITIET_DONHANG { get; set; }
        public virtual KHACHHANG KHACHHANG { get; set; }
        public virtual NHANVIEN NHANVIEN { get; set; }
        public virtual NHANVIEN NHANVIEN1 { get; set; }
        public virtual TINHTRANGDON TINHTRANGDON { get; set; }
    }
}

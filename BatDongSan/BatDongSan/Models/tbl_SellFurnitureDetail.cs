//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BatDongSan.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_SellFurnitureDetail
    {
        public int ID_SellFurnitureDetail { get; set; }
        public Nullable<int> ID_SellingRealEstate { get; set; }
        public Nullable<int> ID_CategoryOfFurniture { get; set; }
        public Nullable<int> NumberOfFurniture { get; set; }
        public string CreateBy { get; set; }
        public string UpdateBy { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public Nullable<System.DateTime> UpdateDate { get; set; }
        public Nullable<byte> Status { get; set; }
    
        public virtual tbl_CategoryOfFurniture tbl_CategoryOfFurniture { get; set; }
        public virtual tbl_SellingRealEstate tbl_SellingRealEstate { get; set; }
    }
}

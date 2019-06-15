using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace BatDongSan.Models.Metadata
{
    [MetadataType(typeof(tbl_CategoryOfFurniture.Metadata))]
    public class tbl_CategoryOfFurniture
    {
        sealed class Metadata
        {
            [Display(Name ="Mã loại")]
            public int ID_CategoryOfFurniture { get; set; }
            [Display(Name = "Tên nội thất")]
            public string Name { get; set; }
            [Display(Name = "Người tạo")]
            public string CreateBy { get; set; }
            [Display(Name = "Người cập nhật")]
            public string UpdateBy { get; set; }
            [Display(Name = "Ngày tạo")]
            public Nullable<System.DateTime> CreateDate { get; set; }
            [Display(Name = "Người cập nhật")]
            public Nullable<System.DateTime> UpdateDate { get; set; }
            [Display(Name = "Trạng thái")]
            public Nullable<byte> Status { get; set; }
        }
    }
}
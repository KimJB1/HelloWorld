using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace BatDongSan.Models
{
    [MetadataType(typeof(tbl_Ward.Metadata))]
    public partial class tbl_Ward
    {
        sealed class Metadata
        {
            [Display(Name ="Mã xã/phường")]
            public int ID_Ward { get; set; }
            [Display(Name ="Tên xã/phường")]
            public string Ward_Name { get; set; }
            [Display(Name ="Mã quận/huyện")]
            public Nullable<int> ID_District { get; set; }
            [Display(Name ="Người tạo")]
            public string CreateBy { get; set; }
            [Display(Name ="Người cập nhật")]
            public string UpdateBy { get; set; }
            [Display(Name ="Ngày tạo")]
            [DisplayFormat(DataFormatString ="{0:dd/MM/yyyy hh:mm tt}")]
            public Nullable<System.DateTime> CreateDate { get; set; }
            [Display(Name ="Ngày cập nhật")]
            [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy hh:mm tt}")]
            public Nullable<System.DateTime> UpdateDate { get; set; }
            [Display(Name ="Trạng thái")]
            public Nullable<int> Status { get; set; }
        }
    }
}
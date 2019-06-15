using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace BatDongSan.Models
{
    [MetadataType(typeof(tbl_Account.Metadata))]
    public partial class tbl_Account
    {
        sealed class Metadata
        {
            [Display(Name ="Mã tài khoản")]
            public int ID_Account { get; set; }
            [Display(Name ="Họ và tên")]
            public string Account_Name { get; set; }
            [Display(Name ="Giới tính")]
            public Nullable<int> Sex { get; set; }
            [Display(Name ="Ngày sinh")]
            [DisplayFormat(DataFormatString ="{0:dd/MM/yyyy}",ApplyFormatInEditMode =true)]
            [DataType(DataType.Date)]
            public Nullable<System.DateTime> Birthday { get; set; }
            [Display(Name ="Địa chỉ")]
            public string Address { get; set; }
            public string Email { get; set; }
            [Display(Name = "Điện thoại")]
            public string Phone { get; set; }
            [Display(Name ="Chức vụ")]
            public Nullable<int> ID_Position { get; set; }
            [Display(Name ="Tài khoản")]
            public string Account { get; set; }
            [Display(Name ="Mật khẩu")]
            public string Pass { get; set; }
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
            [Display(Name ="Ảnh đại diện")]
            public string Avarta { get; set; }
        }
    }
}
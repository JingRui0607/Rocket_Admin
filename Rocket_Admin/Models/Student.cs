namespace Rocket_Admin.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using static Rocket_Admin.Models.EnumList;

    [Table("Student")]
    public partial class Student
    {
        public int id { get; set; }
        [Display(Name = "姓名")]
        public string name { get; set; }
        [Display(Name = "頭貼")]
        public string image { get; set; }


        [Display(Name = "類別1")]
        public int? CId { get; set; } //? 允許空直

        [ForeignKey("CId")]
        public virtual Class Class { get; set; }



        //[Display(Name = "梯次")]
        //[Column("class")]
        //public int? _class { get; set; }

        //[Display(Name = "初始日期")]
        //public DateTime? startDate { get; set; }
        //[Display(Name = "結束日期")]
        //public DateTime? endDate { get; set; }

        [Display(Name = "原本職業")]
        public string exOccupation { get; set; }
        [Display(Name = "目標職業")]
        public string futureOccupation { get; set; }

        public DateTime? initDate { get; set; }
        [Display(Name = "第一次寫" +
                        "ORID的星期一")]
        public DateTime? firstMon { get; set; }
        [Display(Name = "狀態")]
        public presenceType presence { get; set; }
    }
}

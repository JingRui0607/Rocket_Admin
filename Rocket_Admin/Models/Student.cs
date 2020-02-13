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
        [Display(Name = "�m�W")]
        public string name { get; set; }
        [Display(Name = "�Y�K")]
        public string image { get; set; }


        [Display(Name = "���O1")]
        public int? CId { get; set; } //? ���\�Ū�

        [ForeignKey("CId")]
        public virtual Class Class { get; set; }



        //[Display(Name = "�覸")]
        //[Column("class")]
        //public int? _class { get; set; }

        //[Display(Name = "��l���")]
        //public DateTime? startDate { get; set; }
        //[Display(Name = "�������")]
        //public DateTime? endDate { get; set; }

        [Display(Name = "�쥻¾�~")]
        public string exOccupation { get; set; }
        [Display(Name = "�ؼ�¾�~")]
        public string futureOccupation { get; set; }

        public DateTime? initDate { get; set; }
        [Display(Name = "�Ĥ@���g" +
                        "ORID���P���@")]
        public DateTime? firstMon { get; set; }
        [Display(Name = "���A")]
        public presenceType presence { get; set; }
    }
}

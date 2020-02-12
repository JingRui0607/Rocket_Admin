using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Rocket_Admin.Models
{
    public class User
    {

        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int Id { get; set; }




        [Required(ErrorMessage = "{0}必填")]//{0}是Display(Name = "帳號"
        [MaxLength(50)]
        [Display(Name = "帳號")]
        public string Account { get; set; }




        [Required(ErrorMessage = "{0}必填")]
        [DataType(DataType.Password)]
        [StringLength(100, ErrorMessage = "{0} 長度至少必須為 {2} 個字元。", MinimumLength = 4)]
        [Display(Name = "密碼")]
        public string Password { get; set; }


        [MaxLength(100)]
        [Display(Name = "密碼鹽")]
        public string PasswordSalt { get; set; }


        [Display(Name = "建立日期")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        //[DisplayFormat(ApplyFormatInEditMode = true,DataFormatString = "{0:yyyy年MM月dd日}")]
        public DateTime? InitDate { get; set; }


    }
}
namespace Rocket_Admin.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Class")]
    public partial class Class
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Session { get; set; }
        [Display(Name = "��l���")]
        public DateTime startDate { get; set; }
        [Display(Name = "���V���")]
        public DateTime? endDate { get; set; }
    }
}

namespace Rocket_Admin.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("week")]
    public partial class week
    {
        [Key]
        [Column("week")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int week1 { get; set; }
    }
}

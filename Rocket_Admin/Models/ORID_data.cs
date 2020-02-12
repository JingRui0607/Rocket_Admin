namespace Rocket_Admin.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ORID_data
    {
        public int id { get; set; }

        public DateTime? 填寫時間 { get; set; }

        [StringLength(50)]
        public string 姓名 { get; set; }

        public string 週一目標 { get; set; }

        public string 目標完成度 { get; set; }

        public string 心情 { get; set; }

        public string 學習歷程描述 { get; set; }

        public string 高峰低峰 { get; set; }

        public string 每日獲得 { get; set; }

        public string 明日行動 { get; set; }

        public string 週五填寫 { get; set; }

        public DateTime? initdate { get; set; }

        public int? Sid { get; set; }
    }
}

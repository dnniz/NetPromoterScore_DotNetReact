using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace NetPromoterScore.Entity
{
    [Table("Score")]
    public class Score : BaseEntity
    {
        [Key]
        public int ScoreId { get; set; }
        [ForeignKey("UserId")]
        public User User { get; set; }

        [ForeignKey("CompanyId")]
        public Company Company { get; set; }
        public int CompanyId { get; set; }
        public int UserId { get; set; }
        public int SelectedScore { get; set; }
    }
}

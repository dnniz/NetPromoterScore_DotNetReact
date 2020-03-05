using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace NetPromoterScore.Entity
{
    [Table("Company")]
    public class Company : BaseEntity
    {
        [Key]
        public int CompanyId { get; set; }
        public string Name { get; set; }
        public List<Score> ListScore { get; set; }
    }
}

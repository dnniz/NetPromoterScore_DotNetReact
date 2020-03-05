using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace NetPromoterScore.Entity
{
    [Table("UserProfile")]
    public class UserProfile : BaseEntity
    {
        [Key]
        public int UserProfileId { get; set; }
        public string Description { get; set; }
    }
}

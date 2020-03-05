using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace NetPromoterScore.Entity
{
    [Table("UserType")]
    public class UserType : BaseEntity
    {
        [Key]
        public int UserTypeId { get; set; }

        public string Description { get; set; }
    }
}

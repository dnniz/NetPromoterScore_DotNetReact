using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace NetPromoterScore.Entity
{
    [Table("User")]
    public class User: BaseEntity
    {
        [Key]
        public int UserId { get; set; }
        public UserProfile UserProfile { get; set; }
        public int UserProfileId { get; set; }

        [ForeignKey("UserTypeId")]
        public UserType UserType { get; set; }
        public int? UserTypeId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool SurveyCarriedOut { get; set; }
    }
}

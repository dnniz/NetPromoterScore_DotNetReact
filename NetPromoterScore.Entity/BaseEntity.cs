using System;
using System.ComponentModel.DataAnnotations;

namespace NetPromoterScore.Entity
{
    public class BaseEntity
    {
        public bool FlagActive { get; set; }
        public bool FlagDeleted { get; set; }
        [MaxLength(120)]
        public string CreatedBy { get; set; }
        public DateTime? CreationDate { get; set; }
        [MaxLength(120)]
        public string ModifiedBy { get; set; }
        public DateTime? ModificationDate { get; set; }

        public BaseEntity() => (FlagActive, FlagDeleted, CreationDate) = (true, false, DateTime.Now);

    }
}

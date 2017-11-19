using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Memberships.Entities
{

    [Table("UserSubscription")]
    public class UserSubscription
    {
        // Composite key: Subscription and AspNetUser tables
        [Required]
        [Key, Column(Order =1)]
        public int SubscriptionId { get; set; }

        [Key, Column(Order = 2)]
        [Required]
        [MaxLength(128)]
        public string UserId { get; set; }

        public DateTime? StartDate { get; set; }
                
        public DateTime? EndDate { get; set; }
    }
}
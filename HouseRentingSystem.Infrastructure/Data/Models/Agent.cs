using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static HouseRentingSystem.Infrastructure.Constants.DataConstants;

namespace HouseRentingSystem.Infrastructure.Data.Models
{
    [Comment("House agent")]
    public class Agent
    {
        [Key]
        [Comment("Agent identifier")]
        public int Id { get; set; }

        [Required]
        [MaxLength(AgentPhoneNumberMaxLength)]
        [Comment("Agent's phone number")]
        public string PhoneNumber { get; set; } = string.Empty;

        [Required]
        [ForeignKey(nameof(User))]
        [Comment("User identifier")]
        public virtual string UserId { get; set; } = string.Empty;

        public virtual IdentityUser User { get; set; } = null!;
    }
}

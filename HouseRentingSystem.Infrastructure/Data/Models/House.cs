using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static HouseRentingSystem.Infrastructure.Constants.DataConstants;

namespace HouseRentingSystem.Infrastructure.Data.Models
{
    [Comment("House to rent")]
    public class House
    {
        [Key]
        [Comment("House identifier")]
        public int Id { get; set; }

        [Required]
        [MaxLength(HouseTitleMaxLength)]
        [Comment("House title")]
        public string Title { get; set; } = string.Empty;

        [Required]
        [MaxLength(HouseAddressMaxLength)]
        [Comment("House address")]
        public string Address { get; set; } = string.Empty;

        [Required]
        [MaxLength(HouseDescriptionMaxLength)]
        [Comment("House description")]
        public string Description { get; set; } = string.Empty;

        [Required]
        [Comment("House image URL")]
        public string ImageUrl { get; set; } = string.Empty;

        [Required]
        //[Range(typeof(decimal), HousePricePerMonthMin, HousePricePerMonthMax, ConvertValueInInvariantCulture = true)]  - this is not needed for DB
        [Comment("House price per month")]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal PricePerMonth { get; set; }

        [Required]
        [Comment("Category identifier")]
        [ForeignKey(nameof(Category))] 
        public virtual int CategoryId { get; set; }

        public virtual Category Category { get; set; } = null!;

        [Required]
        [Comment("Agent identifier")]
        [ForeignKey(nameof(Agent))]
        public virtual int AgentId { get; set; }

        public virtual Agent Agent { get; set; } = null!;

        [Comment("User Id of the renterer")]
        public string RenterId { get; set; } = string.Empty;
    }
}

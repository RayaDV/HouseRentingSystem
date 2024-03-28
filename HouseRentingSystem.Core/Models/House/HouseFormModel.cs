using HouseRentingSystem.Infrastructure.Data.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static HouseRentingSystem.Infrastructure.Constants.DataConstants;
using static HouseRentingSystem.Core.Constants.MessageConstants;

namespace HouseRentingSystem.Core.Models.House
{
    public class HouseFormModel
    {
        [Required]
        [StringLength(HouseTitleMaxLength, MinimumLength = HouseTitleMinLength, ErrorMessage = LengthMessage)]
        public string Title { get; set; } = null!;

        [Required]
        [StringLength(HouseAddressMaxLength, MinimumLength = HouseAddressMinLength, ErrorMessage = LengthMessage)]
        public string Address { get; set; } = null!;

        [Required]
        [StringLength(HouseDescriptionMaxLength, MinimumLength = HouseDescriptionMinLength, ErrorMessage = LengthMessage)]
        public string Description { get; set; } = null!;

        [Required]
        [Display(Name = "Image URL")]
        public string ImageUrl { get; set; } = null!;

        [Required]
        [Range(typeof(decimal), HousePricePerMonthMin, HousePricePerMonthMax, 
            ConvertValueInInvariantCulture = true, 
            ErrorMessage = "Price per month must be a possitive number and less than {2} leva")]
        [Display(Name = "Price Per Month")]
        public decimal PricePerMonth { get; set; }

        [Required]
        [Display(Name = "Category")]
        public virtual int CategoryId { get; set; }

        public IEnumerable<HouseCategoryServiceModel> Categories { get; set; } 
            = new List<HouseCategoryServiceModel>();
    }
}

namespace HouseRentingSystem.Infrastructure.Constants
{
    public static class DataConstants
    {
        // Category
        public const int CategoryNameMaxLength = 50;

        // House
        public const int HouseTitleMaxLength = 50;
        public const int HouseTitleMinLength = 10;

        public const int HouseAddressMaxLength = 150;
        public const int HouseAddressMinLength = 30;

        public const int HouseDescriptionMaxLength = 500;
        public const int HouseDescriptionMinLength = 50;

        public const string HousePricePerMonthMax = "2000.00";
        public const string HousePricePerMonthMin = "0.00";

        // Agent 
        public const int AgentPhoneNumberMaxLength = 15;
        public const int AgentPhoneNumberMinLength = 7;
    }



}

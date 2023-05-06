namespace Application.Const.Validator
{
    public static class ValidatorMessages
    {
        public static string NotNull = "{PropertyName} is required";
        public static string GreaterThan = "{PropertyName} must be greater than {ComparisonValue}";
        public static string LessThan = "{PropertyName} must be Less than {ComparisonValue}";
        public static string NotEmpty = "{PropertyName} is required";
        public static string MaximumLength = "{PropertyName} does not exceed {ComparisonValue}";
        public static string MinimumLength = "{PropertyName} minimum lenth is  {ComparisonValue}";
        public static string MustSelected = "{PropertyName} must be selected";
        public static string NotExist = "{PropertyName} does not exist.";
        public static string Duplicate = "Duplicate {ComparisonValue}.....";
        public static string EmailFormat = "{PropertyName} must be in Email format";


    }
}

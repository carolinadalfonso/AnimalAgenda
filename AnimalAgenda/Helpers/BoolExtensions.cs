namespace AnimalAgenda.Helpers
{
    public static class BoolExtensions
    {
        public static string ToStringValue(this bool source)
        {
            return source ? "1" : "0";
        }
    }
}

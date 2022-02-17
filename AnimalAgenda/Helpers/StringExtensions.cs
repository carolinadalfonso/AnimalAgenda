namespace AnimalAgenda.Helpers
{
    public static class StringExtensions
    {
        public static bool ToBoolean(this string source)
        {
            return source == "1";
        }
    }
}

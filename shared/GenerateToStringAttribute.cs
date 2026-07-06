namespace shared
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    public class GenerateToStringAttribute : Attribute
    {
        public GenerateToStringAttribute(string format)
        {
            Format = format;
        }

        public string Format { get; }
    }
}
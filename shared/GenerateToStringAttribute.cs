namespace shared
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    public class GenerateToStringAttribute : Attribute
    {
        public GenerateToStringAttribute(string format, params string[] argNames)
        {
            Format = format;
            ArgNames = argNames;
        }

        public string Format { get; }
        public string[] ArgNames { get; }
    }
}
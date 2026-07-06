namespace shared;

[GenerateToString("{0} ({1}) e-mail: {2}")]
public partial class Person
{
    public string? Name { get; set; }
    public int? Age { get; set; }
    public string? Email { get; set; }
}
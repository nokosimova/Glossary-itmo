namespace Grossary.Models;

public class Termine
{
    public string Name { get; set; }
    public string Description { get; set; }
    public Termine(string name, string desc) {
        Name = name;
        Description = desc;
    }
}
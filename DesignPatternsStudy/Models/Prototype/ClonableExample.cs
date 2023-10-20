namespace DesignPatternsNet6.Models.Prototype;

public class CloneableExample: ICloneable
{
    public string Name { get; set; } = string.Empty;

    public object Clone()
    {
        return MemberwiseClone();
    }
}

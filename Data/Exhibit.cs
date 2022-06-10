namespace TCU_FleaMarket.Data;

public class Exhibit
{
    public int Id { get; set; }
    public int ExhibitorsId { get; set; }
    public string Name { get; set; }
    public string? Description { get; set; }
    public byte[]? Image { get; set; }
}

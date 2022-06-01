namespace TCU_FleaMarket.Data;

public class User
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Biography { get; set; }
    public byte[]? Image { get; set; }
    public byte[]? Contact { get; set; }
}
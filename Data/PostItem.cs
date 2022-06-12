using System.ComponentModel.DataAnnotations;

namespace TCU_FleaMarket.Data;

public class PostItem
{
    [Required]
    public string Name;
    public string? Description;
    [Required]
    public int Price;
    public byte[]? Image;
}

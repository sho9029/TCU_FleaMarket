using System.ComponentModel.DataAnnotations;

namespace TCU_FleaMarket.Data;

public class PostItem
{
    [Required]
    public string? Name;
    public string? Description;
    public byte[]? Image;
}

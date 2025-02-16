namespace API.Entities;

public class Product
{   
    public int Id { get; set; }
    public required string Name { get; set; }
    public required string Discription { get; set; }
    public long Price { get; set; }
    public required string PictureUrl { get; set; }
    public required string Type { get; set; }
    public required string Brand { get; set; }
    public int QuantityStock { get; set; }
}

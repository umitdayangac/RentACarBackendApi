namespace Entities.Concrete;

public class Car
{
    public int Id { get; set; }
    public int Brand { get; set; }
    public int Color { get; set; }
    public int ModelYear { get; set; }
    public decimal DailyPrice { get; set; }
    public string? Description { get; set; }
}
using SQLite;
namespace SQLCarPage.MVVM.Models;


    public class Car
{
    [PrimaryKey, AutoIncrement]
    public int ID { get; set; }
    public string Model { get; set; }
    public string Color { get; set; }
}

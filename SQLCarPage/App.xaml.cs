using SQLCarPage.Repository;
using SQLCarPage.View;
using Microsoft.Maui.Controls;

namespace SQLCarPage
{
    public partial class App : Application
    {
        public static CarRepository _carRepo { get; private set; }

        public App()
        {
            InitializeComponent(); // เตรียมความพร้อมให้กับ UI
            _carRepo = new CarRepository(); // สร้าง instance ของ CarRepository

            // ตั้งค่า MainPage เป็น CarPage โดยตรง
            MainPage = new CarPage(); // เปลี่ยนเป็น CarPage แทน NavigationPage
        }
    }
}
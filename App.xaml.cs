namespace Proyecto_Programacion2
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new TodoListPage())
            {
                BarTextColor = Color.FromRgb(255, 255, 255),
                BarBackgroundColor = Color.FromRgb(12, 143, 208)

            };
        }
    }
}

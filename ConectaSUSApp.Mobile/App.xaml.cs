using ConectaSUSApp.Mobile.Pages;

namespace ConectaSUSApp.Mobile
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Login();
        }
    }
}
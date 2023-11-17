namespace Net8Test
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            
            // This line of code never returns - it hangs forever
            var password = SecureStorage.GetAsync("password").Result;

            MainPage = new AppShell();
        }
    }
}

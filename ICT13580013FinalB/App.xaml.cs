using ICT13580013FinalB.Helper;
using Xamarin.Forms;

namespace ICT13580013FinalB
{
    public partial class App : Application
    {

		public static DbHelpers DbHelpers
		{
			get;
			set;
		}
		public App()
		{
			InitializeComponent();

		}
        public App(string dbPath)
        {
            InitializeComponent();

			DbHelpers = new DbHelpers(dbPath);

			MainPage = new NavigationPage(new MainPage());
		}

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}

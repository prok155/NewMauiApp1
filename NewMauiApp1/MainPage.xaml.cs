namespace NewMauiApp1
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnClick(object sender, EventArgs e)
        {
            DependencyService.Get<Interfaces.IMyClass>().StartAnotherApp();
        }
    }

}

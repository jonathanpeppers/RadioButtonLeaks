namespace MauiMemoryLeaks
{
    public partial class MainPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MainViewModel();
        }
    }

}

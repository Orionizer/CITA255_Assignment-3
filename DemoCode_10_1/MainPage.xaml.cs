namespace DemoCode_10_1
{
    public partial class MainPage : ContentPage
    {
        List<string> products =
        [
            "Playful Cloud",
            "Split Soul Katana",
            "Slaughter Demon",
            "Inverted Spear of Heaven"
        ];

        public MainPage()
        {
            InitializeComponent();
            productList.ItemsSource = products;
        }

        private void OnProductSelected(object sender, SelectionChangedEventArgs e)
        {
            if (e.CurrentSelection.Count > 0)
            {
                string picked = e.CurrentSelection[0].ToString();

                productList.SelectedItem = null;

                if (picked == "Playful Cloud") {
                    Shell.Current.GoToAsync("PlayfulCloud");
                }else if(picked == "Split Soul Katana")
                {
                    Shell.Current.GoToAsync("SplitSoulKatana");
                }
                else if (picked == "Slaughter Demon")
                {
                    Shell.Current.GoToAsync("SlaughterDemon");
                }
                else if (picked == "Inverted Spear of Heaven")
                {
                    Shell.Current.GoToAsync("ISOH");
                }
            }
        }
    }
}

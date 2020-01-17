namespace ShellBug1
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        private string _menuItemText;

        public AppShell()
        {
            InitializeComponent();

            BindingContext = this;

            MenuItemText = "Menu item";
        }

        public string MenuItemText
        {
            get { return _menuItemText; }
            set { _menuItemText = value; OnPropertyChanged(nameof(MenuItemText)); }
        }

        private void Button_Clicked(object sender, System.EventArgs e)
        {
            MenuItemText = MenuItemText == "New menu item" ? "Menu item" : "New menu item";
        }
    }
}

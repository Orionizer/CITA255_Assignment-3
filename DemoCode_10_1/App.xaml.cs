using Microsoft.Extensions.DependencyInjection;

namespace DemoCode_10_1
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            Routing.RegisterRoute("PlayfulCloud", typeof(PlayfulCloud));
            Routing.RegisterRoute("SplitSoulKatana", typeof(SplitSoulKatana));
            Routing.RegisterRoute("SlaughterDemon", typeof(SlaughterDemon));
            Routing.RegisterRoute("ISOH", typeof(ISOH));
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new AppShell());
        }
    }
}
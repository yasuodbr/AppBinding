using Microsoft.Extensions.DependencyInjection;

namespace AppBindingCommands
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }
        //comentario 

        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new AppShell());
        }
    }
}
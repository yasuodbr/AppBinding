using Microsoft.Extensions.DependencyInjection;

namespace AppBindingCommands
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            DateTime data = DateTime.Now;
            Preferences.Set("dtAtual", data);
            Preferences.Set("AcaoInicial", string.Format("* App executado ás {0}. \n", data));

            MainPage = new AppShell();
        }
        //comentario 

        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new AppShell());
        
    }

        protected override void OnStart()
        {
                base.OnStart();
            Preferences.Set("AcaoStart", string.Format("* App iniciado ás {0}. \n", DateTime.Now));
        }
        protected override void OnSleep()
        {
            base.OnSleep();
            Preferences.Set("AcaoSleep", string.Format("* App em segundo plano ás {0}. \n", DateTime.Now));

        }
        protected override void OnResume()
        {
            base.OnResume();
            Preferences.Set("AcaoResume", string.Format("* App reativado ás {0}. \n", DateTime.Now));

        }
}
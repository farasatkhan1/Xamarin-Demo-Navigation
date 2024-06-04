using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace DemoShellNavigation
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute("flow1", typeof(Views.auth.onboarding.SignupFlow1));
            Routing.RegisterRoute("flow2", typeof(Views.auth.onboarding.SignupFlow2));
        }
    }
}

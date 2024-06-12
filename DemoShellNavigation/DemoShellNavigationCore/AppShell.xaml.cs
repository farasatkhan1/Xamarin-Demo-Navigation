using System;
using System.Collections.Generic;
using Microsoft.Maui.Controls;
using Microsoft.Maui;

namespace DemoShellNavigation
{
    public partial class AppShell : Microsoft.Maui.Controls.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute("flow1", typeof(Views.auth.onboarding.SignupFlow1));
            Routing.RegisterRoute("flow2", typeof(Views.auth.onboarding.SignupFlow2));
        }
    }
}

﻿using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace DemoShellNavigation
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute("signup", typeof(Views.Signup));
        }
    }
}

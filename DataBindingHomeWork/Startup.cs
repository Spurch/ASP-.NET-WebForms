﻿using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DataBindingHomeWork.Startup))]
namespace DataBindingHomeWork
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}

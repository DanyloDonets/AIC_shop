﻿using Microsoft.EntityFrameworkCore.Infrastructure;
using System.Windows;
namespace Drug_Shop
{
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            DatabaseFacade facade = new DatabaseFacade(new DataContext());
            facade.EnsureCreated();
        }
    }
}
using System;
using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;

namespace Skarn
{
    public class App : Application
    {
        public override void Initialize()
        {
            AvaloniaXamlLoader.Load(this);
        }

        public override void OnFrameworkInitializationCompleted()
        {
            if (ApplicationLifetime is not IClassicDesktopStyleApplicationLifetime desktop)
            {
                throw new PlatformNotSupportedException("This is a desktop-only application.");
            }
            
            desktop.MainWindow = new MainWindow();
            
            base.OnFrameworkInitializationCompleted();
        }
    }
}
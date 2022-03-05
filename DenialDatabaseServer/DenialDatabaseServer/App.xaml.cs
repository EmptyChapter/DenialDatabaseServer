using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace DenialDatabaseServer
{
    /// <summary>
    /// Application core
    /// </summary>
    public partial class App : Application
    {
        /// <summary>
        /// Raises on <see cref="Application.Startup"/> event
        /// </summary>
        /// <param name="e">Startup arguments</param>
        protected override void OnStartup(StartupEventArgs e)
        {
            MainWindow = new MainWindow();

            MainWindow.Show();

            base.OnStartup(e);
        }

        /// <summary>
        /// Raises on <see cref="Application.Exit"/> event
        /// </summary>
        /// <param name="e">Exit arguments</param>
        protected override void OnExit(ExitEventArgs e)
        {
            base.OnExit(e);
        }
    }
}

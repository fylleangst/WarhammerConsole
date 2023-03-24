using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using WarhammerConsole.ViewModel;

namespace WarhammerConsole
{
	/// <summary>
	/// Interaction logic for App.xaml
	/// </summary>
	public partial class App : Application
	{
		protected override void OnStartup(StartupEventArgs e)
		{
			base.OnStartup(e);
			var window = new MainWindow();
			var VM = new MainWindowViewModel();
			window.DataContext = VM;
			window.Show();
		}
	}
}

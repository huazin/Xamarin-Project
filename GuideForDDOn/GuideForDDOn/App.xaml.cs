using GuideForDDOn.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace GuideForDDOn
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();
            Home page = new Home();
            NavigationPage tela = new NavigationPage(page);
            MainPage = tela;
        }

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
        }
	}
}

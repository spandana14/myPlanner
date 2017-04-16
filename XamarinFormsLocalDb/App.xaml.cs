﻿
using Xamarin.Forms;

namespace XamarinFormsLocalDb
{
	public partial class App : Application
	{
		static jobdb database;
		public App()
		{
			InitializeComponent();

			MainPage = new NavigationPage(new planlist());
		}

		public static jobdb Database {
			get {
				if (database == null) {
					database = new jobdb(DependencyService.Get<ILocalFileHelper>().GetLocalFilePath("jobDb.db3"));
				}
				return database;
			}
		}


		protected override void OnStart()
		{
			// Handle when your app starts
		}

		protected override void OnSleep()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume()
		{
			// Handle when your app resumes
		}
	}
}

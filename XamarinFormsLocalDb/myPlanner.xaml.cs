
using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XamarinFormsLocalDb
{
	public partial class myPlanner : ContentPage
	{
		public myPlanner()
		{
			InitializeComponent();
		}

		async void Save_Clicked(object sender, System.EventArgs e)
		{
			var jobItem = (job)BindingContext;
			await App.Database.SavejobAsync(jobItem);
			await Navigation.PopAsync();
		}
		async void Save_Clicked1(object sender, System.EventArgs e)
		{
			var jobItem = (job)BindingContext;
			await App.Database.DeletejobAsync(jobItem);
			await Navigation.PopAsync();
		}
	}
}

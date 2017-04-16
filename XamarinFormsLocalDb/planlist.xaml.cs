
using System;
using System.Collections.Generic;
using Xamarin.Forms;
using XamarinFormsLocalDb;
using System.Collections.ObjectModel;

namespace XamarinFormsLocalDb
{
	public partial class planlist : ContentPage
	{
		public object ContextActions { get; private set; }

		public planlist()
		{
			InitializeComponent();



			var toolbarItem = new ToolbarItem
			{
				Text = "+"
			};

			toolbarItem.Clicked += async (sender, e) =>
			{
				await Navigation.PushAsync(new myPlanner() { BindingContext = new job() });
			};
			// red background
			ToolbarItems.Add(toolbarItem);
		
		}


		protected async override void OnAppearing()
		{
			base.OnAppearing();

			Planlist.ItemsSource = await App.Database.GetjobAsync();
		}

		async void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
		{
			if (e.SelectedItem != null)
			{
				await Navigation.PushAsync(new myPlanner() { BindingContext = e.SelectedItem as job });
			}
		}


	}
}

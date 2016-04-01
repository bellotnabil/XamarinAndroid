using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using System.Collections.Generic;

namespace Video5
{
	[Activity (Label = "Video5", MainLauncher = true, Icon = "@drawable/icon")]
	public class MainActivity : Activity
	{
	 	private List<string> datos;

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

 			var list = FindViewById <ListView> (Resource.Id.MainListSistemasOperativos);

			// Modelo = datos
			// Vista = contenedor de los datos
			// ModeloVista = Activity

			datos = new List<string> ();
			datos.Add ("iOS");
			datos.Add ("Android");
			datos.Add ("Windows Phone");
			datos.Add ("Black Berry");
			datos.Add ("Symbian"); // legandario

			// vista [Android.Resource.Layout.SimpleItemList1]

			list.Adapter = new ArrayAdapter (this, Android.Resource.Layout.SimpleListItem1, datos);
			list.ItemClick += List_ItemClick;
		}

		void List_ItemClick (object sender, AdapterView.ItemClickEventArgs e)
		{
			var sistemaoperativo = datos[e.Position];
			Toast.MakeText (this, sistemaoperativo, ToastLength.Short).Show();
		}
	}
}



﻿using GuideForDDOn.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace GuideForDDOn.Views
{
	public partial class Sobre : ContentPage
	{
		public Sobre ()
		{
			InitializeComponent ();
            SobreViewModel vm = new SobreViewModel();
            BindingContext = vm;
		}
	}
}

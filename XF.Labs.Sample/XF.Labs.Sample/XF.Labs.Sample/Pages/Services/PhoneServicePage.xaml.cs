﻿using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace XF.Labs.Sample
{	
	public partial class PhoneServicePage : ContentPage
	{	
		public PhoneServicePage ()
		{
			InitializeComponent ();
			BindingContext = ViewModelLocator.Main;
		}
	}
}


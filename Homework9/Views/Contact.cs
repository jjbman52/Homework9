﻿using System;

using Xamarin.Forms;

namespace Homework9.Views
{
	public class Contact
	{
		public string Name { get; set; }

		public int Age { get; set; }

		public string Occupation { get; set; }

		public string Country { get; set; }

		public override string ToString()
		{
			return Name;
		}
	}
}
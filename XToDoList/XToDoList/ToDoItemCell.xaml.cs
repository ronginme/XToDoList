﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XToDoList
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ToDoItemCell : ViewCell
	{
		public ToDoItemCell ()
		{
			InitializeComponent ();
		}
	}
}
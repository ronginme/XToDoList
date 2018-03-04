using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XToDoList
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();

            ToDoItemsList itemlist = new ToDoItemsList();
            ToDoList.BindingContext = itemlist;
        }
	}
}

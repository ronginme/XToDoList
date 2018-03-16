using System;
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
        public ToDoItemCell()
        {
            InitializeComponent();
        }

        private void OnEditBtnClick(object sender, EventArgs e)
        {
            var mainPage = Application.Current.MainPage;
            mainPage.Navigation.PushModalAsync(new EditPage());
        }
    }
}
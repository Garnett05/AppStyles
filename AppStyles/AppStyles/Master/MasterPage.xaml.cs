using AppStyles.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppStyles.Master
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MasterPage : MasterDetailPage
    {
        public MasterPage()
        {
            InitializeComponent();
        }

        private void GoImplicitStylePage(object sender, EventArgs args)
        {
            Detail = new NavigationPage(new ImplicitStylePage());
            IsPresented = false;
        }
    }
}
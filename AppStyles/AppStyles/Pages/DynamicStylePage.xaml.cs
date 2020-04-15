using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppStyles.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DynamicStylePage : ContentPage
    {
        public DynamicStylePage()
        {
            InitializeComponent();
        }

        private void ChangeColor (object sender, EventArgs args)
        {
            this.Resources["lblColor"] = Color.Black;
            this.Resources["lbl"] = this.Resources["newLbl"];
        }
    }
}
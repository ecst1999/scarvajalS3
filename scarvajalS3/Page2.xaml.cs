using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace scarvajalS3
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page2 : ContentPage
    {
        public Page2(string dato1, double dato2)
        {
            InitializeComponent();
            lblDato1.Text = "DATO 1 =======>" + dato1;
            txtDato2.Text = "DATO 2 =======>" + dato2.ToString();
        }

        private void btnAbrir_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page3());
        }
    }
}
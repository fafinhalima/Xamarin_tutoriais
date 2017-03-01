using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Aulas
{
	public partial class login : ContentPage
	{
		public login ()
		{
			InitializeComponent ();

            this.btnLogar.Clicked += BtnLogar_Clicked;
		}

        private void BtnLogar_Clicked(object sender, EventArgs e)
        {
           this.Navigation.PushAsync(new Home());

        }
    }
}

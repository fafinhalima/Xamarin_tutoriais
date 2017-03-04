using System;
using Aulas.ViewModels;

using Xamarin.Forms;

namespace Aulas
{
	public partial class PrimeiraPagina
	{
		public PrimeiraPagina ()
		{
			InitializeComponent ();
            BindingContext = new PrimeriaPaginaViewModel();
		}
	}
}

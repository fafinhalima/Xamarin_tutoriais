using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.ComponentModel;
using Xamarin.Forms;
using System.Runtime.CompilerServices;

namespace Aulas.ViewModels
{
	public class BaseViewModel:INotifyPropertyChanged
	{
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged
            ([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this,
                new PropertyChangedEventArgs(propertyName));
        }
    }
}

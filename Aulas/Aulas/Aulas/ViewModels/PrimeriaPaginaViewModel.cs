using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.ComponentModel;
using Aulas.models;
using Xamarin.Forms;
using System.Runtime.CompilerServices;
using System.Collections.ObjectModel;

namespace Aulas.ViewModels
{
	public class PrimeriaPaginaViewModel:BaseViewModel
	{
        private int _primeiroNumero;
        private int _segundoNumero;
        private int _resultado;
		public int PrimeiroNumero
        {
            get
            {
                return _primeiroNumero;
            }
            set
            {
                _primeiroNumero = value;
                OnPropertyChanged();
                SomarCommand.ChangeCanExecute();
            }
        }
                
                
        public int SegundoNumero
        {
            get
            {
                return _segundoNumero;
            }
            set
            {
                _segundoNumero = value;
                OnPropertyChanged();
                SomarCommand.ChangeCanExecute();
            }
        }
        public int Resultado
        {
            get
            {
                return _resultado;
            }
            set
            {
                _resultado = value;
                OnPropertyChanged();
                
            }
        }

        public Command SomarCommand
        {
            get;
            private set;
        }
        public PrimeriaPaginaViewModel()
        {
            SomarCommand = new Command(ExecuteSomarCommand,
                CanExecuteSomarCommand);
            Historico = new ObservableCollection<ItemDeHistorico>();
        }

        private bool CanExecuteSomarCommand() =>
            PrimeiroNumero >= 0 &&
            SegundoNumero >= 0;
        private void ExecuteSomarCommand()
        {
            Resultado = PrimeiroNumero + SegundoNumero;
            Historico.Add( new ItemDeHistorico ( PrimeiroNumero, SegundoNumero, Resultado)
                );
        }
         public ObservableCollection<ItemDeHistorico> Historico { get; private set; }
    }
}

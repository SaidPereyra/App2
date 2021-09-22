using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace App2.ViewModels
{
    class MainPageViewModel : ViewModelBase
    {


        private string _nombre;

        public MainPageViewModel()
        {
            _nombre = "holi";
        }

        public string Nombre
        {
            get => _nombre;
            set
            {
                if (string.Equals(_nombre, value)) return;
                _nombre = value;
                RaisePropertyChanged(nameof(Nombre));
                RaisePropertyChanged(nameof(SinUpdate));
            }
        }

        public string SinUpdate
        {
            get => _nombre;
        }

    }
}


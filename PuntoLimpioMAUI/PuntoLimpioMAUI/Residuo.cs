using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PuntoLimpioMAUI
{
    internal class Residuo : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private int _cantidad;
        public string Nombre { get; set; }
        public string Tipo { get; set; }

        public int Cantidad
        {
            get => _cantidad;
            set
            {
                if (_cantidad != value)
                {
                    _cantidad = value;
                    OnPropertyChanged(); 
                }
            }
        }

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public Residuo(string nombre, string tipo, int cantidad)
        {
            Nombre = nombre;
            Tipo = tipo;
            _cantidad = cantidad;
        }

    }
}

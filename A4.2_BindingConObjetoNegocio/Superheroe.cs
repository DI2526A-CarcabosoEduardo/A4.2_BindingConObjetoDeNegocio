using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace A42_EduardoCarcaboso_BindingConObjetoNegocio
{
    public partial class Superheroe : ObservableObject
    {
        private string _nombre;
        public string Nombre
        {
            get => _nombre;
            set => SetProperty(ref _nombre, value);
        }
        private string _imagenRuta;
        public string ImagenRuta
        {
            get => _imagenRuta;
            set
            {
                if (SetProperty(ref _imagenRuta, value))
                {
                    OnPropertyChanged(nameof(Imagen));
                }
            }

        }






        private bool _vengador;
        public bool Vengador
        {
            get => _vengador;
            set => SetProperty(ref _vengador, value);
        }
        private bool _xmen;
        public bool Xmen
        {
            get => _xmen;
            set => SetProperty(ref _xmen, value);
        }
        private bool _heroe;
        public bool Heroe
        {
            get => _heroe;
            set => SetProperty(ref _heroe, value);
        }

        public Superheroe()
        {
        }

        public Superheroe(string nombre, string imagenRuta, bool vengador, bool xmen, bool heroe)
        {
            Nombre = nombre;
            ImagenRuta = imagenRuta;
            Vengador = vengador;
            Xmen = xmen;
            Heroe = heroe;
        }

        public BitmapImage Imagen
        {
            get
            {
                return new BitmapImage(new Uri($"C:\\Users\\alumno\\source\\repos\\A4.2_GilKeiko_BObjetoNegocio\\A4.2_GilKeiko_BObjetoNegocio\\{ImagenRuta}"));
            }
        }
    }
}

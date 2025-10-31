using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A42_EduardoCarcaboso_BindingConObjetoNegocio
{
    class MainWindowModel : ObservableObject
    {
        private int _indice = 0;
        public string IndiceTexto => $"{_indice + 1}/{Superheroes.Count}";

        private readonly DataService _dataService = new DataService();

        public ObservableCollection<Superheroe> Superheroes { get; set; }

        private Superheroe _superheroeSeleccionado;

        public Superheroe SuperheroeSeleccionado
        {
            get => _superheroeSeleccionado;
            set
            {
                if (SetProperty(ref _superheroeSeleccionado, value))
                {
                    OnPropertyChanged(nameof(IndiceTexto));
                }
            }
        }

        public MainWindowModel()
        {
            Superheroes = new ObservableCollection<Superheroe>(_dataService.GetSuperheroes());
            if (Superheroes.Count > 0)
                SuperheroeSeleccionado = Superheroes[0];
        }





        public void Siguiente()
        {
            Debug.WriteLine(SuperheroeSeleccionado.Heroe);

            if (Superheroes.Count == 0) return;

            _indice++;
            if (_indice >= Superheroes.Count)
            {
                _indice = 0;
            }
            SuperheroeSeleccionado = Superheroes[_indice];
            OnPropertyChanged(nameof(IndiceTexto));
        }

        public void Anterior()
        {
            Debug.WriteLine(SuperheroeSeleccionado.Heroe);

            if (Superheroes.Count == 0) return;

            _indice--;
            if (_indice < 0)
            {
                _indice = Superheroes.Count - 1;
            }
            SuperheroeSeleccionado = Superheroes[_indice];
            OnPropertyChanged(nameof(IndiceTexto));
        }
    }
}

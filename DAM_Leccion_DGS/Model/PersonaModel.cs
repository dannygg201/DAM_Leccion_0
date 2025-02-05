using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DAM_Leccion_DGS.Model
{
    public class PersonaModel:INotifyPropertyChanged
    {
        //Atributos

        private string? nombre;
        private string? apellido;
        private string? edad;

        //Propiedades

        public string? Nombre { 
            
            get => nombre ; set
            {
                nombre = value;
                OnPropertyChanged();
            }
        }

        public string? Apellido
        {

            get => apellido; set
            {
                apellido = value;
                OnPropertyChanged();    
            }
        }

        public string? Edad
        {

            get => edad; set
            {
                edad = value;
                OnPropertyChanged();
            }
        }


        public event PropertyChangedEventHandler? PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName=null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        } 
    }
}

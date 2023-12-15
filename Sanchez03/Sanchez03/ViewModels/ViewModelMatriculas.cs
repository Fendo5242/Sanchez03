using Sanchez03.Models;
using Sanchez03.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Sanchez03.ViewModels
{
    public class ViewModelMatriculas : BaseViewModel
    {
        DateTime fechaMatricula;
        public DateTime FechaMatricula
        {
            get { return fechaMatricula; }
            set
            {
                if (fechaMatricula != value)
                {
                    fechaMatricula = value;
                    OnPropertyChanged();
                }
            }
        }
        string nombreEstudiante;
        public string NombreEstudiante
        {
            get { return nombreEstudiante; }
            set
            {
                if (nombreEstudiante != value)
                {
                    nombreEstudiante = value;
                    OnPropertyChanged();
                }
            }
        }
        string nombreCurso;
        public string NombreCurso
        {
            get { return nombreCurso; }
            set
            {
                if (nombreCurso != value)
                {
                    nombreCurso = value;
                    OnPropertyChanged();
                }
            }
        }
        string sexo;
        public string Sexo
        {
            get { return sexo; }
            set
            {
                if (sexo != value)
                {
                    sexo = value;
                    OnPropertyChanged();
                }
            }
        }
        private string filter;
        public string Filter
        {
            get { return this.filter; }
            set { SetValue(ref this.filter, value); }
        }

        private List<Matricula> matriculas;
        public List<Matricula> Matriculas
        {
            get { return this.matriculas; }
            set { SetValue(ref this.matriculas, value); }
        }


        public ICommand SearchCommand { get; set; }
        public ICommand InsertCommand { get; set; }

        public ViewModelMatriculas()
        {

            SearchCommand = new Command(() =>
            {
                MatriculaService service = new MatriculaService();
                Matriculas = service.GetByText(Filter);


            });

            InsertCommand = new Command(() =>
            {
                MatriculaService service = new MatriculaService();
                service.Create(new Matricula { FechaMatricula = FechaMatricula, NombreEstudiante = NombreEstudiante, NombreCurso = NombreCurso, Sexo = Sexo});

                App.Current.MainPage.DisplayAlert("Success", "Your data are saved", "Ok");
            });
        }
    }
}

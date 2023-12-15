using Sanchez03.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Sanchez03.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MatriculasView : ContentPage
    {
        public MatriculasView()
        {
            InitializeComponent();
            this.BindingContext = new ViewModelMatriculas();

        }
    }
}
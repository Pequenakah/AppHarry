using AppHarry.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppHarry.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageProfessores : ContentPage
    {
        public PageProfessores()
        {
            InitializeComponent();
        }

        async void AbrirDetalhesProfessores(System.Object sender, Xamarin.Forms.SelectionChangedEventArgs e)
        {
            string nomeProfessores= (e.CurrentSelection.FirstOrDefault() as Harry).Nome;
            await Shell.Current.GoToAsync($"detalhesProfessores?nome={nomeProfessores}");
        }

        
    }
}
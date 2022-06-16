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
    public partial class PageAlunos : ContentPage
    {
        public PageAlunos()
        {
            InitializeComponent();
        }

   

        private async void AbrirDetalhesAlunos(object sender, SelectionChangedEventArgs e)
        {
            string nomeAlunos = (e.CurrentSelection.FirstOrDefault() as Harry).Nome;
            await Shell.Current.GoToAsync($"detalhesAlunos?nome={nomeAlunos}");
        }

       
    }
}
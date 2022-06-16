using AppHarry.Data;
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
    [QueryProperty(nameof(Nome), "nome")]

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageDetalhesProfessores : ContentPage
    {
        public string Nome
        {
            set
            {
                LoadComida(value);
            }
        }
        void LoadComida(string nome)
        {
            try
            {
                Harry harry = DadosProfessores.Professores.FirstOrDefault(a => a.Nome ==
               nome);
                BindingContext = harry;
            }
            catch (Exception)
            {
                Console.WriteLine("Erro.");
            }
        }
        public PageDetalhesProfessores()
        {
            InitializeComponent();
        }
    }
}
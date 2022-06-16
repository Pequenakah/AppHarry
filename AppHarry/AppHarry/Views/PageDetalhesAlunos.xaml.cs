using System;
using System.Collections.Generic;
using AppHarry.Models;
using AppHarry.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppHarry.Views
{
    [QueryProperty(nameof(Nome), "nome")]

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageDetalhesAlunos : ContentPage
    {
        public string Nome
        {
            set
            {
                LoadHarry(value);
            }
        }
        void LoadHarry(string nome)
        {
            try
            {
                Harry harry = DadosAlunos.Alunos.FirstOrDefault(a => a.Nome == nome);
                BindingContext = harry;
            }
            catch (Exception)
            {
                Console.WriteLine("Erro.");
            }
        }
            public PageDetalhesAlunos ()
           {
            InitializeComponent();
            }

           
         }
     } 
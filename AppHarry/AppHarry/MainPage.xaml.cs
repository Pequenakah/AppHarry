using AppHarry.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppHarry
{
    public partial class MainPage : Shell
    {
        public Dictionary<string, Type> Routes { get; private set; } = new Dictionary<string, Type>();

        void RegisterRoutes()
        {
            Routes.Add("detalhesAlunos", typeof(PageDetalhesAlunos));
            Routes.Add("detalhesProfessores", typeof(PageDetalhesProfessores));
            foreach (var item in Routes)
            {
                Routing.RegisterRoute(item.Key, item.Value);
            }
        }
        public MainPage()
        {
            InitializeComponent();
            RegisterRoutes();
            BindingContext = this;
        }
    }
}

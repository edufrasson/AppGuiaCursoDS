using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppGuiaCursoDS
{
    public partial class MainPage : MasterDetailPage
    {
        public MainPage()
        {
            InitializeComponent();

            Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(Inicial)));
        }

        private void Open_Inicial(object sender, EventArgs e)
        {
            Console.WriteLine("a");
        }

        private void Open_Primeiro(object sender, EventArgs e)
        {
            Console.WriteLine("a");
        }

        private void Open_Segundo(object sender, EventArgs e)
        {
            Console.WriteLine("a");
        }

        private void Open_Terceiro(object sender, EventArgs e)
        {
            Console.WriteLine("a");
        }

        private void Open_Vestibulinho(object sender, EventArgs e)
        {
            Console.WriteLine("a");
        }
        private void Open_Contato(object sender, EventArgs e)
        {
            Console.WriteLine("a");
        }
    }
}

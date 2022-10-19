using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using AppGuiaCursoDS.Model;

namespace AppGuiaCursoDS.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ComponentesPrimeiro : ContentPage
    {
        public ComponentesPrimeiro()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            var c = new Componente
            {
                Nome = "Linguagem, Trabalho e Tecnologia",
                Atribuicoes = "Comunicar-se em língua portuguesa, utilizando o vocabulário técnico da área e elaborar registros e planilhas de acompanhamento e controle de atividades",
                Valores = "Incentivar o diálogo e a interlocução. • Responsabilizar-se pela produção, utilização e divulgação de informações. • Estimular a proatividade. "
            };

            await Navigation.PushAsync(new VerComponente(c));
        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            var c = new Componente
            {
                Nome = "Programação e Algoritmos",
                Atribuicoes = "• Implementar algoritmos em linguagem de programação, utilizando ambientes de desenvolvimento de acordo com as necessidades. ",
                Valores = "• Estimular a organização. • Incentivar atitudes de autonomia. • Fortalecer a persistência e o interesse na resolução de situações-problema. "
            };

            await Navigation.PushAsync(new VerComponente(c));
        }

        private async void Button_Clicked_2(object sender, EventArgs e)
        {
            var c = new Componente
            {
                Nome = "Banco de Dados I",
                Atribuicoes = "Modelar banco de dados ",
                Valores = "Estimular a organização. • Fortalecer a persistência e o interesse na resolução de situações-problema. • Promover ações que considerem o respeito às normas estabelecidas."
            };

            await Navigation.PushAsync(new VerComponente(c));
        }

        private async void Button_Clicked_3(object sender, EventArgs e)
        {
            var c = new Componente
            {
                Nome = "Análise e Projeto de Sistemas",
                Atribuicoes = "Elaborar projetos de sistema de informação.  ",
                Valores = "Estimular a organização. • Incentivar a criatividade. • Fortalecer a persistência e o interesse na resolução de situações-problema.  "
            };

            await Navigation.PushAsync(new VerComponente(c));
        }

        private async void Button_Clicked_4(object sender, EventArgs e)
        {
            var c = new Componente
            {
                Nome = "Design Digital",
                Atribuicoes = "Desenvolver elementos gráficos para aplicativos e sites.  ",
                Valores = "Incentivar a criatividade. • Respeitar as manifestações culturais de outros povos. • Incentivar ações que promovam a cooperação. "
            };

            await Navigation.PushAsync(new VerComponente(c));
        }

        private async void Button_Clicked_5(object sender, EventArgs e)
        {
            var c = new Componente
            {
                Nome = "Programação Web I",
                Atribuicoes = "Desenvolver sites para Web ",
                Valores = "Incentivar a criatividade. • Estimular a organização. • Fortalecer a persistência e o interesse na resolução de situações-problema.  "
            };

            await Navigation.PushAsync(new VerComponente(c));
        }

        private async void Button_Clicked_6(object sender, EventArgs e)
        {
            var c = new Componente
            {
                Nome = "Fundamentos da Informática",
                Atribuicoes = "Operar sistemas computacionais.  ",
                Valores = "Desenvolver a criticidade. • Incentivar comportamentos éticos. • Promover ações que considerem o respeito às normas estabelecidas.  "
            };

            await Navigation.PushAsync(new VerComponente(c));
        }

        private async void Button_Clicked_7(object sender, EventArgs e)
        {
            var c = new Componente
            {
                Nome = "Técnicas de Programação",
                Atribuicoes = "Desenvolver programas de computador, utilizando princípios de boas práticas. • Realizar versionamento no desenvolvimento de programas.  • Verificar usabilidade no desenvolvimento de programas.  ",
                Valores = "Incentivar a criatividade. • Incentivar comportamentos éticos. • Fortalecer a persistência e o interesse na resolução de situações-problema. "
            };

            await Navigation.PushAsync(new VerComponente(c));
        }
    } 
}
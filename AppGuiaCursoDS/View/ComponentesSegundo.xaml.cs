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
    public partial class ComponentesSegundo : ContentPage
    {
        public ComponentesSegundo()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                var c = new Componente
                {
                    Nome = "Inglês Instrumental",
                    Atribuicoes = "Comunicar-se em língua estrangeira – inglês, utilizando o vocabulário e a terminologia da área.  ",
                    Valores = "Respeitar as manifestações culturais de outros povos. • Estimular a comunicação nas relações interpessoais. • Socializar os saberes.  "
                };

                await Navigation.PushAsync(new VerComponente(c));
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }
        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            try
            {
                var c = new Componente
                {
                    Nome = "Desenvolvimento de Sistemas",
                    Atribuicoes = "Analisar e projetar sistemas de informação, selecionando linguagens de programação e ambientes de desenvolvimento de acordo com as especificidades do projeto. • Codificar e depurar programas. ",
                    Valores = "Fortalecer a persistência e o interesse na resolução de situações-problema. • Incentivar ações que promovam a cooperação. • Desenvolver a criatividade. "
                };

                await Navigation.PushAsync(new VerComponente(c));
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }
        }

        private async void Button_Clicked_2(object sender, EventArgs e)
        {
            try
            {
                var c = new Componente
                {
                    Nome = "Banco de Dados II ",
                    Atribuicoes = "Implementar banco de dados. ",
                    Valores = "Incentivar a criatividade. • Desenvolver a criticidade. • Fortalecer a persistência e o interesse na resolução de situações-problema "
                };

                await Navigation.PushAsync(new VerComponente(c));
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }
        }

        private async void Button_Clicked_3(object sender, EventArgs e)
        {
            try
            {
                var c = new Componente
                {
                    Nome = "Internet e Protocolos ",
                    Atribuicoes = "Utilizar protocolos de redes e internet para comunicação de dados.  ",
                    Valores = "Incentivar comportamentos éticos. • Promover ações que considerem o respeito às normas estabelecidas. • Fortalecer a persistência e o interesse na resolução de situações-problema.  "
                };

                await Navigation.PushAsync(new VerComponente(c));
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }
        }

        private async void Button_Clicked_4(object sender, EventArgs e)
        {
            try
            {
                var c = new Componente
                {
                    Nome = "Programação de Aplicativos Mobile I ",
                    Atribuicoes = "Elaborar projetos de aplicativos para plataformas móveis. ",
                    Valores = "Incentivar a criatividade. • Responsabilizar-se pela produção, utilização e divulgação de informações. • Estimular a organização.  "
                };

                await Navigation.PushAsync(new VerComponente(c));
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }
        }

        private async void Button_Clicked_5(object sender, EventArgs e)
        {
            try
            {
                var c = new Componente
                {
                    Nome = "Programação Web II",
                    Atribuicoes = "Planejar projetos de sistemas de informação para web ",
                    Valores = "Responsabilizar-se pela produção, utilização e divulgação de informações. • Fortalecer a persistência e o interesse na resolução de situações-problema. • Incentivar a criatividade.  "
                };

                await Navigation.PushAsync(new VerComponente(c));
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }
        }

        private async void Button_Clicked_6(object sender, EventArgs e)
        {
            try
            {
                var c = new Componente
                {
                    Nome = "Planejamento do Trabalho de Conclusão de Curso (TCC) em Desenvolvimento de Sistemas ",
                    Atribuicoes = "Planejar projetos de sistemas computacionais ",
                    Valores = "Comunicar-se com a equipe com clareza e objetividade. • Organizar procedimentos de maneira diversa, visando melhor eficiência "
                };

                await Navigation.PushAsync(new VerComponente(c));
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }
        }
    }
}
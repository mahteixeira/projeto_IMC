using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace IMC
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Cauculo_Clicked(object sender, EventArgs e)
        {
            double Altura2 = double.Parse(Altura.Text);
            double Peso2 = double.Parse(Peso.Text);

            double conta = Peso2 / (Altura2 * Altura2);



            if (conta <= 18.5)
            {
                DisplayAlert("VOCÊ ESTÁ ABAIXO DO PESO", "Seu imc é de " + conta.ToString("0.0"), "OK");

            }
            else if (18.5 < conta && conta <= 24.9)
            {

                DisplayAlert("VOCÊ ESTÁ NO PESO NORMAL", "Seu imc é de " + conta.ToString("0.0"), "OK");

            }
            else if (25 <= conta && conta <= 29.9)
            {
                DisplayAlert("VOCÊ ESTÁ ACIMA DO PESO", "Seu imc é de " + conta.ToString("0.0"), "OK");

            }
            else if (30 <= conta && conta <= 34.9)
            {
                DisplayAlert("VOCÊ ESTÁ NA OBESIDADE GRAU 1", "Seu imc é de " + conta.ToString("0.0"), "OK");

            }
            else if (35 <= conta && conta <= 39.9)
            {
                DisplayAlert("VOCÊ ESTÁ NA OBESIDADE GRAU 2", "Seu imc é de " + conta.ToString("0.0"), "OK");

            }
            else if (conta >= 40)
            {
                DisplayAlert("VOCÊ ESTÁ NA OBESIDADE GRAU 3", "Seu imc é de " + conta.ToString("0.0"), "OK");
            }
        }
    }
}

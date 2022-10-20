using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PM2_P1Tarea1_1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void btnSuma_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNum1.Text) || string.IsNullOrWhiteSpace(txtNum2.Text))
            {
                await DisplayAlert("ALERTA", "Debe llenar ambos campos ", "Ok");
                return;
            }
            decimal num1 = decimal.Parse(txtNum1.Text);
            decimal num2 = decimal.Parse(txtNum2.Text);
            decimal result;

            result = num1 + num2;
            await Navigation.PushAsync(new Views.PageResult(result));


        }

        private async void btnResta_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNum1.Text) || string.IsNullOrWhiteSpace(txtNum2.Text))
            {
                await DisplayAlert("ALERTA", "Debe llenar ambos campos ", "Ok");
                return;
            }
            decimal num1 = decimal.Parse(txtNum1.Text);
            decimal num2 = decimal.Parse(txtNum2.Text);
            decimal result;

            result = num1 - num2;
            await Navigation.PushAsync(new Views.PageResult(result));
        }

        private async void btnDivision_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNum1.Text) || string.IsNullOrWhiteSpace(txtNum2.Text))
            {
                await DisplayAlert("ALERTA", "Debe llenar ambos campos ", "Ok");
                return;
            }
            decimal num1 = decimal.Parse(txtNum1.Text);
            decimal num2 = decimal.Parse(txtNum2.Text);
            decimal result;

            result = num1 / num2;
            await Navigation.PushAsync(new Views.PageResult(result));

        }

        private async void btnMultiplicacion_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNum1.Text) || string.IsNullOrWhiteSpace(txtNum2.Text))
            {
                await DisplayAlert("ALERTA", "Debe llenar ambos campos ", "Ok");
                return;
            }
            decimal num1 = decimal.Parse(txtNum1.Text);
            decimal num2 = decimal.Parse(txtNum2.Text);
            decimal result;

            result = num1 * num2;
            await Navigation.PushAsync(new Views.PageResult(result));

        }

        private void btnBorrar_Clicked(object sender, EventArgs e)
        {
            txtNum1.Text = "";
            txtNum2.Text = "";

        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PM2_P1Tarea1_1.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageResult : ContentPage
    {
        public PageResult()
        {
            InitializeComponent();
        }
        public PageResult(decimal result)
        {
            InitializeComponent();
            ResultadoOpe.Text = "El resultado es :" + result.ToString("0.##");
        }
    }
}
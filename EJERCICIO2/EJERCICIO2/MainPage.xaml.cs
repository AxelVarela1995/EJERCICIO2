using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace EJERCICIO2
{
   
        public partial class MainPage : ContentPage
        {
            public MainPage()
            {
                InitializeComponent();
            }

            private async void btnagregar_Clicked(object sender, EventArgs e)
            {
                Models.Operaciones OP = new Models.Operaciones();
                OP.n1 = Convert.ToInt32(txtnum1.Text);
                OP.n2 = Convert.ToInt32(txtnum2.Text);
                await Navigation.PushAsync(new ResultPage(Convert.ToInt32(OP.n1 + OP.n2)));

            }

            private async void Multiplicacion(object sender, EventArgs e)
            {
                Models.Operaciones OP = new Models.Operaciones();
                OP.n1 = Convert.ToInt32(txtnum1.Text);
                OP.n2 = Convert.ToInt32(txtnum2.Text);
                await Navigation.PushAsync(new ResultPage(Convert.ToInt32(OP.n1 * OP.n2)));
               
            }

            private async void Resta(object sender, EventArgs e)
            {
                Models.Operaciones OP = new Models.Operaciones();
                OP.n1 = Convert.ToInt32(txtnum1.Text);
                OP.n2 = Convert.ToInt32(txtnum2.Text);
                await Navigation.PushAsync(new ResultPage(Convert.ToInt32(OP.n1 - OP.n2)));
                
            }

            private async void Divisiones(object sender, EventArgs e)
            {
                Models.Operaciones OP = new Models.Operaciones();
                OP.n1 = Convert.ToInt32(txtnum1.Text);
                OP.n2 = Convert.ToInt32(txtnum2.Text);
                await Navigation.PushAsync(new ResultPage(Convert.ToInt32(OP.n1 / OP.n2)));
               
            }


        }
    }


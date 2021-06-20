using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Gastos.DB;
using Gastos.Models;

namespace App_Gastos_Mensais
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            GastosDB.gastos.Add(new Compra(12.0, "Presunto"));
            GastosDB.gastos.Add(new Compra(15.0, "Cerveja"));
            GastosDB.gastos.Add(new Compra(32.0, "Carne"));
            Gasto.ItemsSource = GastosDB.gastos;
        }

        private async void Compras_selected(object sender, SelectedItemChangedEventArgs e)
        {
            Gasto selecionar = (Gasto)e.SelectedItem;
            Detalhes detalhes = new Detalhes(selecionar);
            await Navigation.PushAsync(detalhes);
        }

        private void Cadastrar(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(descricaoCompra.Text) || string.IsNullOrEmpty(preco.Text))
            {
                DisplayAlert("Erro", "Campos mal preenchidos", "Ok");
            }
            else
            {
                double preco;

                if (double.TryParse(precoCompra.Text, out preco))
                {
                    GastosDB.gastos.Add(new Gasto(preco, descricao.Text));
                    descricao.Text = "";
                    preco.Text = "";

                }
            }

        }
    }
}

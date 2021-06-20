using Gastos.DB;
using Gastos.Models;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Gastos
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Detalhes : ContentPage
    {
        private Gasto gasto;
        public Detalhes(Gasto gasto)
        {
            InitializeComponent();
            Title = "Descrição dos seus gastos";
            this.gasto = gasto;
            descricao.Text = gasto.Descricao;
            preco.Text = gasto.Preco.ToString();
        }

        private async void Voltar(object sender, System.EventArgs e)
        {
            await Navigation.PopAsync();
        }
        private async void Remover(object sender, System.EventArgs e)
        {
            GastosDB.gastos.Remove(this.gasto);
            await Navigation.PopAsync();
        }
    }
}
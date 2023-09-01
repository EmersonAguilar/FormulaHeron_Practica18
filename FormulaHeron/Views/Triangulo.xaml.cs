namespace FormulaHeron.Views;

public partial class Triangulo : ContentPage
{
	public Triangulo()
	{
		InitializeComponent();
	}

    private void triangulo_Clicked(object sender, EventArgs e)
    {
		if(!string.IsNullOrEmpty(lado1.Text)&& !string.IsNullOrEmpty(lado2.Text)
			&& !string.IsNullOrEmpty(lado3.Text))
		{
			var a = Convert.ToDouble(lado1.Text);
            var b = Convert.ToDouble(lado2.Text);
            var c = Convert.ToDouble(lado3.Text);

			var d = (a + b + c) / 2;
            suma.Text = Convert.ToString(d);

            var f = (d*(d-a)*(d-b)*(d-c));
			var fina = Math.Sqrt(f);
			resp.Text = Convert.ToString(fina);

        }
		else
		{
			DisplayAlert("Error", "Dijite en todos los campos animal", "Adoptado");
		}
    }

    private void limpiar_Clicked(object sender, EventArgs e)
    {
		lado1.Text = "";
        lado2.Text = "";
        lado3.Text = "";
		suma.Text = "";
		resp.Text = "";
    }
}
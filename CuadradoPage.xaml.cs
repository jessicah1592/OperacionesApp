namespace OperacionesApp
{
    public partial class CuadradoPage : ContentPage
    {
        public CuadradoPage()
        {
            InitializeComponent();
        }

        void CalcularAreaCuadrado(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ladoCuadrado.Text))
            {
                resultadoCuadrado.Text = "Por favor, ingrese el lado del cuadrado.";
                return;
            }

            if (double.TryParse(ladoCuadrado.Text, out double lado))
            {
                double area = lado * lado;
                resultadoCuadrado.Text = $"�rea del cuadrado: {area:F2}";
            }
            else
            {
                resultadoCuadrado.Text = "Ingrese un n�mero v�lido.";
            }
        }

        void LimpiarCuadrado(object sender, EventArgs e)
        {
            ladoCuadrado.Text = string.Empty;
            resultadoCuadrado.Text = string.Empty;
        }
    }
}

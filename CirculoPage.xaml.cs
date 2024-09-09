namespace OperacionesApp
{
    public partial class CirculoPage : ContentPage
    {
        public CirculoPage()
        {
            InitializeComponent();
        }

        void CalcularAreaCirculo(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(radioCirculo.Text))
            {
                resultadoCirculo.Text = "Por favor, ingrese el radio del círculo.";
                return;
            }

            if (double.TryParse(radioCirculo.Text, out double radio))
            {
                double area = Math.PI * radio * radio;
                resultadoCirculo.Text = $"Área del círculo: {area:F2}";
            }
            else
            {
                resultadoCirculo.Text = "Ingrese un número válido.";
            }
        }

        void LimpiarCirculo(object sender, EventArgs e)
        {
            radioCirculo.Text = string.Empty;
            resultadoCirculo.Text = string.Empty;
        }
    }
}

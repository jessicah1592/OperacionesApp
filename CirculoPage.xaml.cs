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
                resultadoCirculo.Text = "Por favor, ingrese el radio del c�rculo.";
                return;
            }

            if (double.TryParse(radioCirculo.Text, out double radio))
            {
                double area = Math.PI * radio * radio;
                resultadoCirculo.Text = $"�rea del c�rculo: {area:F2}";
            }
            else
            {
                resultadoCirculo.Text = "Ingrese un n�mero v�lido.";
            }
        }

        void LimpiarCirculo(object sender, EventArgs e)
        {
            radioCirculo.Text = string.Empty;
            resultadoCirculo.Text = string.Empty;
        }
    }
}

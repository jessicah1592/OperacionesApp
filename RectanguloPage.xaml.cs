namespace OperacionesApp
{
    public partial class RectanguloPage : ContentPage
    {
        public RectanguloPage()
        {
            InitializeComponent();
        }

        void CalcularAreaRectangulo(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(baseRectangulo.Text) || string.IsNullOrWhiteSpace(alturaRectangulo.Text))
            {
                resultadoRectangulo.Text = "Por favor, ingrese la base y la altura del rect�ngulo.";
                return;
            }

            if (double.TryParse(baseRectangulo.Text, out double baseRect) && double.TryParse(alturaRectangulo.Text, out double altura))
            {
                double area = baseRect * altura;
                resultadoRectangulo.Text = $"�rea del rect�ngulo: {area:F2}";
            }
            else
            {
                resultadoRectangulo.Text = "Ingrese n�meros v�lidos.";
            }
        }

        void LimpiarRectangulo(object sender, EventArgs e)
        {
            baseRectangulo.Text = string.Empty;
            alturaRectangulo.Text = string.Empty;
            resultadoRectangulo.Text = string.Empty;
        }
    }
}

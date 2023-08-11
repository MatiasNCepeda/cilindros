namespace cilindrosWindows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double radio;
        double altura;
        double area;
        double volumen;
        double basee;
        int contador;
        private void CalcularBoton_Click(object sender, EventArgs e)
        {
            if (ValidarNumeros()==false)
            {
                MessageBox.Show("Error ingrese numero");
            }
            else
            {
                if (radio < 0 || altura < 0)
                {
                    MessageBox.Show("Error ingrese numero positivo");
                }
                else if (radio == 0 || altura == 0)
                {
                    MessageBox.Show("Los Valores no pueden ser 0");
                }
                else
                {
                    area = FuncionArea(altura, radio);
                    basee = FuncionBase(radio);
                    volumen = FuncionVolumen(basee, altura);
                    MessageBox.Show($"El area es {area} y el volumen es {volumen}");
                    RadioText.Clear();
                    AlturaText.Clear();
                    contador = contador + 1;
                    LabelContador.Text = contador.ToString();
                }
            }
        }

        private double FuncionVolumen(double basee, double altura)
        {
            double resultado;
            resultado = basee * altura;
            return resultado;
        }

        private double FuncionBase(double radio)
        {
            double resultado;
                resultado = Math.PI * Math.Pow(radio, 2);
            return resultado;
        }

        private double FuncionArea(double altura, double radio)
        {
            double resultado;
            resultado = 2 * Math.PI * radio * (altura + radio);
            return resultado;
        }

        private bool ValidarNumeros()
        {
            bool validar = true;

            if (!double.TryParse(RadioText.Text, out radio))
            {
                validar = false;
                
            }
            if (!double.TryParse(AlturaText.Text, out altura))
            {
                validar = false;                  
            }

            return validar;
        }
    }
}
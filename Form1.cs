using System.Drawing;

namespace CalculadoraWindows
{
    public partial class Form1 : Form
    {
        Double resultado = 0;
        string operacion = string.Empty;
        string primerNumero, segundoNumero;
        bool enterValue = false;
        public bool MinimizeBox { get; set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Cerrar Ventana
            Application.Exit();
        }
        private void Minimizar_Click(object sender, EventArgs e)
        {
            //Minimizar Ventana
            this.WindowState = FormWindowState.Minimized;
        }


        private void BtnNum_Click(object sender, EventArgs e)
        {
            if (textDisplay1.Text == "0" || enterValue) textDisplay1.Text = string.Empty;
            {
                enterValue = false;
                Button button = (Button)sender;

                if (button.Text == "π")
                {
                    // Asigna el valor de Pi al display en lugar del símbolo del botón.
                    textDisplay1.Text = Math.PI.ToString("0.##########"); // Muestra el valor de Pi con hasta 10 decimales
                }
                else if (button.Text == ".")
                {
                    if (!textDisplay1.Text.Contains("."))
                        textDisplay1.Text += button.Text;

                }

                else
                {
                    textDisplay1.Text += button.Text;
                }
            }
        }

        private void BtnOperaciones(object sender, EventArgs e)
        {
            if (resultado != 0) BtnEqual.PerformClick();
            else resultado = Double.Parse(textDisplay1.Text);

            Button button = (Button)sender;
            operacion = button.Text;
            enterValue = true;

            if (textDisplay1.Text != "0")
            {
                // Ajusta el texto del display para mostrar solo "^" en lugar de "x^y"
                if (operacion == "x^y")
                {
                    textDisplay2.Text = $"{resultado} ^"; // Solo muestra "^"
                }
                else
                {
                    textDisplay2.Text = primerNumero = $"{resultado} {operacion}";
                }
                if (operacion == "y√x")
                {
                    textDisplay2.Text = $"√{resultado} "; // Solo muestra "^"
                }
                else
                {
                    textDisplay2.Text = primerNumero = $"{resultado} {operacion}";
                }
                textDisplay1.Text = string.Empty;
            }

        }

        private void BtnEqual_Click(object sender, EventArgs e)
        {
            segundoNumero = textDisplay1.Text;
            textDisplay2.Text = $"{textDisplay2.Text} {textDisplay1.Text}";

            if (textDisplay1.Text != string.Empty)
            {
                if (textDisplay1.Text == "0") textDisplay2.Text = string.Empty;

                switch (operacion)
                {
                    case "+":
                        textDisplay1.Text = (resultado + Double.Parse(textDisplay1.Text)).ToString();
                        RtBoxDisplayHistory.AppendText($"{primerNumero} + {segundoNumero} = {textDisplay1.Text} \n");
                        break;
                    case "-":
                        textDisplay1.Text = (resultado - Double.Parse(textDisplay1.Text)).ToString();
                        RtBoxDisplayHistory.AppendText($"{primerNumero} - {segundoNumero} = {textDisplay1.Text} \n");
                        break;
                    case "×":
                        textDisplay1.Text = (resultado * Double.Parse(textDisplay1.Text)).ToString();
                        RtBoxDisplayHistory.AppendText($"{primerNumero} × {segundoNumero} = {textDisplay1.Text} \n");
                        break;
                    case "∕":
                        textDisplay1.Text = (resultado / Double.Parse(textDisplay1.Text)).ToString();
                        RtBoxDisplayHistory.AppendText($"{primerNumero} ∕ {segundoNumero} = {textDisplay1.Text} \n");
                        break;
                    case "x^y":
                        if (Double.TryParse(textDisplay1.Text, out double exponente))
                        {
                            textDisplay1.Text = Math.Pow(resultado, exponente).ToString();
                            RtBoxDisplayHistory.AppendText($"{resultado} ^ {exponente} = {textDisplay1.Text} \n");
                        }
                        else
                        {
                            textDisplay2.Text = "Error: Ingrese un exponente válido";
                        }
                        break;
                    case "y√x":
                        if (double.TryParse(textDisplay1.Text, out double y) && resultado != 0)
                        {
                            double x = resultado; // `resultado` es `x`
                            double raizY = Math.Pow(x, 1.0 / y); // Calcular la raíz `y`-ésima de `x`
                            double resultadoFinal = Math.Round(raizY, 10); // Solo necesitamos la raíz `y`-ésima
                            textDisplay1.Text = resultadoFinal.ToString();
                            textDisplay2.Text = $"{y}√({x})";
                            RtBoxDisplayHistory.AppendText($"√[{y}]({x}) = {textDisplay1.Text}\n");
                        }
                        else
                        {
                            textDisplay2.Text = "Error: Ingrese valores válidos";
                        }
                        break;
                    case "EXP":
                        if (Double.TryParse(textDisplay1.Text, out double expo))
                        {
                            // Calcula baseNum * 10^exponente
                            double expResult = resultado * Math.Pow(10, expo);
                            textDisplay1.Text = expResult.ToString("G10"); // Muestra el resultado en formato científico
                            RtBoxDisplayHistory.AppendText($"{resultado}e+{expo} = {textDisplay1.Text} \n");
                        }
                        else
                        {
                            textDisplay2.Text = "Error: Ingrese un número válido";
                        }
                        break;

                }

                resultado = Double.Parse(textDisplay1.Text);
                operacion = string.Empty;
            }
        }
        private void botonHistorial_Click(object sender, EventArgs e)
        {
            panelHistorial.Height = (panelHistorial.Height == 5) ? panelHistorial.Height = 345 : 5;
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            textDisplay1.Text = "0";
            textDisplay2.Text = string.Empty;
            resultado = 0;
        }

        private void botonLimpiarHistorial_Click(object sender, EventArgs e)
        {
            RtBoxDisplayHistory.Clear();
            if (RtBoxDisplayHistory.Text == string.Empty)
            {
                RtBoxDisplayHistory.Text = " ";
            }
        }

        private void BtnCE_Click(object sender, EventArgs e)
        {
            textDisplay1.Text = "0";
        }

        private void BtnOperacionesAvanzadas(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operacion = button.Text;
            switch (operacion)
            {
                case "√×":
                    textDisplay2.Text = $"√({textDisplay1.Text})";
                    textDisplay1.Text = Convert.ToString(Math.Sqrt(Double.Parse(textDisplay1.Text)));
                    break;
                case "ˆ2":
                    textDisplay2.Text = $"({textDisplay1.Text})ˆ2";
                    textDisplay1.Text = Convert.ToString(Convert.ToDouble(textDisplay1.Text) * Convert.ToDouble(textDisplay1.Text));
                    break;
                case "⅓":
                    textDisplay2.Text = $"({textDisplay1.Text})⅓";
                    textDisplay1.Text = Convert.ToString(1.0 / Convert.ToDouble(textDisplay1.Text));
                    break;
                case "%":
                    textDisplay2.Text = $"%({textDisplay1.Text})";
                    textDisplay1.Text = Convert.ToString(Convert.ToDouble(textDisplay1.Text) / Convert.ToDouble(100));
                    break;
                case "±":
                    textDisplay2.Text = $"(-1)({textDisplay1.Text})";
                    textDisplay1.Text = Convert.ToString(-1 * Convert.ToDouble(textDisplay1.Text));
                    break;
                case "3√×":
                    // Operación de raíz cúbica
                    textDisplay2.Text = $"3√({textDisplay1.Text})";
                    textDisplay1.Text = Convert.ToString(Math.Pow(Double.Parse(textDisplay1.Text), 1.0 / 3.0));
                    break;
                case "xˆ3":
                    textDisplay2.Text = $"({textDisplay1.Text})ˆ3";
                    double baseNumber = Convert.ToDouble(textDisplay1.Text);
                    textDisplay1.Text = Math.Pow(baseNumber, 3).ToString("G10"); // Eleva a la 3ª potencia y redondea a 10 decimales
                    RtBoxDisplayHistory.AppendText($"{baseNumber} ^ 3 = {textDisplay1.Text}\n");
                    break;
                case "10ˆx":
                    Double exponente = Convert.ToDouble(textDisplay1.Text);
                    textDisplay2.Text = $"{10}ˆ({exponente})";
                    textDisplay1.Text = Math.Pow(10, exponente).ToString("G10");
                    break;
                case "EXP":
                    if (Double.TryParse(textDisplay1.Text, out double baseNum))
                    {
                        // Guarda la base ingresada por el usuario
                        resultado = baseNum;

                        // Prepara el display para que el usuario ingrese el exponente
                        textDisplay2.Text = $"{baseNum}e+";
                        textDisplay1.Text = string.Empty; // Limpia la entrada para el exponente
                    }
                    else
                    {
                        textDisplay2.Text = "Error: Ingrese un número válido para EXP";
                    }
                    break;

            }
            RtBoxDisplayHistory.AppendText($"{textDisplay2.Text} = {textDisplay1.Text}\n");
        }

        private void BtnOperacionesCientificas(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operacion = button.Text;

            try
            {
                switch (operacion)
                {
                    case "sin":
                        textDisplay2.Text = $"sin({textDisplay1.Text})";
                        textDisplay1.Text = Convert.ToString(Math.Sin(Double.Parse(textDisplay1.Text) * Math.PI / 180));
                        break;
                    case "cos":
                        textDisplay2.Text = $"cos({textDisplay1.Text})";
                        double grados = Double.Parse(textDisplay1.Text);
                        double radianes = grados * (Math.PI / 180); // Convertir grados a radianes
                        double resultadoCoseno = Math.Cos(radianes);

                        // Definir un umbral pequeño para manejar la precisión de punto flotante
                        const double epsilon = 1e-10;
                        resultadoCoseno = Math.Abs(resultadoCoseno) < epsilon ? 0 : resultadoCoseno;

                        textDisplay1.Text = Math.Round(resultadoCoseno, 10).ToString(); // Redondear a 10 decimales
                        break;
                    case "tan":
                        textDisplay2.Text = $"tan({textDisplay1.Text})";
                        textDisplay1.Text = Convert.ToString(Math.Tan(Double.Parse(textDisplay1.Text) * Math.PI / 180));
                        break;
                    case "log":
                        textDisplay2.Text = $"log({textDisplay1.Text})";
                        if (Double.Parse(textDisplay1.Text) > 0)
                        {
                            textDisplay1.Text = Math.Log10(Double.Parse(textDisplay1.Text)).ToString();
                        }
                        else
                        {
                            MessageBox.Show("El logaritmo no está definido para números menores o iguales a cero.");
                            textDisplay1.Text = "Error";
                        }
                        break;
                    default:
                        MessageBox.Show("Operación desconocida.");
                        break;
                }
                RtBoxDisplayHistory.AppendText($"{textDisplay2.Text} = {textDisplay1.Text}\n");
            }
            catch (FormatException)
            {
                MessageBox.Show("Entrada inválida. Por favor, introduzca un número válido.");
            }
        }

        private void BtnBorrar_Click_Click(object sender, EventArgs e)
        {
            if (textDisplay1.Text.Length > 0)
                textDisplay1.Text = textDisplay1.Text.Remove(textDisplay1.Text.Length - 1, 1);
            if (textDisplay1.Text == string.Empty) textDisplay1.Text = "0";

        }
    }
}

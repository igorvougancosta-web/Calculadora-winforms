namespace Calculadora_Treinando
{
    public partial class Form1 : Form

    {

        private decimal Resultado { get; set; }
        private decimal Valor { get; set; }



        private Operadores OperadorSelecionado { get; set; }

        private enum Operadores
        {
            Adicao,
            Subtracoa,
            Multiplicacao,
            Divisao,
        }

        public Form1()
        {
            InitializeComponent();


        }


        private void btn1_Click(object sender, EventArgs e)
        {
            rtxResultado.AppendText("1");


        }

        private void btn08_Click(object sender, EventArgs e)
        {


            rtxResultado.AppendText("8");

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            rtxResultado.AppendText("2");

        }

        private void btn3_Click(object sender, EventArgs e)
        {
            rtxResultado.AppendText("3");
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            rtxResultado.AppendText("4");
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            rtxResultado.AppendText("5");
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            rtxResultado.AppendText("6");
        }

        private void btn07_Click(object sender, EventArgs e)
        {
            rtxResultado.AppendText("7");
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            rtxResultado.AppendText("9");
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            rtxResultado.AppendText("0");
        }

        private void btnAdic_Click(object sender, EventArgs e)
        {
            Valor = Convert.ToDecimal(rtxResultado.Text);
            OperadorSelecionado = Operadores.Adicao;
            rtxResultado.Clear();

        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            Valor = Convert.ToDecimal(rtxResultado.Text);
            OperadorSelecionado = Operadores.Subtracoa;
            rtxResultado.Clear();

        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            Valor = Convert.ToDecimal(rtxResultado.Text);
            OperadorSelecionado = Operadores.Multiplicacao;
            rtxResultado.Clear();


        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            Valor = Convert.ToDecimal(rtxResultado.Text);
            OperadorSelecionado = Operadores.Divisao;
            rtxResultado.Clear();

        }

        private void btnCalc_Click(object sender, EventArgs e)
        {

            switch (OperadorSelecionado)
            {
                case Operadores.Adicao:
                    Resultado = Valor + Convert.ToDecimal(rtxResultado.Text);
                    break;

                case Operadores.Divisao:
                    Resultado = Valor / Convert.ToDecimal(rtxResultado.Text);
                    break;

                case Operadores.Multiplicacao:
                    Resultado = Valor * Convert.ToDecimal(rtxResultado.Text);
                    break;

                case Operadores.Subtracoa:
                    Resultado = Valor - Convert.ToDecimal(rtxResultado.Text);
                    break;
            }

            rtxResultado.Text = Convert.ToString(Resultado);

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            rtxResultado.Text = ("");
        }
    }
}

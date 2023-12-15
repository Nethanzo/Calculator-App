namespace Calculator_App
{
    public partial class Form1 : Form
    {

        Double resultValue = 0;
        String operationTodo = "";
        bool isOperationPerformed = false;
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "0") || (isOperationPerformed))
                textBox1.Clear();
            isOperationPerformed = false;
            Button button = (Button)sender;

            if (button.Text == ".") {
                if(!textBox1.Text.Contains(".")) {
                    textBox1.Text = textBox1.Text + button.Text;
                }

            }else
                textBox1.Text = textBox1.Text + button.Text;
            // currentStatelable.Text = currentStatelable.Text + button.Text;
        }

        private void Operator_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (resultValue != 0)
            {

                Result.PerformClick();
                operationTodo = button.Text;
                currentStatelable.Text = resultValue + " " + operationTodo;
                isOperationPerformed = true;
            }
            else
            {
                operationTodo = button.Text;
                resultValue = Double.Parse(textBox1.Text);
                currentStatelable.Text = resultValue + " " + operationTodo;
                isOperationPerformed = true;
            }

        }

        private void clear_Enitiy(object sender, EventArgs e)
        {
            textBox1.Text = "0";

        }

        private void clear_All(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            resultValue = 0;
            
        }

        private void result_Click(object sender, EventArgs e)
        {
            switch (operationTodo)
            {
                case "+":
                    textBox1.Text = (resultValue + Double.Parse(textBox1.Text)).ToString();
                    break;
                case "-":
                    textBox1.Text = (resultValue - Double.Parse(textBox1.Text)).ToString();
                    break;
                case "*":
                    textBox1.Text = (resultValue * Double.Parse(textBox1.Text)).ToString();
                    break;
                case "/":
                    textBox1.Text = (resultValue / Double.Parse(textBox1.Text)).ToString();
                    break;
                default:
                    break;

            }
            resultValue = Double.Parse(textBox1.Text);
            currentStatelable.Text = "";
        }
    }
}
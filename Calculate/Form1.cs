namespace Calculate
{
    public partial class Calculate : Form
    {
        public double value1 = 1;
        public double value2 = 1;
        public string operators="";
        public Calculate()
        {
            InitializeComponent();
            buttonEqual.Enabled = false;
        }

       

        void input(string number )
        {
            inputText.Text=inputText.Text + "" + number;
        }

        void disableButton()
        {
            buttonDiv.Enabled = false;
            buttonMultiple.Enabled = false;
            buttonplus.Enabled = false;
            buttonMinus.Enabled = false;
        }

        void enableButton()
        {
            buttonDiv.Enabled = true;
            buttonMultiple.Enabled = true;
            buttonplus.Enabled = true;
            buttonMinus.Enabled = true;
        }

     

        private void button1_Click(object sender, EventArgs e)
        {
            input("1");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            input("2");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            input("3");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            input("4");

        }

        private void button5_Click(object sender, EventArgs e)
        {
            input("5");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            input("6");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            input("7");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            input("8");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            input("9");
        }

        private void buttonDiv_Click(object sender, EventArgs e)
        {
            input("/");
            disableButton(); 
            operators = "/";
            buttonEqual.Enabled = true;
        }

        private void buttonMultiple_Click(object sender, EventArgs e)
        {
            input("*");
            disableButton();
            operators = "*";
            buttonEqual.Enabled = true;
        }

        private void buttonplus_Click(object sender, EventArgs e)
        {
            input("+");
            disableButton();
            operators = "+";
            buttonEqual.Enabled = true;
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
           
            input("-");
            disableButton();
            operators = "-";
            buttonEqual.Enabled = true;
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            String[] split = inputText.Text.Split(operators);
            if (split[0] != "")
             value1 = double.Parse(split[0]);
            if(split[1]!="")
            value2 = double.Parse(split[1]);
            double result = 0;
            switch (operators)
            {
                case "+":
                    result=(double)(value1 +value2);
                    break;
                case "-":
                    result = (double)(value1 - value2);
                    break;
                case "/":
                    result = (double)(value1 / value2);
                    break;
                case "*":
                    result = (double)(value1 * value2);
                    break;
                default:
                    result = 0;
                    break;
            }
           
            inputResult.Text= inputText.Text + " = " + result;
            enableButton();
            value1 = 1;
            value2 = 1;
            operators = "";
            inputText.Text = "";
            buttonEqual.Enabled = false;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            inputResult.Text = "0";
            enableButton();
            value1 = 1;
            value2 = 1;
            operators = "";
            inputText.Text = "";
            buttonEqual.Enabled = false;
        }
    }
}
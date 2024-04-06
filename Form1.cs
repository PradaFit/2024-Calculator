//Made By PradaFit

namespace _2024_Calculator
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            this.FormClosing += Main_FormClosing;
        }

        string CalTotal;
        decimal num1 = 0;
        decimal num2 = 0;
        string option;
        decimal result = 0;

        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);

            switch (e.KeyCode)
            {
                case Keys.NumPad1:
                case Keys.D1:
                    btn1.PerformClick();
                    break;
                case Keys.NumPad2:
                case Keys.D2:
                    btn2.PerformClick();
                    break;
                case Keys.NumPad3:
                case Keys.D3:
                    btn3.PerformClick();
                    break;
                case Keys.NumPad4:
                case Keys.D4:
                    btn4.PerformClick();
                    break;
                case Keys.NumPad5:
                case Keys.D5:
                    btn5.PerformClick();
                    break;
                case Keys.NumPad6:
                case Keys.D6:
                    btn6.PerformClick();
                    break;
                case Keys.NumPad7:
                case Keys.D7:
                    btn7.PerformClick();
                    break;
                case Keys.NumPad8:
                case Keys.D8:
                    btn8.PerformClick();
                    break;
                case Keys.NumPad9:
                case Keys.D9:
                    btn9.PerformClick();
                    break;
                case Keys.NumPad0:
                case Keys.D0:
                    btn0.PerformClick();
                    break;
                case Keys.Add:
                    btnPlus.PerformClick();
                    break;
                case Keys.Subtract:
                    btnMinus.PerformClick();
                    break;
                case Keys.Multiply:
                    btnMultiply.PerformClick();
                    break;
                case Keys.Divide:
                    btnDivide.PerformClick();
                    break;
                case Keys.Decimal:
                    btnDec.PerformClick();
                    break;
                case Keys.Enter:
                    btnEqu.PerformClick();
                    e.Handled = true; // To prevent the beep sound when Enter is pressed
                    break;
                case Keys.Escape:
                    btnClear.PerformClick();
                    break;
                case Keys.Back:
                    btnDel.PerformClick();
                    break;
                    // Add cases for other keys as needed...
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + btn1.Text;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + btn2.Text;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + btn3.Text;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + btn4.Text;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + btn5.Text;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + btn6.Text;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + btn7.Text;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + btn8.Text;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + btn9.Text;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + btn0.Text;
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            option = "+";
            // Safely parse the text to a decimal number
            if (decimal.TryParse(txtTotal.Text, out num1))
            {
                txtTotal.Clear();
            }
            else
            {
                // B/c you know
                MessageBox.Show("Please enter a valid number.");
            }
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            option = "-";
            num1 = int.Parse(txtTotal.Text);

            txtTotal.Clear();
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            option = "X";
            // Use decimal.TryParse to safely parse the text input as a decimal
            if (decimal.TryParse(txtTotal.Text, out num1))
            {
                txtTotal.Clear();
            }
            else
            {
                // If parsing fails, perhaps due to invalid input, notify the user
                MessageBox.Show("Please enter a valid number.");
            }
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            option = "÷";
            // Use decimal.TryParse to safely parse the text input
            if (decimal.TryParse(txtTotal.Text, out num1))
            {
                txtTotal.Clear();
            }
            else
            {
                // Optionally handle the error if parsing fails
                MessageBox.Show("Please enter a valid number.");
            }
        }

        private void btnEqu_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtTotal.Text, out num2))
            {
                switch (option)
                {
                    case "+":
                        result = num1 + num2;
                        break;
                    case "-":
                        result = num1 - num2;
                        break;
                    case "X":
                        result = num1 * num2;
                        break;
                    case "÷":
                        if (num2 != 0)
                        {
                            result = num1 / num2;
                        }
                        else
                        {
                            txtTotal.Text = "-_- Bruh";
                            return;
                        }
                        break;
                        // Add cases for other operations like percentage, square root, etc.
                }

                txtTotal.Text = result.ToString();
                num1 = result; // Store the result in case of consecutive calculations
            }
            else
            {
                MessageBox.Show("Please enter a valid number.");
            }
        }

        private void btnClear_Click(object sender, EventArgs e) // Clears the total
        {
            txtTotal.Clear();
        }

        private void btnClrCurnt_Click(object sender, EventArgs e) //sets current number to 0
        {
            txtTotal.Text = "0";
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtTotal.Text))
            {
                txtTotal.Text = txtTotal.Text.Substring(0, txtTotal.Text.Length - 1);
            }
        }

        private void btnDec_Click(object sender, EventArgs e)
        {
            if (!txtTotal.Text.Contains("."))
            {
                if (string.IsNullOrEmpty(txtTotal.Text))
                {
                    txtTotal.Text = "0";
                }

                txtTotal.Text += ".";
            }
        }

        private void btnNeg_Click(object sender, EventArgs e)
        {
            // Check if the textbox isn't empty and contains a valid decimal number
            if (decimal.TryParse(txtTotal.Text, out decimal currentValue))
            {
                // Multiply by -1 to toggle the sign
                currentValue *= -1;

                // Update the textbox with the new value
                txtTotal.Text = currentValue.ToString();
            }
            else if (!string.IsNullOrEmpty(txtTotal.Text))
            {
                // Handle the case where the text is not a valid number
                MessageBox.Show("Please enter a valid number.");
            }
        }

        private void btnPerc_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtTotal.Text, out decimal currentValue))
            {
                // If an operation was recently set, calculate the percentage of num1
                if (!string.IsNullOrEmpty(option))
                {
                    currentValue = (num1 * currentValue) / 100;
                }
                else // Otherwise, just convert the current value to a percentage
                {
                    currentValue /= 100;
                }

                txtTotal.Text = currentValue.ToString();
            }
            else if (!string.IsNullOrEmpty(txtTotal.Text))
            {
                MessageBox.Show("Please enter a valid number.");
            }
        }

        private void btnSquared_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtTotal.Text, out decimal currentValue))
            {
                // Square the value
                decimal squaredValue = currentValue * currentValue;

                // Update the textbox with the squared value
                txtTotal.Text = squaredValue.ToString();
            }
            else if (!string.IsNullOrEmpty(txtTotal.Text))
            {
                // If there's some error parsing the value, show a message.
                // This could happen if the text box is empty or contains non-numeric symbols
                MessageBox.Show("Please enter a valid number.");
            }
        }

        private void btnSqrt_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtTotal.Text, out decimal currentValue))
            {
                // Convert currentValue to double for Math.Sqrt, which does not accept decimal
                double sqrtValue = Math.Sqrt((double)currentValue);

                // Update the textbox with the square root value
                // Convert back to decimal if maintaining consistency with decimal type
                txtTotal.Text = ((decimal)sqrtValue).ToString();
            }
            else if (!string.IsNullOrEmpty(txtTotal.Text))
            {
                // If there's some error parsing the value, show a message.
                // This could happen if the textbox is empty or contains non-numeric symbols
                MessageBox.Show("Please enter a valid number.");
            }
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Yo yo
            string url = "https://github.com/PradaFit";

            try
            {
                // Open the URL in the default web browser
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true // This is required for .NET Core and later versions
                });
            }
            catch (Exception ex)
            {
                // In case of an error, show a message box
                MessageBox.Show("Failed to open the link: " + ex.Message);
            }

            // This message will show just before the form closes
            MessageBox.Show("Made By PradaFit");
        }
    }
}
namespace WinForms.CalulateArea
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Hi Bro!!!", "!!!Welcome Text!!!",
            MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure to close me?", "The Program",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnCircleArea_Click(object sender, EventArgs e)
        {
            double Radius = 0;
            if (double.TryParse(txtRadius.Text, out Radius) == false)
            {
                MessageBox.Show("Please input only number.", " !!! Error !!! ");
                return;
            }
            double CircleArea = Math.PI * Math.Pow(Radius, 2);
            lblResult.Text = CircleArea.ToString("0.00");

            txtRadius.Focus();
            txtRadius.SelectAll();
        }

        private void btnTriangleArea_Click(object sender, EventArgs e)
        {
            double THeight = 0;
            double TBase = 0;
            if (double.TryParse(txtHeight.Text, out THeight) == false)
            {
                MessageBox.Show("Please input only number.", " !!! Error !!! ");
                return;
            }
            if (double.TryParse(txtWidth.Text, out TBase) == false)
            {
                MessageBox.Show("Please input only number.", " !!! Error !!! ");
                return;
            }
            double TriArea = 0.5 * TBase * THeight;
            lblResult.Text = TriArea.ToString("0.00");

            txtRadius.Focus();
            txtRadius.SelectAll();
        }

        private void btnHexagonArea_Click(object sender, EventArgs e)
        {
            double HexW = 0;
            if (double.TryParse(txtHexagonWidth.Text, out HexW) == false)
            {
                MessageBox.Show("Please input only number.", " !!! Error !!! ");
                return;
            }
            double HexArea = (3 * Math.Sqrt(3) * Math.Pow(HexW, 2)) / 2;
            lblResult.Text = HexArea.ToString("0.00");

            txtRadius.Focus();
            txtRadius.SelectAll();
        }
    }
}

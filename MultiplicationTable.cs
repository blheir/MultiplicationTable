namespace MultiplicationTable
{
    public partial class MultiplicationTable : Form
    {
        public MultiplicationTable()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(userInteger.Text, out int multiplier))
            {
                resultsBox.Items.Clear();

                for (int i = 1; i <= 10; i++)
                {
                    resultsBox.Items.Add($"{i} * {multiplier} = {i * multiplier}");
                }
            }
            else
            {
                MessageBox.Show("Sorry. Please enter a valid integer!");
            }
        }
    }
}

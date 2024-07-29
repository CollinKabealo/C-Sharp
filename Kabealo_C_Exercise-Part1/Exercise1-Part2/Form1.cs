namespace Exercise1_Part2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculateCost_Click(object sender, EventArgs e)
        {
            try
            {
                const double INSTALLATION_COST_PER_HOUR = 35.75;
                const double SQ_FT_PER_HOUR = 40;

                if (!int.TryParse(txtLength.Text, out int length))
                {
                    MessageBox.Show("Please enter a valid length.");
                    return;
                }

                if (!int.TryParse(txtWidth.Text, out int width))
                {
                    MessageBox.Show("Please enter a valid width.");
                    return;
                }

                if (!double.TryParse(txtCostPerSqFt.Text, out double costPerSqFt))
                {
                    MessageBox.Show("Please enter a valid cost per square foot.");
                    return;
                }

                double totalArea = length * width;
                double flooringCost = totalArea * costPerSqFt;
                double hoursToInstall = totalArea / SQ_FT_PER_HOUR;
                double installationCost = hoursToInstall * INSTALLATION_COST_PER_HOUR;

                lblFloorSizeCost.Text = $"Cost of total floor size of {totalArea}: ${flooringCost:0.00}";
                lblInstallationHoursCost.Text = $"Number of hours to install the floor: {hoursToInstall:0.00} At a cost of: ${installationCost:0.00}";
                lblTotalCost.Text = $"The total finished cost for the new floor is: ${flooringCost + installationCost:0.00}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}. Please check your input and try again.");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
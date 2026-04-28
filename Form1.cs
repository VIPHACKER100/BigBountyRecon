using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BigBountyRecon
{
    /// <summary>
    /// Main form for the BigBountyRecon reconnaissance tool.
    /// This form provides access to 58 different reconnaissance techniques using Google dorks and open-source tools.
    /// Upgraded and maintained by VIPHACKER100
    /// </summary>
    public partial class Form1 : Form
    {
        private Dictionary<string, SearchQuery> searchQueries;

        /// <summary>
        /// Initializes a new instance of the Form1 class.
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            InitializeSearchQueries();
        }

        /// <summary>
        /// Initializes the search query dictionary and populates button UI.
        /// </summary>
        private void InitializeSearchQueries()
        {
            searchQueries = ReconSearchProvider.GetSearchQueries();

            // Populate button text and add hover effects
            foreach (var entry in searchQueries)
            {
                string buttonName = entry.Key;
                SearchQuery query = entry.Value;

                System.Reflection.FieldInfo field = this.GetType().GetField(buttonName, 
                    System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
                
                if (field != null)
                {
                    if (field.GetValue(this) is Button button)
                    {
                        button.Text = query.Name;
                        
                        // Add hover effects
                        button.MouseEnter += (s, e) => {
                            button.BackColor = System.Drawing.Color.FromArgb(0, 122, 204);
                            button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(0, 150, 255);
                        };
                        button.MouseLeave += (s, e) => {
                            button.BackColor = System.Drawing.Color.FromArgb(45, 45, 48);
                            button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(64, 64, 64);
                        };
                    }
                }
            }
        }

        /// <summary>
        /// Generic button click handler for all reconnaissance search buttons.
        /// Routes the click to the appropriate search based on the sender's name.
        /// </summary>
        /// <param name="sender">The button that was clicked</param>
        /// <param name="e">Event arguments</param>
        private void GenericButtonClick(object sender, EventArgs e)
        {
            if (!(sender is Button button))
                return;

            string buttonName = button.Name;

            // Validate that we have a target domain
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show(
                    "Please enter a target domain or organization name.",
                    "Input Required",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            // Look up the search query for this button
            if (searchQueries.ContainsKey(buttonName))
            {
                SearchQuery query = searchQueries[buttonName];
                SearchQueryBuilder.BuildAndExecuteSearch(query.UrlTemplate, textBox1.Text);
            }
            else
            {
                MessageBox.Show(
                    $"Search query not found for {buttonName}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // Button click handlers - All routed to GenericButtonClick
        private void button1_Click(object sender, EventArgs e) => GenericButtonClick(sender, e);
        private void button2_Click(object sender, EventArgs e) => GenericButtonClick(sender, e);
        private void button3_Click(object sender, EventArgs e) => GenericButtonClick(sender, e);
        private void button4_Click(object sender, EventArgs e) => GenericButtonClick(sender, e);
        private void button5_Click(object sender, EventArgs e) => GenericButtonClick(sender, e);
        private void button6_Click(object sender, EventArgs e) => GenericButtonClick(sender, e);
        private void button7_Click(object sender, EventArgs e) => GenericButtonClick(sender, e);
        private void button8_Click(object sender, EventArgs e) => GenericButtonClick(sender, e);
        private void button9_Click(object sender, EventArgs e) => GenericButtonClick(sender, e);
        private void button10_Click(object sender, EventArgs e) => GenericButtonClick(sender, e);
        private void button11_Click(object sender, EventArgs e) => GenericButtonClick(sender, e);
        private void button12_Click(object sender, EventArgs e) => GenericButtonClick(sender, e);
        private void button13_Click(object sender, EventArgs e) => GenericButtonClick(sender, e);
        private void button14_Click(object sender, EventArgs e) => GenericButtonClick(sender, e);
        private void button15_Click(object sender, EventArgs e) => GenericButtonClick(sender, e);
        private void button16_Click(object sender, EventArgs e) => GenericButtonClick(sender, e);
        private void button17_Click(object sender, EventArgs e) => GenericButtonClick(sender, e);
        private void button18_Click(object sender, EventArgs e) => GenericButtonClick(sender, e);
        private void button19_Click(object sender, EventArgs e) => GenericButtonClick(sender, e);
        private void button20_Click(object sender, EventArgs e) => GenericButtonClick(sender, e);
        private void button21_Click(object sender, EventArgs e) => GenericButtonClick(sender, e);
        private void button22_Click(object sender, EventArgs e) => GenericButtonClick(sender, e);
        private void button23_Click(object sender, EventArgs e) => GenericButtonClick(sender, e);
        private void button24_Click(object sender, EventArgs e) => GenericButtonClick(sender, e);
        private void button25_Click(object sender, EventArgs e) => GenericButtonClick(sender, e);
        private void button26_Click(object sender, EventArgs e) => GenericButtonClick(sender, e);
        private void button27_Click(object sender, EventArgs e) => GenericButtonClick(sender, e);
        private void button28_Click(object sender, EventArgs e) => GenericButtonClick(sender, e);
        private void button29_Click(object sender, EventArgs e) => GenericButtonClick(sender, e);
        private void button30_Click(object sender, EventArgs e) => GenericButtonClick(sender, e);
        private void button31_Click(object sender, EventArgs e) => GenericButtonClick(sender, e);
        private void button32_Click(object sender, EventArgs e) => GenericButtonClick(sender, e);
        private void button33_Click(object sender, EventArgs e) => GenericButtonClick(sender, e);
        private void button34_Click(object sender, EventArgs e) => GenericButtonClick(sender, e);
        private void button35_Click(object sender, EventArgs e) => GenericButtonClick(sender, e);
        private void button36_Click(object sender, EventArgs e) => GenericButtonClick(sender, e);
        private void button37_Click(object sender, EventArgs e) => GenericButtonClick(sender, e);
        private void button38_Click(object sender, EventArgs e) => GenericButtonClick(sender, e);
        private void button39_Click(object sender, EventArgs e) => GenericButtonClick(sender, e);
        private void button40_Click(object sender, EventArgs e) => GenericButtonClick(sender, e);
        private void button41_Click(object sender, EventArgs e) => GenericButtonClick(sender, e);
        private void button42_Click(object sender, EventArgs e) => GenericButtonClick(sender, e);
        private void button43_Click(object sender, EventArgs e) => GenericButtonClick(sender, e);
        private void button44_Click(object sender, EventArgs e) => GenericButtonClick(sender, e);
        private void button45_Click(object sender, EventArgs e) => GenericButtonClick(sender, e);
        private void button46_Click(object sender, EventArgs e) => GenericButtonClick(sender, e);
        private void button47_Click(object sender, EventArgs e) => GenericButtonClick(sender, e);
        private void button48_Click(object sender, EventArgs e) => GenericButtonClick(sender, e);
        private void button49_Click(object sender, EventArgs e) => GenericButtonClick(sender, e);
        private void button50_Click(object sender, EventArgs e) => GenericButtonClick(sender, e);
        private void button51_Click(object sender, EventArgs e) => GenericButtonClick(sender, e);
        private void button52_Click(object sender, EventArgs e) => GenericButtonClick(sender, e);
        private void button53_Click(object sender, EventArgs e) => GenericButtonClick(sender, e);
        private void button54_Click(object sender, EventArgs e) => GenericButtonClick(sender, e);
        private void button55_Click(object sender, EventArgs e) => GenericButtonClick(sender, e);
        private void button56_Click(object sender, EventArgs e) => GenericButtonClick(sender, e);
        private void button57_Click(object sender, EventArgs e) => GenericButtonClick(sender, e);
        private void button58_Click(object sender, EventArgs e) => GenericButtonClick(sender, e);
        private void button59_Click(object sender, EventArgs e) => GenericButtonClick(sender, e);
        private void button60_Click(object sender, EventArgs e) => GenericButtonClick(sender, e);
        private void button61_Click(object sender, EventArgs e) => GenericButtonClick(sender, e);
        private void button62_Click(object sender, EventArgs e) => GenericButtonClick(sender, e);
        private void button63_Click(object sender, EventArgs e) => GenericButtonClick(sender, e);
        private void button64_Click(object sender, EventArgs e) => GenericButtonClick(sender, e);
        private void button65_Click(object sender, EventArgs e) => GenericButtonClick(sender, e);
        private void button66_Click(object sender, EventArgs e) => GenericButtonClick(sender, e);

        /// <summary>
        /// Performs a high-value reconnaissance scan using the top 5 most useful techniques.
        /// </summary>
        private void top5Button_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Please enter a target domain.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string[] top5 = { "button9", "button59", "button60", "button25", "button39" };
            
            foreach (string btnName in top5)
            {
                if (searchQueries.ContainsKey(btnName))
                {
                    SearchQuery query = searchQueries[btnName];
                    SearchQueryBuilder.BuildAndExecuteSearch(query.UrlTemplate, textBox1.Text);
                    // Small delay to avoid browser congestion if needed, but Process.Start is usually fine
                }
            }
        }

        /// <summary>
        /// Clears the target domain textbox.
        /// </summary>
        private void clearButton_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox1.Focus();
        }

        /// <summary>
        /// Opens the creator's Twitter profile.
        /// </summary>
        private void label1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://twitter.com/ManiarViral/");
        }
    }
}

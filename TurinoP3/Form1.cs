using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TurinoP3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                // Convert input from form to appropriate data types
                int numItems = int.TryParse(txtNumberOfItems.Text, out int n) ? n : 0; // Parsing
                bool hasLogo = cbLogo.Checked;
                int numColors = hasLogo && int.TryParse(txtNumberOfColors.Text, out int c) ? c : 0; // Only parse if hasLogo is true

                // Determine item type based on checked RadioButton
                string itemType = rbPen.Checked ? "pen" : rbMug.Checked ? "mug" : "usb";

                // Instantiate LogoOrderItem and set its properties
                LogoOrderItem orderItem = new LogoOrderItem
                {
                    ItemType = itemType,
                    NumItems = numItems,
                    HasLogo = hasLogo,
                    NumColors = numColors,
                    Text = txtTextToEngrave.Text
                };

                // Calculate and display order summary
                txtOrderSummary.Text = orderItem.GetOrderSummary();
            }
            catch (Exception ex)
            {
                // Handle any errors
                txtOrderSummary.Text = $"Error: {ex.Message}";
            }
        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            // Reset to default
            txtOrderNumber.Text = "";
            txtNumberOfItems.Text = "";
            rbPen.Checked = true; // Pen selected as default
            txtTextToEngrave.Text = "";
            cbLogo.Checked = false;
            txtNumberOfColors.Text = "";
            txtOrderSummary.Text = "";
        }


        private void cbLogo_CheckedChanged(object sender, EventArgs e)
        {
            // Show or hide the number of colors input based on the checkbox state
            lblNumberOfColors.Visible = cbLogo.Checked;
            txtNumberOfColors.Visible = cbLogo.Checked;

            // Optionally reset the number of colors text box when hiding it
            if (!cbLogo.Checked) txtNumberOfColors.Text = "";
        }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary;
using TrackerLibrary.DataAccess;
using TrackerLibrary.Models;

namespace TrackerUI
{
    public partial class CreatePrizeForm : Form
    {
        IPrizeRequester callingForm;
        public CreatePrizeForm(IPrizeRequester caller)
        {
            InitializeComponent();
            callingForm = caller;
        }

        //private void Reset()
        //{
        //    PlaceNameValue.Text = "";
        //    PlaceNumberValue.Text = "";
        //    PrizeAmountValue.Text = "0";
        //    PrizePercentageValue.Text = "0";
        //}
        private void CreatePrizeButton_Click(object sender, EventArgs e)
        {
            int placeNumber = 0;
            decimal prizeAmount = 0;
            double prizePercentage = 0;

            bool placeNumberValidity = int.TryParse(PlaceNumberValue.Text, out placeNumber);
            bool placeNameValidity = !string.IsNullOrEmpty(PlaceNameValue.Text);
            bool prizeAmountValidity = decimal.TryParse(PrizeAmountValue.Text, out prizeAmount);
            bool prizePercentageValidity = double.TryParse(PrizePercentageValue.Text, out prizePercentage);

            bool valid = placeNumberValidity && placeNameValidity && prizeAmountValidity && prizePercentageValidity &&
                placeNumber > 0 && prizeAmount >= 0 && prizePercentage >= 0 && prizePercentage <= 1;
            if (valid)
            {
                PrizeModel model = new PrizeModel
                {
                    PlaceNumber = placeNumber,
                    PlaceName = PlaceNameValue.Text,
                    PrizeAmount = prizeAmount,
                    PrizePercentage = prizePercentage
                };
                GlobalConfig.Connection.CreatePrize(model);
                callingForm.PrizeComplete(model);
                MessageBox.Show("Prize created successfully");
                Close();

                // Reset();
            }
            else
            {
                MessageBox.Show("Invalid information. Please try again");
            }
        }
    }
}

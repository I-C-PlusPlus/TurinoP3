//Turino dturino@cnm.edu
//Program3
//Logo Store

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurinoP3
{
    public class LogoOrderItem
    {
        private bool hasLogo;
        private string itemType;
        private int numColors;
        private int numItems;
        private string text;
        private decimal totalPrice;

        // Auto-Implemented Property for Item ID
        public int ItemID { get; set; }

        // Properties 
        public bool HasLogo
        {
            get { return hasLogo; }
            set { hasLogo = value; Calc(); }
        }

        public string ItemType
        {
            get { return itemType; }
            set { itemType = value; Calc(); }
        }

        public int NumColors
        {
            get { return numColors; }
            set { numColors = value; Calc(); }
        }

        public int NumItems
        {
            get { return numItems; }
            set { numItems = value; Calc(); }
        }

        public string Text
        {
            get { return text; }
            set { text = value; Calc(); }
        }

        // Read-Only Property for Total Price
        public decimal TotalPrice
        {
            get { return totalPrice; }
        }

        // Constructors
        public LogoOrderItem(int itemID, string itemType, int numColors, int numItems, bool hasLogo, string text)
        {
            ItemID = itemID;
            ItemType = itemType;
            NumColors = numColors;
            NumItems = numItems;
            HasLogo = hasLogo;
            Text = text;
        }

        public LogoOrderItem(string text, bool hasLogo) : this(-1, "mug", 0, 0, hasLogo, text) { }

        public LogoOrderItem() : this(-1, "mug", 0, 0, false, "") { }

        // Calculate method
        private void Calc()
        {
            decimal basePrice = 0m;
            switch (itemType.ToLower())
            {
                case "pen":
                    basePrice = 1.00m;
                    break;
                case "mug":
                    basePrice = 3.50m;
                    break;
                case "usb":
                    basePrice = 4.00m;
                    break;
            }

            totalPrice = numItems * basePrice;

            if (!string.IsNullOrEmpty(text))
            {
                totalPrice += numItems * 0.05m; // Price for text
            }

            if (hasLogo)
            {
                totalPrice += numItems * 0.10m; // Price for graphic logo
                totalPrice += numItems * numColors * 0.03m; // Price per color per item
            }
        }

        // GetOrderSummary method
        public string GetOrderSummary()
        {
            return $"Order Summary: {numItems} {itemType}(s) with {(hasLogo ? "a logo" : "no logo")}" +
                   $"{(string.IsNullOrEmpty(text) ? "" : $" and text: '{text}'")} - Total Price: ${totalPrice:F2}";
        }
    }

}

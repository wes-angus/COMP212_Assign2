using CollegeTemplateLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace RestaurantBillCalc
{
    public partial class Form1 : CollegeTemplateForm
    {
        List<FoodItem> beverages = new List<FoodItem>();
        List<FoodItem> apps = new List<FoodItem>();
        List<FoodItem> mains = new List<FoodItem>();
        List<FoodItem> desserts = new List<FoodItem>();
        BindingList<FoodItem> billItems = new BindingList<FoodItem>();
        float subtotal = 0;
        float tax, total;

        public Form1()
        {
            InitializeComponent();

            //List of beverages
            beverages.Add(new FoodItem("", "", 0f));
            beverages.Add(new FoodItem("Soda", "Beverage", 1.95f));
            beverages.Add(new FoodItem ("Tea", "Beverage", 1.5f));
            beverages.Add(new FoodItem("Coffee", "Beverage", 1.25f));
            beverages.Add(new FoodItem("Mineral Water", "Beverage", 2.95f));
            beverages.Add(new FoodItem("Juice", "Beverage", 2.5f));
            beverages.Add(new FoodItem("Milk", "Beverage", 1.5f));
            comboBoxBev.DataSource = beverages;

            //List of appetizers
            apps.Add(new FoodItem("", "", 0f));
            apps.Add(new FoodItem("Buffalo Wings", "Appetizer", 5.95f));
            apps.Add(new FoodItem("Buffalo Fingers", "Appetizer", 6.95f));
            apps.Add(new FoodItem("Potato Skins", "Appetizer", 8.95f));
            apps.Add(new FoodItem("Nachos", "Appetizer", 5.95f));
            apps.Add(new FoodItem("Mushroom Caps", "Appetizer", 10.95f));
            apps.Add(new FoodItem("Shrimp Cocktail", "Appetizer", 12.95f));
            apps.Add(new FoodItem("Chips and Salsa", "Appetizer", 6.95f));
            comboBoxApp.DataSource = apps;

            //List of main courses
            mains.Add(new FoodItem("", "", 0f));
            mains.Add(new FoodItem("Seafood Alfredo", "Main Course", 15.95f));
            mains.Add(new FoodItem("Chicken Alfredo", "Main Course", 13.95f));
            mains.Add(new FoodItem("Chicken Picatta", "Main Course", 13.95f));
            mains.Add(new FoodItem("Turkey Club", "Main Course", 11.95f));
            mains.Add(new FoodItem("Lobster Pie", "Main Course", 19.95f));
            mains.Add(new FoodItem("Prime Rib", "Main Course", 20.95f));
            mains.Add(new FoodItem("Shrimp Scampi", "Main Course", 18.95f));
            mains.Add(new FoodItem("Turkey Dinner", "Main Course", 13.95f));
            mains.Add(new FoodItem("Stuffed Chicken", "Main Course", 14.95f));
            comboBoxMain.DataSource = mains;

            //List of desserts
            desserts.Add(new FoodItem("", "", 0f));
            desserts.Add(new FoodItem("Apple Pie", "Dessert", 5.95f));
            desserts.Add(new FoodItem("Sundae", "Dessert", 3.95f));
            desserts.Add(new FoodItem("Carrot Cake", "Dessert", 5.95f));
            desserts.Add(new FoodItem("Mud Pie", "Dessert", 4.95f));
            desserts.Add(new FoodItem("Apple Crisp", "Dessert", 5.95f));
            comboBoxDessert.DataSource = desserts;

            //List to contain all items in the bill
            dataGridView1.DataSource = billItems;
        }

        private void comboBoxBev_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxBev.SelectedIndex > 0)
            {
                //Add it to the bill
                billItems.Add((FoodItem)comboBoxBev.SelectedItem);
                updateTotal((float)comboBoxBev.SelectedValue);
            }
        }

        private void comboBoxApp_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxApp.SelectedIndex > 0)
            {
                //Add it to the bill
                billItems.Add((FoodItem)comboBoxApp.SelectedItem);
                updateTotal((float)comboBoxApp.SelectedValue);
            }
        }

        private void comboBoxMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxMain.SelectedIndex > 0)
            {
                //Add it to the bill
                billItems.Add((FoodItem)comboBoxMain.SelectedItem);
                updateTotal((float)comboBoxMain.SelectedValue);
            }
        }

        private void comboBoxDessert_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxDessert.SelectedIndex > 0)
            {
                //Add it to the bill
                billItems.Add((FoodItem)comboBoxDessert.SelectedItem);
                updateTotal((float)comboBoxDessert.SelectedValue);
            }
        }

        private void updateTotal(float itemPrice)
        {
            //Add current menu item price to subtotal and update tax and final total
            subtotal += itemPrice;
            subtotalBox.Text = subtotal.ToString("C");
            tax = subtotal * 0.13f;
            total = subtotal + tax;
            taxBox.Text = tax.ToString("C");
            totalBox.Text = total.ToString("C");
        }

        private void clearBill()
        {
            //Clear the bill and set all totals to 0
            billItems.Clear();
            updateTotal(-subtotal);
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            clearBill();
        }

        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            //Update totals when deleting row
            updateTotal(-float.Parse(dataGridView1.SelectedRows[0].Cells[2].Value.ToString()));
        }

        private void checkoutBtn_Click(object sender, EventArgs e)
        {
            //Save copy of bill to text file
            using (StreamWriter file = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + @"\RestaurantBill.txt"))
            {
                int i = 1;
                foreach (FoodItem billItem in billItems)
                {
                    file.WriteLine(i + ": " + billItem.name + " " + billItem.price);
                    i++;
                }
                file.WriteLine("");
                file.WriteLine("Subtotal: " + subtotal.ToString("C"));
                file.WriteLine("Tax: " + tax.ToString("C"));
                file.WriteLine("Total: " + total.ToString("C"));
            }
            MessageBox.Show("Bill saved at " + AppDomain.CurrentDomain.BaseDirectory);
            clearBill();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PoS_small
{
    public partial class Form1 : Form
    {
        private BindingList<Item> items;
        private BindingList<Item> cart;
        private BindingSource itemSrc;
        private BindingSource cartSrc;

        public Form1()
        {
            InitializeComponent();

            items = new BindingList<Item>();
            cart = new BindingList<Item>();

            itemSrc = new BindingSource();
            itemSrc.DataSource = items;
            cartSrc = new BindingSource();
            cartSrc.DataSource = cart;

            cbItems.DataSource = itemSrc;
            dgvSale.DataSource = cartSrc;

            items.Add(new Item("Bread", 2.0m));
            items.Add(new Item("Egg", 0.4m));
            items.Add(new Item("Sardin", 2.5m));
            items.Add(new Item("Banku", 0.5m));
            items.Add(new Item("Tilapia", 1.5m));
        }

        private void btnFinish_Click(object sender, EventArgs e) { Close(); }

        private void btnAdd_Click(object sender, EventArgs e)
        {

           Item selItem = items.ElementAt(cbItems.SelectedIndex);
           int index = cart.IndexOf(selItem);
            


            int qty;
            Int32.TryParse(txtQty.Text.Trim(), out qty);



                if (!cart.Contains(selItem))
                {

                    selItem.Qty = qty;
                    selItem.Total = selItem.Price * qty;

                    cart.Add(selItem);
                }
                else
                {
                    Item item = cart.ElementAt(index);
                    cart.RemoveAt(index);

                    item.Qty += qty;
                    item.Total = item.Price * item.Qty; 


                    cart.Add(item);
                }

                decimal due = 0;

                foreach (Item item in cart)
                    due += item.Total;

                txtDue.Text = due.ToString();


            txtQty.Text = "1";

        }

        private void txtPaid_TextChanged(object sender, EventArgs e)
        {
            decimal due = 0;
            decimal paid = 0;

            decimal.TryParse(txtDue.Text.Trim(), out due);
            decimal.TryParse(txtPaid.Text.Trim(), out paid);

            if (paid != 0)
                txtChange.Text = (paid - due).ToString();
        
        }
    }
}

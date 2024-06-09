using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manager_asm
{
    public class Order  // Changed from internal to public
    {
        private OrderItem[] cart = new OrderItem[100];
        private int itemCount = 0;
        private ListView lstCart;

        public Order(ListView listView)
        {
            lstCart = listView ?? throw new ArgumentNullException(nameof(listView));
            InitializeDataCart();
        }

        // Parameterless constructor
        public Order() { }

        // Method to set the ListView after instantiation
        public void SetListView(ListView listView)
        {
            lstCart = listView ?? throw new ArgumentNullException(nameof(listView));
            InitializeDataCart();
        }

        private void InitializeDataCart()
        {
            lstCart.View = View.Details;
            lstCart.Columns.Clear();
            lstCart.Columns.Add("Item", 120);
            lstCart.Columns.Add("Quantity", 70);
            lstCart.Columns.Add("Price", 70);
            lstCart.Columns.Add("Total", 70);
        }

        public void AddToCart(MenuZ menuItem)
        {
            for (int i = 0; i < itemCount; i++)
            {
                if (cart[i].MenuItem.Item == menuItem.Item)
                {
                    cart[i].Quantity++;
                    DisplayCart();
                    return;
                }
            }

            if (itemCount < cart.Length)
            {
                cart[itemCount++] = new OrderItem { MenuItem = menuItem, Quantity = 1 };
                DisplayCart();

            }
        }

        public bool RemoveFromCart(MenuZ menuItem)
        {
            for (int i = 0; i < itemCount; i++)
            {
                if (cart[i].MenuItem.Item == menuItem.Item)
                {
                    cart[i].Quantity--;
                    if (cart[i].Quantity <= 0)
                    {
                        for (int j = i; j < itemCount - 1; j++)
                        {
                            cart[j] = cart[j + 1];
                        }
                        cart[--itemCount] = null;
                    }
                    DisplayCart();
                    return true;
                }
            }
            return false;
        }

        public void DisplayCart()
        {
            if (lstCart == null)
            {
                throw new InvalidOperationException("ListView not set. Call SetListView before using this method.");
            }

            lstCart.Items.Clear();

            foreach (OrderItem item in cart)
            {
                if (item != null)
                {
                    double itemTotal = item.MenuItem.Price * item.Quantity;
                    ListViewItem listViewItem = new ListViewItem(item.MenuItem.Item);
                    listViewItem.SubItems.Add(item.Quantity.ToString());
                    listViewItem.SubItems.Add(item.MenuItem.Price.ToString("F2"));
                    listViewItem.SubItems.Add(itemTotal.ToString("F2"));
                    lstCart.Items.Add(listViewItem);
                }
            }
        }

        public double CalculateTotal()
        {
            double total = 0;
            for (int i = 0; i < itemCount; i++)
            {
                total += cart[i].MenuItem.Price * cart[i].Quantity;
            }
            return total;
        }

        public void ConfirmPayment()
        {
            itemCount = 0;
            Array.Clear(cart, 0, cart.Length);
        }
    }

    internal class OrderItem
    {
        public MenuZ MenuItem { get; set; }
        public int Quantity { get; set; }
    }
}

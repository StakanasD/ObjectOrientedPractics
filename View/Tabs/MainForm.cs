using ObjectOrientedPractics.Model;
using System.Drawing.Text;

namespace ObjectOrientedPractics
{
    public partial class MainForm : Form
    {

        private Store _store;

        public MainForm()
        {
            InitializeComponent();

            _store = new Store();

            itemsTab1.Items = _store.Items;
            customerTab1.Customers = _store.Customers;

            cartsTab1.Items = _store.Items;
            cartsTab1.Customers = _store.Customers;
            cartsTab1.RefreshData();

            ordersTab1.Customers = _store.Customers;
            ordersTab1.UpdateOrders();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 2)
                cartsTab1.RefreshData();

            if (tabControl1.SelectedIndex == 3)
                ordersTab1.UpdateOrders();
        }

        private void itemsTab1_Load(object sender, EventArgs e)
        {

        }
    }
}

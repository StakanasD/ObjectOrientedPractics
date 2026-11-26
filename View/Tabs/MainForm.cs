using ObjectOrientedPractics.Model;
using System;
using System.Windows.Forms;

namespace ObjectOrientedPractics
{
    /// <summary>
    /// Главное окно приложения.
    /// </summary>
    public partial class MainForm : Form
    {
        private readonly Store _store;

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="MainForm"/>.
        /// </summary>
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
            ordersTab1.RefreshData();

            tabControl1.SelectedIndexChanged -= tabControl1_SelectedIndexChanged;
            itemsTab1.ItemsChanged += ItemsTab1_ItemsChanged;
        }

        private void ItemsTab1_ItemsChanged(object? sender, EventArgs e)
        {
            cartsTab1.RefreshData();
            ordersTab1.RefreshData();
            customerTab1.RefreshDiscounts();
        }

        private void tabControl1_SelectedIndexChanged(object? sender, EventArgs e)
        {
        }
    }
}
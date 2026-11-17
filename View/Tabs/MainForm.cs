using ObjectOrientedPractics.Model;

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
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 2)
            {
                cartsTab1.RefreshData();
            }
            else if (tabControl1.SelectedIndex == 3)
            {
                ordersTab1.RefreshData();
            }
        }
    }
}
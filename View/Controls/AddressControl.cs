using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ObjectOrientedPractics.Model;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class AddressControl : UserControl
    {
        public AddressControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Хранит редактируемый адрес.
        /// </summary>
        private Address _address = new Address();

        /// <summary>
        /// Возвращает и задает отображает и редактируемый адрес.
        /// </summary>
        public Address Address
        {
            get
            {
                UpdateAddress();
                return _address;
            }
            set
            {
                if (value == null)
                    _address = new Address();
                else
                    _address = value;
                UpdateControls();
            }
        }

        /// <summary>
        /// Отображает адрес в полях элемента управления.
        /// </summary>
        private void UpdateControls()
        {
            IndexTextBox.Text = _address.Index.ToString();
            CountryTextBox.Text = _address.Country;
            CityTextBox.Text = _address.City;
            StreetTextBox.Text = _address.Street;
            BuildingTextBox.Text = _address.Building;
            ApartmentTextBox.Text = _address.Apartment;
        }

        /// <summary>
        /// Сохраняет данные из полей в объект адреса.
        /// </summary>
        private void UpdateAddress()
        {
            if (int.TryParse(IndexTextBox.Text, out int index) &&
                index >= 100000 && index <= 999999)
                _address.Index = index;

            if (CountryTextBox.Text.Length <= 50)
                _address.Country = CountryTextBox.Text;

            if (CityTextBox.Text.Length <= 50)
                _address.City = CityTextBox.Text;

            if (StreetTextBox.Text.Length <= 100)
                _address.Street = StreetTextBox.Text;

            if (BuildingTextBox.Text.Length <= 10)
                _address.Building = BuildingTextBox.Text;

            if (ApartmentTextBox.Text.Length <= 10)
                _address.Apartment = ApartmentTextBox.Text;
        }

        /// <summary>
        /// Проверяет почтовый индекс.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        private void IndexTextBox_TextChanged(object sender, EventArgs e)
        {
            bool isCorrect = int.TryParse(IndexTextBox.Text, out int index) && index >= 100000 && index <= 999999;

            if (isCorrect)
            {
                _address.Index = index;
            }

            SetFieldState(IndexTextBox, isCorrect);
        }

        /// <summary>
        /// Подсвечивает поле и показывает подсказку при ошибке.
        /// </summary>
        /// <param name="textBox">Проверяемое поле.</param>
        /// <param name="isCorrect">Признак корректности.</param>
        private void SetFieldState(TextBox textBox, bool isCorrect)
        {
            if (isCorrect)
            {
                textBox.BackColor = Color.White;
                AddressToolTip.SetToolTip(textBox, null);
            }
            else
            {
                textBox.BackColor = Color.LightPink;
                AddressToolTip.SetToolTip(textBox, "Некорректное значение поля.");
            }
        }

        /// <summary>
        /// Проверяет страну.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        private void CountryTextBox_TextChanged(object sender, EventArgs e)
        {
            bool isCorrect = CountryTextBox.Text.Length > 0 && CountryTextBox.Text.Length <= 50;

            if (isCorrect)
            {
                _address.Country = CountryTextBox.Text;
            }

            SetFieldState(CountryTextBox, isCorrect);
        }

        /// <summary>
        /// Проверяет город.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        private void CityTextBox_TextChanged(object sender, EventArgs e)
        {
            bool isCorrect = CityTextBox.Text.Length > 0 && CityTextBox.Text.Length <= 50;

            if (isCorrect)
            {
                _address.City = CityTextBox.Text;
            }

            SetFieldState(CityTextBox, isCorrect);
        }

        /// <summary>
        /// Проверяет улицу.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        private void StreetTextBox_TextChanged(object sender, EventArgs e)
        {
            bool isCorrect = StreetTextBox.Text.Length > 0 && StreetTextBox.Text.Length <= 100;

            if (isCorrect)
            {
                _address.Street = StreetTextBox.Text;
            }

            SetFieldState(StreetTextBox, isCorrect);
        }

        /// <summary>
        /// Проверяет номер дома.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        private void BuildingTextBox_TextChanged(object sender, EventArgs e)
        {
            bool isCorrect = BuildingTextBox.Text.Length > 0 && BuildingTextBox.Text.Length <= 10;

            if (isCorrect)
            {
                _address.Building = BuildingTextBox.Text;
            }

            SetFieldState(BuildingTextBox, isCorrect);
        }

        /// <summary>
        /// Проверяет номер квартиры.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        private void ApartmentTextBox_TextChanged(object sender, EventArgs e)
        {
            bool isCorrect = ApartmentTextBox.Text.Length > 0 && ApartmentTextBox.Text.Length <= 10;

            if (isCorrect)
            {
                _address.Apartment = ApartmentTextBox.Text;
            }

            SetFieldState(ApartmentTextBox, isCorrect);
        }
    }
}

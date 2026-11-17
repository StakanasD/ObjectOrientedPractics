using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using ObjectOrientedPractics.Model;

namespace ObjectOrientedPractics.View.Controls
{
    /// <summary>
    /// Пользовательский элемент управления для отображения и редактирования адреса доставки.
    /// </summary>
    public partial class AddressControl : UserControl
    {
        private Address _address = new Address();
        private bool _readOnly;

        /// <summary>
        /// Возвращает и задает редактируемый адрес доставки.
        /// </summary>
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Address Address
        {
            get
            {
                UpdateAddress();
                return _address;
            }
            set
            {
                _address = value ?? new Address();
                UpdateControls();
            }
        }

        /// <summary>
        /// Возвращает и задает режим только для чтения для всех полей адреса.
        /// </summary>
        public bool ReadOnly
        {
            get { return _readOnly; }
            set
            {
                _readOnly = value;
                IndexTextBox.ReadOnly = value;
                CountryTextBox.ReadOnly = value;
                CityTextBox.ReadOnly = value;
                StreetTextBox.ReadOnly = value;
                BuildingTextBox.ReadOnly = value;
                ApartmentTextBox.ReadOnly = value;
            }
        }

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="AddressControl"/>.
        /// </summary>
        public AddressControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Отображает значения объекта адреса в текстовых полях элемента управления.
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
        /// Синхронизирует корректные значения из полей ввода с объектом адреса.
        /// </summary>
        private void UpdateAddress()
        {
            if (int.TryParse(IndexTextBox.Text, out int index) &&
                index >= 100000 && index <= 999999)
            {
                _address.Index = index;
            }

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
        /// Устанавливает визуальное состояние поля ввода и всплывающую подсказку с текстом ошибки.
        /// </summary>
        /// <param name="textBox">Проверяемое текстовое поле.</param>
        /// <param name="errorMessage">Текст ошибки или null, если значение корректно.</param>
        private void SetFieldState(TextBox textBox, string? errorMessage)
        {
            if (string.IsNullOrEmpty(errorMessage))
            {
                textBox.BackColor = Color.White;
                AddressToolTip.SetToolTip(textBox, null);
            }
            else
            {
                textBox.BackColor = Color.LightPink;
                AddressToolTip.SetToolTip(textBox, errorMessage);
            }
        }

        private void IndexTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(IndexTextBox.Text, out int index))
            {
                SetFieldState(IndexTextBox, "Почтовый индекс должен быть целым шестизначным числом.");
                return;
            }

            try
            {
                _address.Index = index;
                SetFieldState(IndexTextBox, null);
            }
            catch (ArgumentException ex)
            {
                SetFieldState(IndexTextBox, ex.Message);
            }
        }

        private void CountryTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _address.Country = CountryTextBox.Text;
                SetFieldState(CountryTextBox, null);
            }
            catch (ArgumentException ex)
            {
                SetFieldState(CountryTextBox, ex.Message);
            }
        }

        private void CityTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _address.City = CityTextBox.Text;
                SetFieldState(CityTextBox, null);
            }
            catch (ArgumentException ex)
            {
                SetFieldState(CityTextBox, ex.Message);
            }
        }

        private void StreetTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _address.Street = StreetTextBox.Text;
                SetFieldState(StreetTextBox, null);
            }
            catch (ArgumentException ex)
            {
                SetFieldState(StreetTextBox, ex.Message);
            }
        }

        private void BuildingTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _address.Building = BuildingTextBox.Text;
                SetFieldState(BuildingTextBox, null);
            }
            catch (ArgumentException ex)
            {
                SetFieldState(BuildingTextBox, ex.Message);
            }
        }

        private void ApartmentTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _address.Apartment = ApartmentTextBox.Text;
                SetFieldState(ApartmentTextBox, null);
            }
            catch (ArgumentException ex)
            {
                SetFieldState(ApartmentTextBox, ex.Message);
            }
        }
    }
}
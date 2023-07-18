namespace WinFormsApp10
{
    public partial class Form1 : Form
    {
        
        private List<string> clients = new List<string> { "Андрій Ярмоленко", "Олександр Зінченко", "Андрій Шевченко" };
        private List<string> products = new List<string> { "Товар А", "Товар Б", "Товар В", "Товар Г" };
        private Dictionary<string, List<string>> citiesAndPostOffices = new Dictionary<string, List<string>>
        {
            { "Львів", new List<string> { "Відділення 1", "Відділення 2", "Відділення 3" } },
            { "Київ", new List<string> { "Відділення 4", "Відділення 5", "Відділення 6" } },
            { "Івано-Франківськ", new List<string> { "Відділення 7", "Відділення 8", "Відділення 9" } }
        };

        public Form1()
        {
            InitializeComponent();
            foreach (var client in clients)
            {
                Clients.Items.Add(client);
            }

            foreach (var product in products)
            {
                checkedListBoxProducts.Items.Add(product);
            }
            comboBoxCity.Items.AddRange(citiesAndPostOffices.Keys.ToArray());
        }
        private void Add_Click(object sender, EventArgs e)
        {
            string newClient = textBoxNewClient.Text.Trim();
            if (!string.IsNullOrEmpty(newClient))
            {
                Clients.Items.Add(newClient);
                textBoxNewClient.Text = string.Empty;
            }
        }
        private void buttonRemoveClient_Click(object sender, EventArgs e)
        {
            if (Clients.SelectedIndex != -1)
            {
                Clients.Items.RemoveAt(Clients.SelectedIndex);
            }
        }
        private void comboBoxCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCity = comboBoxCity.SelectedItem?.ToString();
            if (!string.IsNullOrEmpty(selectedCity) && citiesAndPostOffices.ContainsKey(selectedCity))
            {
                comboBoxPostOffice.BeginUpdate();
                comboBoxPostOffice.Items.Clear();
                comboBoxPostOffice.Items.AddRange(citiesAndPostOffices[selectedCity].ToArray());
                comboBoxPostOffice.SelectedIndex = 0;
                comboBoxPostOffice.EndUpdate();
            }
        }
        private void buttonShowOrder_Click(object sender, EventArgs e)
        {
            string client = Clients.SelectedItem?.ToString();
            string productsList = string.Join(", ", checkedListBoxProducts.CheckedItems);
            string city = comboBoxCity.SelectedItem?.ToString();
            string postOffice = comboBoxPostOffice.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(client) || string.IsNullOrEmpty(productsList) || string.IsNullOrEmpty(city) || string.IsNullOrEmpty(postOffice))
            {
                MessageBox.Show("Будь ласка, заповніть усі поля замовлення.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string orderInfo = $"Замовник: {client}\nТовари: {productsList}\nАдреса одержувача: {city} - {postOffice}";
                MessageBox.Show(orderInfo, "Інформація про замовлення", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void textBoxNewClient_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}

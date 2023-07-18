namespace WinFormsApp10
{
    public partial class Form1 : Form
    {
        
        private List<string> clients = new List<string> { "����� ���������", "��������� ǳ������", "����� ��������" };
        private List<string> products = new List<string> { "����� �", "����� �", "����� �", "����� �" };
        private Dictionary<string, List<string>> citiesAndPostOffices = new Dictionary<string, List<string>>
        {
            { "����", new List<string> { "³������� 1", "³������� 2", "³������� 3" } },
            { "���", new List<string> { "³������� 4", "³������� 5", "³������� 6" } },
            { "�����-���������", new List<string> { "³������� 7", "³������� 8", "³������� 9" } }
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
                MessageBox.Show("���� �����, �������� �� ���� ����������.", "�������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string orderInfo = $"��������: {client}\n������: {productsList}\n������ ����������: {city} - {postOffice}";
                MessageBox.Show(orderInfo, "���������� ��� ����������", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

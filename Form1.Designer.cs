namespace WinFormsApp10
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Clients = new ListBox();
            checkedListBoxProducts = new CheckedListBox();
            comboBoxCity = new ComboBox();
            Add = new Button();
            comboBoxPostOffice = new ComboBox();
            button1 = new Button();
            textBoxNewClient = new TextBox();
            ShowOrder = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // Clients
            // 
            Clients.BackColor = SystemColors.Highlight;
            Clients.BorderStyle = BorderStyle.None;
            Clients.FormattingEnabled = true;
            Clients.ItemHeight = 20;
            Clients.Location = new Point(1, -4);
            Clients.Name = "Clients";
            Clients.Size = new Size(365, 420);
            Clients.TabIndex = 0;
            // 
            // checkedListBoxProducts
            // 
            checkedListBoxProducts.BackColor = SystemColors.Highlight;
            checkedListBoxProducts.BorderStyle = BorderStyle.None;
            checkedListBoxProducts.FormattingEnabled = true;
            checkedListBoxProducts.Location = new Point(372, -4);
            checkedListBoxProducts.Name = "checkedListBoxProducts";
            checkedListBoxProducts.Size = new Size(300, 418);
            checkedListBoxProducts.TabIndex = 1;
            // 
            // comboBoxCity
            // 
            comboBoxCity.BackColor = SystemColors.ButtonFace;
            comboBoxCity.FormattingEnabled = true;
            comboBoxCity.Location = new Point(678, 12);
            comboBoxCity.Name = "comboBoxCity";
            comboBoxCity.Size = new Size(212, 28);
            comboBoxCity.TabIndex = 2;
            comboBoxCity.SelectedIndexChanged += comboBoxCity_SelectedIndexChanged;
            // 
            // Add
            // 
            Add.ForeColor = SystemColors.Highlight;
            Add.Location = new Point(30, 354);
            Add.Name = "Add";
            Add.Size = new Size(115, 50);
            Add.TabIndex = 3;
            Add.Text = "Add";
            Add.UseVisualStyleBackColor = true;
            Add.Click += Add_Click;
            // 
            // comboBoxPostOffice
            // 
            comboBoxPostOffice.BackColor = SystemColors.ButtonFace;
            comboBoxPostOffice.FormattingEnabled = true;
            comboBoxPostOffice.Location = new Point(678, 69);
            comboBoxPostOffice.Name = "comboBoxPostOffice";
            comboBoxPostOffice.Size = new Size(212, 28);
            comboBoxPostOffice.TabIndex = 4;
            // 
            // button1
            // 
            button1.ForeColor = SystemColors.Highlight;
            button1.Location = new Point(177, 354);
            button1.Name = "button1";
            button1.Size = new Size(115, 50);
            button1.TabIndex = 5;
            button1.Text = "Remove";
            button1.UseVisualStyleBackColor = true;
            button1.Click += buttonRemoveClient_Click;
            // 
            // textBoxNewClient
            // 
            textBoxNewClient.Location = new Point(30, 321);
            textBoxNewClient.Name = "textBoxNewClient";
            textBoxNewClient.Size = new Size(251, 27);
            textBoxNewClient.TabIndex = 6;
            // 
            // ShowOrder
            // 
            ShowOrder.ForeColor = SystemColors.Highlight;
            ShowOrder.Location = new Point(830, 370);
            ShowOrder.Name = "ShowOrder";
            ShowOrder.Size = new Size(115, 50);
            ShowOrder.TabIndex = 7;
            ShowOrder.Text = "Show";
            ShowOrder.UseVisualStyleBackColor = true;
            ShowOrder.Click += buttonShowOrder_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Black;
            label1.Location = new Point(30, 298);
            label1.Name = "label1";
            label1.Size = new Size(81, 20);
            label1.TabIndex = 8;
            label1.Text = "New Client";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Highlight;
            ClientSize = new Size(994, 518);
            Controls.Add(label1);
            Controls.Add(ShowOrder);
            Controls.Add(textBoxNewClient);
            Controls.Add(button1);
            Controls.Add(comboBoxPostOffice);
            Controls.Add(Add);
            Controls.Add(comboBoxCity);
            Controls.Add(checkedListBoxProducts);
            Controls.Add(Clients);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox Clients;
        private CheckedListBox checkedListBoxProducts;
        private ComboBox comboBoxCity;
        private Button Add;
        private ComboBox comboBoxPostOffice;
        private Button button1;
        private TextBox textBoxNewClient;
        private Button ShowOrder;
        private Label label1;
    }
}
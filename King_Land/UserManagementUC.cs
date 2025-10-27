using System;
using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace King_Land
{
    public class UserManagementUC : UserControl
    {
        private Panel headerPanel;
        private Guna2HtmlLabel lblTitle;
        private Guna2HtmlLabel lblSubtitle;
        private Guna2DataGridView dgv;
        private Panel topPanel;
        private Guna2Button btnAddUser;

        public UserManagementUC()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.Dock = DockStyle.Fill;
            this.BackColor = Color.White;

            headerPanel = new Panel()
            {
                Dock = DockStyle.Top,
                Height = 88,
                BackColor = Color.White
            };

            lblTitle = new Guna2HtmlLabel()
            {
                Text = "User Management",
                Font = new Font("Segoe UI", 20F, FontStyle.Bold),
                ForeColor = Color.Black,
                AutoSize = true,
                Location = new Point(24, 16)
            };

            lblSubtitle = new Guna2HtmlLabel()
            {
                Text = "Manage users, departments and roles",
                Font = new Font("Segoe UI", 10F, FontStyle.Regular),
                ForeColor = Color.Gray,
                AutoSize = true,
                Location = new Point(24, 48)
            };

            headerPanel.Controls.Add(lblTitle);
            headerPanel.Controls.Add(lblSubtitle);

            topPanel = new Panel()
            {
                Dock = DockStyle.Top,
                Height = 64,
                BackColor = Color.White
            };

            btnAddUser = new Guna2Button()
            {
                Text = "Add User",
                Size = new Size(120, 36),
            };
            btnAddUser.FillColor = Color.Black;
            btnAddUser.ForeColor = Color.White;
            btnAddUser.BorderRadius = 10;
            btnAddUser.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            topPanel.SizeChanged += (s, e) =>
            {
                btnAddUser.Location = new Point(Math.Max(24, topPanel.ClientSize.Width - btnAddUser.Width - 24), (topPanel.Height - btnAddUser.Height) / 2);
            };

            topPanel.Controls.Add(btnAddUser);

            dgv = new Guna2DataGridView()
            {
                Dock = DockStyle.Fill,
                BackgroundColor = Color.White,
                BorderStyle = BorderStyle.None,
                AllowUserToAddRows = false,
                ReadOnly = true,
                SelectionMode = DataGridViewSelectionMode.FullRowSelect,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            };

            dgv.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Name", HeaderText = "Name" });
            dgv.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Email", HeaderText = "Email" });
            dgv.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Department", HeaderText = "Department" });
            dgv.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Position", HeaderText = "Position" });
            dgv.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Contact", HeaderText = "Contact" });
            dgv.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Status", HeaderText = "Status" });
            dgv.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Edit", HeaderText = "Edit" });

            this.Controls.Add(dgv);
            this.Controls.Add(topPanel);
            this.Controls.Add(headerPanel);
        }
    }
}

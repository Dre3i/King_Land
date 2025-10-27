using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace King_Land
{
    public partial class Login : Form
    {
        private const int EM_SETCUEBANNER = 0x1501;
        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        private static extern int SendMessage(IntPtr hWnd, int Msg, IntPtr wParam, string lParam);

        public Login()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.Font = new Font("Segoe UI", 10F);
        }

        private void Login_Load(object sender, EventArgs e)
        {
            // Focus email
            txtEmail.Focus();

            // Set placeholder/cue banner (works on Vista+)
            if (txtEmail.IsHandleCreated)
                SendMessage(txtEmail.Handle, EM_SETCUEBANNER, (IntPtr)1, "Enter your email");
            else
                txtEmail.HandleCreated += (s, ev) => SendMessage(txtEmail.Handle, EM_SETCUEBANNER, (IntPtr)1, "Enter your email");

            if (txtPassword.IsHandleCreated)
                SendMessage(txtPassword.Handle, EM_SETCUEBANNER, (IntPtr)1, "Enter your password");
            else
                txtPassword.HandleCreated += (s, ev) => SendMessage(txtPassword.Handle, EM_SETCUEBANNER, (IntPtr)1, "Enter your password");

            txtPassword.UseSystemPasswordChar = true;

            // Apply rounded corners for panels here is optional; actual regions applied in Shown
            // Keep regions updated on resize
            panelMain.SizeChanged += (s, ev) => ApplyRoundedRegion(panelMain, 20);
            panelShadow.SizeChanged += (s, ev) => ApplyRoundedRegion(panelShadow, 20);
            btnLogin.SizeChanged += (s, ev) => ApplyRoundedRegion(btnLogin, Math.Max(10, btnLogin.Height / 2));

            // Style buttons
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.BackColor = Color.Black;
            btnLogin.ForeColor = Color.White;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.MouseEnter += (s, ev) => btnLogin.BackColor = Color.FromArgb(40, 40, 40);
            btnLogin.MouseLeave += (s, ev) => btnLogin.BackColor = Color.Black;

            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.BackColor = Color.Transparent;
            btnCancel.ForeColor = Color.Gray;
            btnCancel.Cursor = Cursors.Hand;

            // Center the form
            this.StartPosition = FormStartPosition.CenterScreen;
        }

       

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            // Soft layered gradient background
            using (var brush = new LinearGradientBrush(this.ClientRectangle, Color.FromArgb(246, 247, 251), Color.White, LinearGradientMode.ForwardDiagonal))
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }

            base.OnPaintBackground(e);
        }

        private void ApplyRoundedRegion(Control ctrl, int radius)
        {
            if (ctrl.Width <= 0 || ctrl.Height <= 0) return;
            using (var path = CreateRoundRectPath(new Rectangle(0, 0, ctrl.Width, ctrl.Height), radius))
            {
                // dispose previous region if any
                if (ctrl.Region != null)
                {
                    try { ctrl.Region.Dispose(); } catch { }
                }
                ctrl.Region = new Region(path);
            }
        }

        private GraphicsPath CreateRoundRectPath(Rectangle rect, int radius)
        {
            var path = new GraphicsPath();
            int d = radius * 2;
            if (d > rect.Width) d = rect.Width;
            if (d > rect.Height) d = rect.Height;
            path.StartFigure();
            path.AddArc(rect.X, rect.Y, d, d, 180, 90);
            path.AddArc(rect.X + rect.Width - d, rect.Y, d, d, 270, 90);
            path.AddArc(rect.X + rect.Width - d, rect.Y + rect.Height - d, d, d, 0, 90);
            path.AddArc(rect.X, rect.Y + rect.Height - d, d, d, 90, 90);
            path.CloseFigure();
            return path;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var email = txtEmail.Text.Trim();
            var password = txtPassword.Text; // replace with secure check

            if (Authenticate(email, password))
            {
                DialogResult = DialogResult.OK;
                Main main = new Main(); 
                main.Show();
            }
            else
            {
                MessageBox.Show(this, "Invalid email or password.", "Login failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Clear();
                txtPassword.Focus();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private bool Authenticate(string email, string password)
        {
            // Replace this with your real authentication (database, AD, API, etc.)
            // Example credentials (demo only):
            return string.Equals(email, "", StringComparison.OrdinalIgnoreCase)
                   && password == "";
        }
    }
}

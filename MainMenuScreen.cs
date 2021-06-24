using System;
using System.Drawing;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace airline_reservation_system
{
    public partial class MainMenuScreen : Form
    {
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;

        public MainMenuScreen()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 70);
            MenuPanel.Controls.Add(leftBorderBtn);
        }

        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(113, 201, 245);
            public static Color color2 = Color.FromArgb(255, 230, 0);
            public static Color color3 = Color.FromArgb(214, 15, 38);
            public static Color color4 = Color.FromArgb(242, 158, 56);
            public static Color color5 = Color.FromArgb(255, 0, 0);
        }

        private void ActivateBtn (object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();

                //button design
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(85, 124, 230);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;

                //left border design
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();

                //child form title bar
                iconCurrentChildForm.IconChar = currentBtn.IconChar;
                iconCurrentChildForm.IconColor = color;
                
            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(33, 30, 68);
                currentBtn.ForeColor = Color.White;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.White;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void OpenChildForm(Form form)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = form;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(form);
            panelChildForm.Tag = form;
            form.BringToFront();
            form.Show();
            lblTitle.Text = form.Text;
        }

        private void AddRes_Click(object sender, EventArgs e)
        {
            ActivateBtn(sender, RGBColors.color1);
            OpenChildForm(new AddResScreen());
        }

        private void RescheduleRes_Click(object sender, EventArgs e)
        {
            ActivateBtn(sender, RGBColors.color2);
            OpenChildForm(new RescheduleResScreen());
        }

        private void CancelRes_Click(object sender, EventArgs e)
        {
            ActivateBtn(sender, RGBColors.color3);
            OpenChildForm(new CancelResScreen());
        }

        private void ViewRes_Click(object sender, EventArgs e)
        {
            ActivateBtn(sender, RGBColors.color4);
            OpenChildForm(new ViewResScreen());
        }

        private void Logo_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void Reset()
        {
            DisableButton();
            currentChildForm.Close();
            leftBorderBtn.Visible = false;
            iconCurrentChildForm.IconChar = IconChar.Home;
            iconCurrentChildForm.IconColor = Color.White;
            lblTitle.Text = "Home";
        }

        private void LogOut_Click(object sender, EventArgs e)
        {
            ActivateBtn(sender, RGBColors.color5);
            new LoginScreen().Show();
            this.Hide();
        }
    }
}

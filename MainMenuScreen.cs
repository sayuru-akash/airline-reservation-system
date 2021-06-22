using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace airline_reservation_system
{
    public partial class Form2 : Form
    {
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;

        public Form2()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 70);
            MenuPanel.Controls.Add(leftBorderBtn);
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
            ActivateBtn(sender, Color.FromArgb(113, 201, 245));
        }

        private void RescheduleRes_Click(object sender, EventArgs e)
        {
            ActivateBtn(sender, Color.FromArgb(255, 230, 0));
        }

        private void CancelRes_Click(object sender, EventArgs e)
        {
            ActivateBtn(sender, Color.FromArgb(214, 15, 38));
        }

        private void ViewRes_Click(object sender, EventArgs e)
        {
            ActivateBtn(sender, Color.FromArgb(242, 158, 56));
        }

        private void Logo_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            iconCurrentChildForm.IconChar = IconChar.Home;
            iconCurrentChildForm.IconColor = Color.White;
            lblTitle.Text = "Home";
        }

        private void LogOut_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }
    }
}

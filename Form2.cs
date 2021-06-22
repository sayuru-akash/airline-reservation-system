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

        public Form2()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 70);
            MenuPanel.Controls.Add(leftBorderBtn);
        }

        private void ActivateBtn (object senderBtn)
        {
            if (senderBtn != null)
            {
                DisableButton();

                //button design
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(85, 124, 230);
                currentBtn.ForeColor = Color.FromArgb(255, 230, 0);
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = Color.FromArgb(255, 230, 0);
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;

                //left border design
                leftBorderBtn.BackColor = Color.FromArgb(255, 230, 0);
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
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

        private void AddRes_Click(object sender, EventArgs e)
        {
            ActivateBtn(sender);
        }

        private void RescheduleRes_Click(object sender, EventArgs e)
        {
            ActivateBtn(sender);
        }

        private void CancelRes_Click(object sender, EventArgs e)
        {
            ActivateBtn(sender);
        }

        private void ViewRes_Click(object sender, EventArgs e)
        {
            ActivateBtn(sender);
        }

        private void Logo_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
        }

        private void LogOut_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }
    }
}

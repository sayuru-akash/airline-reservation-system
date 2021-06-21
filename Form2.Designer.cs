
namespace airline_reservation_system
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.AddRes = new FontAwesome.Sharp.IconButton();
            this.RescheduleRes = new FontAwesome.Sharp.IconButton();
            this.CancelRes = new FontAwesome.Sharp.IconButton();
            this.ViewRes = new FontAwesome.Sharp.IconButton();
            this.LogOut = new FontAwesome.Sharp.IconButton();
            this.MenuPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuPanel
            // 
            this.MenuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.MenuPanel.Controls.Add(this.LogOut);
            this.MenuPanel.Controls.Add(this.ViewRes);
            this.MenuPanel.Controls.Add(this.CancelRes);
            this.MenuPanel.Controls.Add(this.RescheduleRes);
            this.MenuPanel.Controls.Add(this.AddRes);
            this.MenuPanel.Controls.Add(this.panel2);
            this.MenuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuPanel.Location = new System.Drawing.Point(0, 0);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(260, 459);
            this.MenuPanel.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(260, 100);
            this.panel2.TabIndex = 0;
            // 
            // AddRes
            // 
            this.AddRes.Dock = System.Windows.Forms.DockStyle.Top;
            this.AddRes.FlatAppearance.BorderSize = 0;
            this.AddRes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddRes.Font = new System.Drawing.Font("Poppins Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddRes.ForeColor = System.Drawing.Color.White;
            this.AddRes.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.AddRes.IconColor = System.Drawing.Color.White;
            this.AddRes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.AddRes.IconSize = 25;
            this.AddRes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddRes.Location = new System.Drawing.Point(0, 100);
            this.AddRes.Name = "AddRes";
            this.AddRes.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.AddRes.Size = new System.Drawing.Size(260, 70);
            this.AddRes.TabIndex = 1;
            this.AddRes.Text = "Add Reservation";
            this.AddRes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddRes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AddRes.UseVisualStyleBackColor = true;
            // 
            // RescheduleRes
            // 
            this.RescheduleRes.Dock = System.Windows.Forms.DockStyle.Top;
            this.RescheduleRes.FlatAppearance.BorderSize = 0;
            this.RescheduleRes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RescheduleRes.Font = new System.Drawing.Font("Poppins Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RescheduleRes.ForeColor = System.Drawing.Color.White;
            this.RescheduleRes.IconChar = FontAwesome.Sharp.IconChar.Clock;
            this.RescheduleRes.IconColor = System.Drawing.Color.White;
            this.RescheduleRes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.RescheduleRes.IconSize = 25;
            this.RescheduleRes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RescheduleRes.Location = new System.Drawing.Point(0, 170);
            this.RescheduleRes.Name = "RescheduleRes";
            this.RescheduleRes.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.RescheduleRes.Size = new System.Drawing.Size(260, 70);
            this.RescheduleRes.TabIndex = 2;
            this.RescheduleRes.Text = "Reschedule Reservation";
            this.RescheduleRes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RescheduleRes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.RescheduleRes.UseVisualStyleBackColor = true;
            // 
            // CancelRes
            // 
            this.CancelRes.Dock = System.Windows.Forms.DockStyle.Top;
            this.CancelRes.FlatAppearance.BorderSize = 0;
            this.CancelRes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelRes.Font = new System.Drawing.Font("Poppins Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelRes.ForeColor = System.Drawing.Color.White;
            this.CancelRes.IconChar = FontAwesome.Sharp.IconChar.Ban;
            this.CancelRes.IconColor = System.Drawing.Color.White;
            this.CancelRes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.CancelRes.IconSize = 25;
            this.CancelRes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CancelRes.Location = new System.Drawing.Point(0, 240);
            this.CancelRes.Name = "CancelRes";
            this.CancelRes.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.CancelRes.Size = new System.Drawing.Size(260, 70);
            this.CancelRes.TabIndex = 3;
            this.CancelRes.Text = "Cancel Reservation";
            this.CancelRes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CancelRes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CancelRes.UseVisualStyleBackColor = true;
            // 
            // ViewRes
            // 
            this.ViewRes.Dock = System.Windows.Forms.DockStyle.Top;
            this.ViewRes.FlatAppearance.BorderSize = 0;
            this.ViewRes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ViewRes.Font = new System.Drawing.Font("Poppins Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewRes.ForeColor = System.Drawing.Color.White;
            this.ViewRes.IconChar = FontAwesome.Sharp.IconChar.SearchPlus;
            this.ViewRes.IconColor = System.Drawing.Color.White;
            this.ViewRes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ViewRes.IconSize = 25;
            this.ViewRes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ViewRes.Location = new System.Drawing.Point(0, 310);
            this.ViewRes.Name = "ViewRes";
            this.ViewRes.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.ViewRes.Size = new System.Drawing.Size(260, 70);
            this.ViewRes.TabIndex = 4;
            this.ViewRes.Text = "View Reservations";
            this.ViewRes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ViewRes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ViewRes.UseVisualStyleBackColor = true;
            // 
            // LogOut
            // 
            this.LogOut.Dock = System.Windows.Forms.DockStyle.Top;
            this.LogOut.FlatAppearance.BorderSize = 0;
            this.LogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogOut.Font = new System.Drawing.Font("Poppins Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogOut.ForeColor = System.Drawing.Color.White;
            this.LogOut.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.LogOut.IconColor = System.Drawing.Color.White;
            this.LogOut.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.LogOut.IconSize = 25;
            this.LogOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LogOut.Location = new System.Drawing.Point(0, 380);
            this.LogOut.Name = "LogOut";
            this.LogOut.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.LogOut.Size = new System.Drawing.Size(260, 70);
            this.LogOut.TabIndex = 5;
            this.LogOut.Text = "Log Out";
            this.LogOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LogOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.LogOut.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(178)))), ((int)(((byte)(235)))));
            this.ClientSize = new System.Drawing.Size(877, 459);
            this.ControlBox = false;
            this.Controls.Add(this.MenuPanel);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.MenuPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MenuPanel;
        private FontAwesome.Sharp.IconButton AddRes;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton LogOut;
        private FontAwesome.Sharp.IconButton ViewRes;
        private FontAwesome.Sharp.IconButton CancelRes;
        private FontAwesome.Sharp.IconButton RescheduleRes;
    }
}
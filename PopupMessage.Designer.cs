
namespace airline_reservation_system
{
    partial class PopupMessage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PopupMessage));
            this.okButton = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // okButton
            // 
            this.okButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(250)))));
            this.okButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.okButton.FlatAppearance.BorderSize = 0;
            this.okButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.okButton.Font = new System.Drawing.Font("Poppins Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.okButton.ForeColor = System.Drawing.Color.White;
            this.okButton.Location = new System.Drawing.Point(0, 93);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(400, 27);
            this.okButton.TabIndex = 0;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = false;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoEllipsis = true;
            this.lblMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMessage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblMessage.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.ForeColor = System.Drawing.Color.White;
            this.lblMessage.Location = new System.Drawing.Point(0, 0);
            this.lblMessage.Margin = new System.Windows.Forms.Padding(5);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Padding = new System.Windows.Forms.Padding(5);
            this.lblMessage.Size = new System.Drawing.Size(400, 93);
            this.lblMessage.TabIndex = 1;
            this.lblMessage.Text = "This is a textbox";
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMessage.UseMnemonic = false;
            // 
            // PopupMessage
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(120)))));
            this.ClientSize = new System.Drawing.Size(400, 120);
            this.ControlBox = false;
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.okButton);
            this.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MinimizeBox = false;
            this.Name = "PopupMessage";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PopupMessage";
            this.TopMost = true;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Label lblMessage;
    }
}
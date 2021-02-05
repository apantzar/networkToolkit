namespace NetworkToolkit
{
    partial class RTT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RTT));
            this.label1 = new System.Windows.Forms.Label();
            this.thatTimeBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nextConfirmBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.aValue = new Guna.UI2.WinForms.Guna2TextBox();
            this.rttBtnCalc = new Guna.UI2.WinForms.Guna2GradientButton();
            this.resultLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.clearBtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(481, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Αν ο χρόνος μετ\' επιστροφής του TCP, εστω RTT, είναι αυτή τη στιγμή";
            // 
            // thatTimeBox
            // 
            this.thatTimeBox.BorderRadius = 10;
            this.thatTimeBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.thatTimeBox.DefaultText = "";
            this.thatTimeBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.thatTimeBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.thatTimeBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.thatTimeBox.DisabledState.Parent = this.thatTimeBox;
            this.thatTimeBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.thatTimeBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.thatTimeBox.FocusedState.Parent = this.thatTimeBox;
            this.thatTimeBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thatTimeBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.thatTimeBox.HoverState.Parent = this.thatTimeBox;
            this.thatTimeBox.Location = new System.Drawing.Point(499, 41);
            this.thatTimeBox.Name = "thatTimeBox";
            this.thatTimeBox.PasswordChar = '\0';
            this.thatTimeBox.PlaceholderText = "";
            this.thatTimeBox.SelectedText = "";
            this.thatTimeBox.ShadowDecoration.Parent = this.thatTimeBox;
            this.thatTimeBox.Size = new System.Drawing.Size(80, 43);
            this.thatTimeBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(603, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(306, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "και η επόμενη επιβεβαίωση φτάνει μετά απο ";
            // 
            // nextConfirmBox
            // 
            this.nextConfirmBox.BorderRadius = 10;
            this.nextConfirmBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nextConfirmBox.DefaultText = "";
            this.nextConfirmBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.nextConfirmBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.nextConfirmBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nextConfirmBox.DisabledState.Parent = this.nextConfirmBox;
            this.nextConfirmBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nextConfirmBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nextConfirmBox.FocusedState.Parent = this.nextConfirmBox;
            this.nextConfirmBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextConfirmBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nextConfirmBox.HoverState.Parent = this.nextConfirmBox;
            this.nextConfirmBox.Location = new System.Drawing.Point(915, 41);
            this.nextConfirmBox.Name = "nextConfirmBox";
            this.nextConfirmBox.PasswordChar = '\0';
            this.nextConfirmBox.PlaceholderText = "";
            this.nextConfirmBox.SelectedText = "";
            this.nextConfirmBox.ShadowDecoration.Parent = this.nextConfirmBox;
            this.nextConfirmBox.Size = new System.Drawing.Size(80, 43);
            this.nextConfirmBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(811, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "msec αντίστοιχα ποιά θα είναι η νέα εκτίμηση για το RTT με βάση τον αλγόριθμο του" +
    " Jacobson; Χρησιμοποιήστε το α=";
            // 
            // aValue
            // 
            this.aValue.BorderRadius = 10;
            this.aValue.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.aValue.DefaultText = "";
            this.aValue.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.aValue.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.aValue.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.aValue.DisabledState.Parent = this.aValue;
            this.aValue.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.aValue.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.aValue.FocusedState.Parent = this.aValue;
            this.aValue.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aValue.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.aValue.HoverState.Parent = this.aValue;
            this.aValue.Location = new System.Drawing.Point(829, 95);
            this.aValue.Name = "aValue";
            this.aValue.PasswordChar = '\0';
            this.aValue.PlaceholderText = "";
            this.aValue.SelectedText = "";
            this.aValue.ShadowDecoration.Parent = this.aValue;
            this.aValue.Size = new System.Drawing.Size(80, 43);
            this.aValue.TabIndex = 5;
            // 
            // rttBtnCalc
            // 
            this.rttBtnCalc.BorderRadius = 8;
            this.rttBtnCalc.CheckedState.Parent = this.rttBtnCalc;
            this.rttBtnCalc.CustomImages.Parent = this.rttBtnCalc;
            this.rttBtnCalc.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.rttBtnCalc.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.rttBtnCalc.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rttBtnCalc.ForeColor = System.Drawing.Color.White;
            this.rttBtnCalc.HoverState.Parent = this.rttBtnCalc;
            this.rttBtnCalc.Location = new System.Drawing.Point(15, 186);
            this.rttBtnCalc.Name = "rttBtnCalc";
            this.rttBtnCalc.ShadowDecoration.Parent = this.rttBtnCalc;
            this.rttBtnCalc.Size = new System.Drawing.Size(151, 59);
            this.rttBtnCalc.TabIndex = 15;
            this.rttBtnCalc.Text = "Υπολογισμός RTT";
            this.rttBtnCalc.Click += new System.EventHandler(this.rttBtnCalc_Click);
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultLabel.Location = new System.Drawing.Point(202, 197);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(0, 31);
            this.resultLabel.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(12, 287);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(576, 15);
            this.label4.TabIndex = 17;
            this.label4.Text = "*Τα δεκαδικά στοιχεία με αναπάσταση \',\' ή \'.\' εξαρτάται απο την ρύθμιση της γλώσσ" +
    "ας του υπολογιστή σας";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(256, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "<-----ResultLabel";
            this.label5.Visible = false;
            // 
            // clearBtn
            // 
            this.clearBtn.BorderRadius = 8;
            this.clearBtn.CheckedState.Parent = this.clearBtn;
            this.clearBtn.CustomImages.Parent = this.clearBtn;
            this.clearBtn.FillColor = System.Drawing.Color.Silver;
            this.clearBtn.FillColor2 = System.Drawing.Color.Silver;
            this.clearBtn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearBtn.ForeColor = System.Drawing.Color.White;
            this.clearBtn.HoverState.Parent = this.clearBtn;
            this.clearBtn.Location = new System.Drawing.Point(12, 251);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.ShadowDecoration.Parent = this.clearBtn;
            this.clearBtn.Size = new System.Drawing.Size(154, 33);
            this.clearBtn.TabIndex = 19;
            this.clearBtn.Text = "Καθαρισμός";
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // RTT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 309);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.rttBtnCalc);
            this.Controls.Add(this.aValue);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nextConfirmBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.thatTimeBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RTT";
            this.Text = "RTT";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox thatTimeBox;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox nextConfirmBox;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox aValue;
        private Guna.UI2.WinForms.Guna2GradientButton rttBtnCalc;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2GradientButton clearBtn;
    }
}
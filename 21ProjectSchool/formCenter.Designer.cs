namespace _21ProjectSchool
{
    partial class formCenter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formCenter));
            this.btn21 = new System.Windows.Forms.Button();
            this.btnPH = new System.Windows.Forms.Button();
            this.btnPH2 = new System.Windows.Forms.Button();
            this.btnPH3 = new System.Windows.Forms.Button();
            this.lbl21Description = new System.Windows.Forms.Label();
            this.lblMainText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn21
            // 
            this.btn21.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn21.Location = new System.Drawing.Point(82, 95);
            this.btn21.Name = "btn21";
            this.btn21.Size = new System.Drawing.Size(140, 140);
            this.btn21.TabIndex = 0;
            this.btn21.Text = "21";
            this.btn21.UseVisualStyleBackColor = true;
            this.btn21.Click += new System.EventHandler(this.btn21_Click);
            this.btn21.MouseLeave += new System.EventHandler(this.btn21Leave);
            this.btn21.MouseHover += new System.EventHandler(this.btn21Hover);
            // 
            // btnPH
            // 
            this.btnPH.Enabled = false;
            this.btnPH.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPH.Location = new System.Drawing.Point(228, 95);
            this.btnPH.Name = "btnPH";
            this.btnPH.Size = new System.Drawing.Size(140, 140);
            this.btnPH.TabIndex = 1;
            this.btnPH.Text = "PH";
            this.btnPH.UseVisualStyleBackColor = true;
            // 
            // btnPH2
            // 
            this.btnPH2.Enabled = false;
            this.btnPH2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPH2.Location = new System.Drawing.Point(374, 95);
            this.btnPH2.Name = "btnPH2";
            this.btnPH2.Size = new System.Drawing.Size(140, 140);
            this.btnPH2.TabIndex = 2;
            this.btnPH2.Text = "PH";
            this.btnPH2.UseVisualStyleBackColor = true;
            // 
            // btnPH3
            // 
            this.btnPH3.Enabled = false;
            this.btnPH3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPH3.Location = new System.Drawing.Point(520, 95);
            this.btnPH3.Name = "btnPH3";
            this.btnPH3.Size = new System.Drawing.Size(140, 140);
            this.btnPH3.TabIndex = 3;
            this.btnPH3.Text = "PH";
            this.btnPH3.UseVisualStyleBackColor = true;
            // 
            // lbl21Description
            // 
            this.lbl21Description.AutoSize = true;
            this.lbl21Description.Location = new System.Drawing.Point(82, 267);
            this.lbl21Description.Name = "lbl21Description";
            this.lbl21Description.Size = new System.Drawing.Size(600, 75);
            this.lbl21Description.TabIndex = 4;
            this.lbl21Description.Text = resources.GetString("lbl21Description.Text");
            this.lbl21Description.Visible = false;
            // 
            // lblMainText
            // 
            this.lblMainText.AutoSize = true;
            this.lblMainText.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMainText.Location = new System.Drawing.Point(118, 22);
            this.lblMainText.Name = "lblMainText";
            this.lblMainText.Size = new System.Drawing.Size(520, 50);
            this.lblMainText.TabIndex = 5;
            this.lblMainText.Text = "Select the game to continue!";
            this.lblMainText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // formCenter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(749, 372);
            this.Controls.Add(this.lblMainText);
            this.Controls.Add(this.lbl21Description);
            this.Controls.Add(this.btnPH3);
            this.Controls.Add(this.btnPH2);
            this.Controls.Add(this.btnPH);
            this.Controls.Add(this.btn21);
            this.Name = "formCenter";
            this.Text = "Game Arena";
            this.Load += new System.EventHandler(this.formsCenterLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn21;
        private Button btnPH;
        private Button btnPH2;
        private Button btnPH3;
        private Label lbl21Description;
        private Label lblMainText;
    }
}
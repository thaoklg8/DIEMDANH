
namespace WF_DiemDanh
{
    partial class FormAccess
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAccess));
            this.btnA = new System.Windows.Forms.Button();
            this.btnMayB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnA
            // 
            this.btnA.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnA.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnA.Location = new System.Drawing.Point(79, 215);
            this.btnA.Margin = new System.Windows.Forms.Padding(4);
            this.btnA.Name = "btnA";
            this.btnA.Size = new System.Drawing.Size(274, 49);
            this.btnA.TabIndex = 2;
            this.btnA.Text = "MÁY A";
            this.btnA.UseVisualStyleBackColor = false;
            this.btnA.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnMayB
            // 
            this.btnMayB.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnMayB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnMayB.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMayB.Location = new System.Drawing.Point(387, 215);
            this.btnMayB.Margin = new System.Windows.Forms.Padding(4);
            this.btnMayB.Name = "btnMayB";
            this.btnMayB.Size = new System.Drawing.Size(274, 49);
            this.btnMayB.TabIndex = 3;
            this.btnMayB.Text = "MÁY B";
            this.btnMayB.UseVisualStyleBackColor = false;
            this.btnMayB.Click += new System.EventHandler(this.btnMayB_Click);
            // 
            // FormAccess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(772, 386);
            this.Controls.Add(this.btnMayB);
            this.Controls.Add(this.btnA);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FormAccess";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CHỌN MÁY";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnA;
        private System.Windows.Forms.Button btnMayB;
    }
}
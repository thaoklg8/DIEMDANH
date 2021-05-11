
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
            this.txtAccess = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNhap = new System.Windows.Forms.Button();
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
            // txtAccess
            // 
            this.txtAccess.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtAccess.Location = new System.Drawing.Point(91, 126);
            this.txtAccess.Name = "txtAccess";
            this.txtAccess.Size = new System.Drawing.Size(320, 30);
            this.txtAccess.TabIndex = 4;
            this.txtAccess.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(86, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nhập đường dẫn file Access";
            this.label1.Visible = false;
            // 
            // btnNhap
            // 
            this.btnNhap.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNhap.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNhap.Location = new System.Drawing.Point(445, 126);
            this.btnNhap.Name = "btnNhap";
            this.btnNhap.Size = new System.Drawing.Size(138, 35);
            this.btnNhap.TabIndex = 6;
            this.btnNhap.Text = "Enter";
            this.btnNhap.UseVisualStyleBackColor = false;
            this.btnNhap.Visible = false;
            this.btnNhap.Click += new System.EventHandler(this.btnNhap_Click);
            // 
            // FormAccess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(772, 386);
            this.Controls.Add(this.btnNhap);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAccess);
            this.Controls.Add(this.btnMayB);
            this.Controls.Add(this.btnA);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FormAccess";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CHỌN MÁY";
            this.Load += new System.EventHandler(this.FormAccess_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnA;
        private System.Windows.Forms.Button btnMayB;
        private System.Windows.Forms.TextBox txtAccess;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNhap;
    }
}
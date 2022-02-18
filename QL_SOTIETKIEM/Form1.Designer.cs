namespace QL_SOTIETKIEM
{
    partial class Form1
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
            this.btKH = new System.Windows.Forms.Button();
            this.btSTK = new System.Windows.Forms.Button();
            this.btDSTK = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btRut = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btKH
            // 
            this.btKH.Location = new System.Drawing.Point(21, 11);
            this.btKH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btKH.Name = "btKH";
            this.btKH.Size = new System.Drawing.Size(160, 40);
            this.btKH.TabIndex = 1;
            this.btKH.Text = "Khách hàng";
            this.btKH.UseVisualStyleBackColor = true;
            this.btKH.Click += new System.EventHandler(this.btKH_Click);
            // 
            // btSTK
            // 
            this.btSTK.Location = new System.Drawing.Point(201, 11);
            this.btSTK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btSTK.Name = "btSTK";
            this.btSTK.Size = new System.Drawing.Size(160, 40);
            this.btSTK.TabIndex = 2;
            this.btSTK.Text = "Mở sổ tiết kiệm";
            this.btSTK.UseVisualStyleBackColor = true;
            this.btSTK.Click += new System.EventHandler(this.btSTK_Click);
            // 
            // btDSTK
            // 
            this.btDSTK.Location = new System.Drawing.Point(378, 11);
            this.btDSTK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btDSTK.Name = "btDSTK";
            this.btDSTK.Size = new System.Drawing.Size(209, 40);
            this.btDSTK.TabIndex = 3;
            this.btDSTK.Text = "Danh sách sổ tiết kiệm";
            this.btDSTK.UseVisualStyleBackColor = true;
            this.btDSTK.Click += new System.EventHandler(this.btDSTK_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(95, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(741, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "CHƯƠNG TRÌNH QUẢN LÝ SỔ TIẾT KIỆM TRONG NGÂN HÀNG ";
            // 
            // btRut
            // 
            this.btRut.Location = new System.Drawing.Point(604, 11);
            this.btRut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btRut.Name = "btRut";
            this.btRut.Size = new System.Drawing.Size(154, 40);
            this.btRut.TabIndex = 5;
            this.btRut.Text = "Rút tiền tiết kiệm";
            this.btRut.UseVisualStyleBackColor = true;
            this.btRut.Click += new System.EventHandler(this.btRut_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(780, 11);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 40);
            this.button1.TabIndex = 6;
            this.button1.Text = "Thoát Chương Trình";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 840);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btRut);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btDSTK);
            this.Controls.Add(this.btSTK);
            this.Controls.Add(this.btKH);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "QL SỔ TIẾT KIỆM";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btKH;
        private System.Windows.Forms.Button btSTK;
        private System.Windows.Forms.Button btDSTK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btRut;
        private System.Windows.Forms.Button button1;
    }
}


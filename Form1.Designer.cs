namespace BaiThucHanhBuoi1
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
            this.lblNAME = new System.Windows.Forms.Label();
            this.txtbName = new System.Windows.Forms.TextBox();
            this.btnXuly = new System.Windows.Forms.Button();
            this.btnCopy = new System.Windows.Forms.Button();
            this.txtbName2 = new System.Windows.Forms.TextBox();
            this.lblDaNhap = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNAME
            // 
            this.lblNAME.AutoSize = true;
            this.lblNAME.Location = new System.Drawing.Point(91, 91);
            this.lblNAME.Name = "lblNAME";
            this.lblNAME.Size = new System.Drawing.Size(93, 13);
            this.lblNAME.TabIndex = 0;
            this.lblNAME.Text = "Nhập tên của bạn";
            // 
            // txtbName
            // 
            this.txtbName.Location = new System.Drawing.Point(188, 88);
            this.txtbName.Name = "txtbName";
            this.txtbName.Size = new System.Drawing.Size(155, 20);
            this.txtbName.TabIndex = 1;
            this.txtbName.TextChanged += new System.EventHandler(this.txtbName_TextChanged);
            // 
            // btnXuly
            // 
            this.btnXuly.Location = new System.Drawing.Point(188, 124);
            this.btnXuly.Name = "btnXuly";
            this.btnXuly.Size = new System.Drawing.Size(70, 37);
            this.btnXuly.TabIndex = 2;
            this.btnXuly.Text = "Xử Lý";
            this.btnXuly.UseVisualStyleBackColor = true;
            this.btnXuly.Click += new System.EventHandler(this.btnXuly_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(278, 124);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(65, 37);
            this.btnCopy.TabIndex = 3;
            this.btnCopy.Text = "Sao Chép";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // txtbName2
            // 
            this.txtbName2.Location = new System.Drawing.Point(190, 198);
            this.txtbName2.Name = "txtbName2";
            this.txtbName2.Size = new System.Drawing.Size(153, 20);
            this.txtbName2.TabIndex = 5;
            this.txtbName2.TextChanged += new System.EventHandler(this.txtbName2_TextChanged);
            // 
            // lblDaNhap
            // 
            this.lblDaNhap.AutoSize = true;
            this.lblDaNhap.Location = new System.Drawing.Point(91, 205);
            this.lblDaNhap.Name = "lblDaNhap";
            this.lblDaNhap.Size = new System.Drawing.Size(72, 13);
            this.lblDaNhap.TabIndex = 6;
            this.lblDaNhap.Text = "Bạn Đã Nhập";
            this.lblDaNhap.Click += new System.EventHandler(this.lblDaNhap_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblDaNhap);
            this.Controls.Add(this.txtbName2);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.btnXuly);
            this.Controls.Add(this.txtbName);
            this.Controls.Add(this.lblNAME);
            this.Name = "Form1";
            this.Text = "Chương Trình Đầu Tiên";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNAME;
        private System.Windows.Forms.TextBox txtbName;
        private System.Windows.Forms.Button btnXuly;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.TextBox txtbName2;
        private System.Windows.Forms.Label lblDaNhap;
    }
}


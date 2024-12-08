namespace Bai2_LTMTW
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbx_Id = new System.Windows.Forms.TextBox();
            this.tbx_Name = new System.Windows.Forms.TextBox();
            this.dtp_date = new System.Windows.Forms.DateTimePicker();
            this.lv_DanhSach = new System.Windows.Forms.ListView();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(56, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 26);
            this.label2.TabIndex = 0;
            this.label2.Text = "Họ và tên: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(56, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(224, 26);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ngày tháng năm sinh:";
            // 
            // tbx_Id
            // 
            this.tbx_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_Id.Location = new System.Drawing.Point(303, 57);
            this.tbx_Id.Name = "tbx_Id";
            this.tbx_Id.Size = new System.Drawing.Size(315, 32);
            this.tbx_Id.TabIndex = 1;
            // 
            // tbx_Name
            // 
            this.tbx_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_Name.Location = new System.Drawing.Point(303, 112);
            this.tbx_Name.Name = "tbx_Name";
            this.tbx_Name.Size = new System.Drawing.Size(315, 32);
            this.tbx_Name.TabIndex = 1;
            // 
            // dtp_date
            // 
            this.dtp_date.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_date.Location = new System.Drawing.Point(303, 183);
            this.dtp_date.Name = "dtp_date";
            this.dtp_date.Size = new System.Drawing.Size(315, 22);
            this.dtp_date.TabIndex = 2;
            // 
            // lv_DanhSach
            // 
            this.lv_DanhSach.HideSelection = false;
            this.lv_DanhSach.Location = new System.Drawing.Point(658, 12);
            this.lv_DanhSach.Name = "lv_DanhSach";
            this.lv_DanhSach.Size = new System.Drawing.Size(570, 336);
            this.lv_DanhSach.TabIndex = 3;
            this.lv_DanhSach.UseCompatibleStateImageBehavior = false;
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(61, 255);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(126, 75);
            this.btn_Them.TabIndex = 4;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Location = new System.Drawing.Point(249, 255);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(126, 75);
            this.btn_Sua.TabIndex = 4;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(430, 255);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(126, 75);
            this.btn_Xoa.TabIndex = 4;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1249, 360);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.lv_DanhSach);
            this.Controls.Add(this.dtp_date);
            this.Controls.Add(this.tbx_Name);
            this.Controls.Add(this.tbx_Id);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbx_Id;
        private System.Windows.Forms.TextBox tbx_Name;
        private System.Windows.Forms.DateTimePicker dtp_date;
        private System.Windows.Forms.ListView lv_DanhSach;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Xoa;
    }
}


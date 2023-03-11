
namespace QLSinhvien
{
    partial class qlsvForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.IdStudentLbl = new System.Windows.Forms.Label();
            this.IdStudentTb = new System.Windows.Forms.TextBox();
            this.NameStudentTb = new System.Windows.Forms.TextBox();
            this.NameStudentLbl = new System.Windows.Forms.Label();
            this.DateOfBirthLbl = new System.Windows.Forms.Label();
            this.ClassLbl = new System.Windows.Forms.Label();
            this.GenderLbl = new System.Windows.Forms.Label();
            this.ScholarshipTb = new System.Windows.Forms.TextBox();
            this.ScholarshipLbl = new System.Windows.Forms.Label();
            this.DateOfBirthDtp = new System.Windows.Forms.DateTimePicker();
            this.MaleRbtn = new System.Windows.Forms.RadioButton();
            this.FemaleRbtn = new System.Windows.Forms.RadioButton();
            this.ClassCb = new System.Windows.Forms.ComboBox();
            this.InsertBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.UnSaveBtn = new System.Windows.Forms.Button();
            this.PrintBtn = new System.Windows.Forms.Button();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.qlsvDGV = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qlsvDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ClassCb);
            this.groupBox1.Controls.Add(this.FemaleRbtn);
            this.groupBox1.Controls.Add(this.MaleRbtn);
            this.groupBox1.Controls.Add(this.DateOfBirthDtp);
            this.groupBox1.Controls.Add(this.ClassLbl);
            this.groupBox1.Controls.Add(this.GenderLbl);
            this.groupBox1.Controls.Add(this.ScholarshipTb);
            this.groupBox1.Controls.Add(this.ScholarshipLbl);
            this.groupBox1.Controls.Add(this.DateOfBirthLbl);
            this.groupBox1.Controls.Add(this.NameStudentTb);
            this.groupBox1.Controls.Add(this.NameStudentLbl);
            this.groupBox1.Controls.Add(this.IdStudentTb);
            this.groupBox1.Controls.Add(this.IdStudentLbl);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(929, 155);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chi tiết";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CloseBtn);
            this.groupBox2.Controls.Add(this.PrintBtn);
            this.groupBox2.Controls.Add(this.UnSaveBtn);
            this.groupBox2.Controls.Add(this.SaveBtn);
            this.groupBox2.Controls.Add(this.UpdateBtn);
            this.groupBox2.Controls.Add(this.DeleteBtn);
            this.groupBox2.Controls.Add(this.InsertBtn);
            this.groupBox2.Location = new System.Drawing.Point(12, 173);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(929, 70);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // IdStudentLbl
            // 
            this.IdStudentLbl.AutoSize = true;
            this.IdStudentLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdStudentLbl.Location = new System.Drawing.Point(33, 43);
            this.IdStudentLbl.Name = "IdStudentLbl";
            this.IdStudentLbl.Size = new System.Drawing.Size(91, 17);
            this.IdStudentLbl.TabIndex = 0;
            this.IdStudentLbl.Text = "Mã sinh viên:";
            // 
            // IdStudentTb
            // 
            this.IdStudentTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdStudentTb.Location = new System.Drawing.Point(129, 40);
            this.IdStudentTb.Name = "IdStudentTb";
            this.IdStudentTb.Size = new System.Drawing.Size(173, 22);
            this.IdStudentTb.TabIndex = 1;
            // 
            // NameStudentTb
            // 
            this.NameStudentTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameStudentTb.Location = new System.Drawing.Point(129, 76);
            this.NameStudentTb.Name = "NameStudentTb";
            this.NameStudentTb.Size = new System.Drawing.Size(255, 22);
            this.NameStudentTb.TabIndex = 3;
            // 
            // NameStudentLbl
            // 
            this.NameStudentLbl.AutoSize = true;
            this.NameStudentLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameStudentLbl.Location = new System.Drawing.Point(10, 79);
            this.NameStudentLbl.Name = "NameStudentLbl";
            this.NameStudentLbl.Size = new System.Drawing.Size(114, 17);
            this.NameStudentLbl.TabIndex = 2;
            this.NameStudentLbl.Text = "Họ tên sinh viên:";
            // 
            // DateOfBirthLbl
            // 
            this.DateOfBirthLbl.AutoSize = true;
            this.DateOfBirthLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateOfBirthLbl.Location = new System.Drawing.Point(49, 117);
            this.DateOfBirthLbl.Name = "DateOfBirthLbl";
            this.DateOfBirthLbl.Size = new System.Drawing.Size(75, 17);
            this.DateOfBirthLbl.TabIndex = 4;
            this.DateOfBirthLbl.Text = "Ngày sinh:";
            // 
            // ClassLbl
            // 
            this.ClassLbl.AutoSize = true;
            this.ClassLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClassLbl.Location = new System.Drawing.Point(622, 117);
            this.ClassLbl.Name = "ClassLbl";
            this.ClassLbl.Size = new System.Drawing.Size(63, 17);
            this.ClassLbl.TabIndex = 10;
            this.ClassLbl.Text = "Lớp học:";
            // 
            // GenderLbl
            // 
            this.GenderLbl.AutoSize = true;
            this.GenderLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenderLbl.Location = new System.Drawing.Point(621, 81);
            this.GenderLbl.Name = "GenderLbl";
            this.GenderLbl.Size = new System.Drawing.Size(64, 17);
            this.GenderLbl.TabIndex = 8;
            this.GenderLbl.Text = "Giới tính:";
            // 
            // ScholarshipTb
            // 
            this.ScholarshipTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScholarshipTb.Location = new System.Drawing.Point(691, 40);
            this.ScholarshipTb.Name = "ScholarshipTb";
            this.ScholarshipTb.Size = new System.Drawing.Size(200, 22);
            this.ScholarshipTb.TabIndex = 7;
            // 
            // ScholarshipLbl
            // 
            this.ScholarshipLbl.AutoSize = true;
            this.ScholarshipLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScholarshipLbl.Location = new System.Drawing.Point(612, 43);
            this.ScholarshipLbl.Name = "ScholarshipLbl";
            this.ScholarshipLbl.Size = new System.Drawing.Size(73, 17);
            this.ScholarshipLbl.TabIndex = 6;
            this.ScholarshipLbl.Text = "Học bổng:";
            // 
            // DateOfBirthDtp
            // 
            this.DateOfBirthDtp.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateOfBirthDtp.Location = new System.Drawing.Point(129, 112);
            this.DateOfBirthDtp.Name = "DateOfBirthDtp";
            this.DateOfBirthDtp.Size = new System.Drawing.Size(255, 22);
            this.DateOfBirthDtp.TabIndex = 12;
            // 
            // MaleRbtn
            // 
            this.MaleRbtn.AutoSize = true;
            this.MaleRbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaleRbtn.Location = new System.Drawing.Point(691, 79);
            this.MaleRbtn.Name = "MaleRbtn";
            this.MaleRbtn.Size = new System.Drawing.Size(58, 21);
            this.MaleRbtn.TabIndex = 13;
            this.MaleRbtn.TabStop = true;
            this.MaleRbtn.Text = "Nam";
            this.MaleRbtn.UseVisualStyleBackColor = true;
            // 
            // FemaleRbtn
            // 
            this.FemaleRbtn.AutoSize = true;
            this.FemaleRbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FemaleRbtn.Location = new System.Drawing.Point(755, 79);
            this.FemaleRbtn.Name = "FemaleRbtn";
            this.FemaleRbtn.Size = new System.Drawing.Size(47, 21);
            this.FemaleRbtn.TabIndex = 14;
            this.FemaleRbtn.TabStop = true;
            this.FemaleRbtn.Text = "Nữ";
            this.FemaleRbtn.UseVisualStyleBackColor = true;
            // 
            // ClassCb
            // 
            this.ClassCb.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClassCb.FormattingEnabled = true;
            this.ClassCb.Location = new System.Drawing.Point(691, 116);
            this.ClassCb.Name = "ClassCb";
            this.ClassCb.Size = new System.Drawing.Size(200, 24);
            this.ClassCb.TabIndex = 15;
            // 
            // InsertBtn
            // 
            this.InsertBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InsertBtn.Location = new System.Drawing.Point(36, 21);
            this.InsertBtn.Name = "InsertBtn";
            this.InsertBtn.Size = new System.Drawing.Size(75, 35);
            this.InsertBtn.TabIndex = 0;
            this.InsertBtn.Text = "Thêm";
            this.InsertBtn.UseVisualStyleBackColor = true;
            this.InsertBtn.Click += new System.EventHandler(this.InsertBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteBtn.Location = new System.Drawing.Point(156, 21);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(75, 35);
            this.DeleteBtn.TabIndex = 1;
            this.DeleteBtn.Text = "Xóa";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateBtn.Location = new System.Drawing.Point(276, 21);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(75, 35);
            this.UpdateBtn.TabIndex = 2;
            this.UpdateBtn.Text = "Sửa";
            this.UpdateBtn.UseVisualStyleBackColor = true;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveBtn.Location = new System.Drawing.Point(396, 21);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(75, 35);
            this.SaveBtn.TabIndex = 3;
            this.SaveBtn.Text = "Lưu";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // UnSaveBtn
            // 
            this.UnSaveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnSaveBtn.Location = new System.Drawing.Point(516, 21);
            this.UnSaveBtn.Name = "UnSaveBtn";
            this.UnSaveBtn.Size = new System.Drawing.Size(75, 35);
            this.UnSaveBtn.TabIndex = 4;
            this.UnSaveBtn.Text = "K.Lưu";
            this.UnSaveBtn.UseVisualStyleBackColor = true;
            this.UnSaveBtn.Click += new System.EventHandler(this.UnSaveBtn_Click);
            // 
            // PrintBtn
            // 
            this.PrintBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrintBtn.Location = new System.Drawing.Point(636, 21);
            this.PrintBtn.Name = "PrintBtn";
            this.PrintBtn.Size = new System.Drawing.Size(75, 35);
            this.PrintBtn.TabIndex = 5;
            this.PrintBtn.Text = "In";
            this.PrintBtn.UseVisualStyleBackColor = true;
            this.PrintBtn.Click += new System.EventHandler(this.PrintBtn_Click);
            // 
            // CloseBtn
            // 
            this.CloseBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseBtn.Location = new System.Drawing.Point(816, 21);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(75, 35);
            this.CloseBtn.TabIndex = 6;
            this.CloseBtn.Text = "Thoát";
            this.CloseBtn.UseVisualStyleBackColor = true;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // qlsvDGV
            // 
            this.qlsvDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.qlsvDGV.Location = new System.Drawing.Point(12, 249);
            this.qlsvDGV.Name = "qlsvDGV";
            this.qlsvDGV.RowHeadersWidth = 51;
            this.qlsvDGV.RowTemplate.Height = 24;
            this.qlsvDGV.Size = new System.Drawing.Size(929, 378);
            this.qlsvDGV.TabIndex = 2;
            this.qlsvDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.qlsvDGV_CellClick);
            // 
            // qlsvForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 639);
            this.Controls.Add(this.qlsvDGV);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "qlsvForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DANH SÁCH SINH VIÊN";
            this.Load += new System.EventHandler(this.qlsvForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.qlsvDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox ClassCb;
        private System.Windows.Forms.RadioButton FemaleRbtn;
        private System.Windows.Forms.RadioButton MaleRbtn;
        private System.Windows.Forms.DateTimePicker DateOfBirthDtp;
        private System.Windows.Forms.Label ClassLbl;
        private System.Windows.Forms.Label GenderLbl;
        private System.Windows.Forms.TextBox ScholarshipTb;
        private System.Windows.Forms.Label ScholarshipLbl;
        private System.Windows.Forms.Label DateOfBirthLbl;
        private System.Windows.Forms.TextBox NameStudentTb;
        private System.Windows.Forms.Label NameStudentLbl;
        private System.Windows.Forms.TextBox IdStudentTb;
        private System.Windows.Forms.Label IdStudentLbl;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.Button PrintBtn;
        private System.Windows.Forms.Button UnSaveBtn;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button InsertBtn;
        private System.Windows.Forms.DataGridView qlsvDGV;
    }
}


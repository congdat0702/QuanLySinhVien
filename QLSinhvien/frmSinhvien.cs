using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSinhvien
{
    public partial class qlsvForm : Form
    {
        DataTable dt;
        public qlsvForm()
        {
            InitializeComponent();
        }

        private void qlsvForm_Load(object sender, EventArgs e)
        {
            SetupDataGridView();
        }

        private void SetupDataGridView()
        {
            qlsvDGV.AllowUserToAddRows = false;
            qlsvDGV.AllowUserToDeleteRows = false;
            qlsvDGV.ReadOnly = true;
            qlsvDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dt = new DataTable();
            dt.Columns.Add("Mã SV");
            dt.Columns.Add("Họ và tên SV");
            dt.Columns.Add("Ngày sinh");
            dt.Columns.Add("Giới tính");
            dt.Columns.Add("Học bổng");
            dt.Columns.Add("Lớp");
            FillDataToDataGridView(dt);
            qlsvDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            List<string> listClasses = new List<string>();
            listClasses.Add("19DTHC1");
            listClasses.Add("19DTHC2");
            listClasses.Add("19DTHC3");
            foreach (var item in listClasses)
            {
                ClassCb.Items.Add(item);
            }
            ClassCb.DropDownStyle = ComboBoxStyle.DropDownList;

            SaveBtn.Enabled = UnSaveBtn.Enabled = false;
        }

        private bool ValidateData()
        {
            if (string.IsNullOrWhiteSpace(IdStudentTb.Text))
            {
                return false;
            }
            if (string.IsNullOrWhiteSpace(NameStudentTb.Text))
            {
                return false;
            }
            if (string.IsNullOrWhiteSpace(ScholarshipTb.Text))
            {
                return false;
            }
            if (string.IsNullOrEmpty(ClassCb.Text))
            {
                return false;
            }
            if (!(MaleRbtn.Checked || FemaleRbtn.Checked))
            {
                return false;
            }
            else
            {
                long hocBong;
                int id;
                if (Int64.TryParse(ScholarshipTb.Text, out hocBong) && Int32.TryParse(IdStudentTb.Text, out id))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        private void qlsvDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedRowIndex = e.RowIndex;
            if (selectedRowIndex >= 0)
            {
                IdStudentTb.Text = qlsvDGV.Rows[selectedRowIndex].Cells["Mã SV"].Value.ToString();
                NameStudentTb.Text = qlsvDGV.Rows[selectedRowIndex].Cells["Họ và tên SV"].Value.ToString();
                DateOfBirthDtp.Value = Convert.ToDateTime(qlsvDGV.Rows[selectedRowIndex].Cells["Ngày Sinh"].Value);
                qlsvDGV.Rows[selectedRowIndex].Cells["Giới Tính"].Value.ToString();
                ScholarshipTb.Text = qlsvDGV.Rows[selectedRowIndex].Cells["Học bổng"].Value.ToString();
                ClassCb.SelectedItem = qlsvDGV.Rows[selectedRowIndex].Cells["Lớp"].Value.ToString();
            }
        }
        private void FillDataToDataGridView(DataTable dt)
        {
            //qlsvDGV.Rows.Clear();
            qlsvDGV.DataSource = dt;
        }

        private int IndexId(string IdStudent)
        {
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i][0] != null && dt.Rows[i][0].ToString().CompareTo(IdStudent) == 0)
                {
                    return i;
                }
            }
            return -1;
        }

        private void InsertBtn_Click(object sender, EventArgs e)
        {
            int indexId = IndexId(IdStudentTb.Text);
            if (!ValidateData())
            {
                MessageBox.Show("Nhập sai, vui lòng nhập lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);              
            }
            else if (!(indexId == -1))
            {
                MessageBox.Show("Mã sinh viên bị trùng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Đã có thể lưu vào danh sách sinh viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Typed();
                EnabledInformation();
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa?","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                if (qlsvDGV.SelectedRows.Count > 0)
                {
                    dt.Rows.RemoveAt(qlsvDGV.SelectedRows[0].Index);
                    MessageBox.Show("Đã xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FillDataToDataGridView(dt);
                }
                else
                {
                    MessageBox.Show("Xóa thất bại!", "Thông báo", MessageBoxButtons.OK);
                }
            }    
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            string Gender;
            if (MessageBox.Show("Bạn có chắc chắn muốn sửa lại thông tin?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                if (MaleRbtn.Checked)
                {
                    Gender = "Nam";
                }
                else
                {
                    Gender = "Nữ";
                }
                int indexId = IndexId(IdStudentTb.Text);
                dt.Rows[indexId].SetField("Mã SV", IdStudentTb.Text);
                dt.Rows[indexId].SetField("Họ và tên SV", NameStudentTb.Text);
                dt.Rows[indexId].SetField("Ngày sinh", DateOfBirthDtp.Text);
                dt.Rows[indexId].SetField("Giới tính", Gender);
                dt.Rows[indexId].SetField("Học bổng", ScholarshipTb.Text);
                dt.Rows[indexId].SetField("Lớp", ClassCb.SelectedItem.ToString());
                MessageBox.Show("Sửa lại thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FillDataToDataGridView(dt);
            }

        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            string Gender;
            if (MaleRbtn.Checked)
            {
                Gender = "Nam";
            }
            else
            {
                Gender = "Nữ";
            }
            int indexId = IndexId(IdStudentTb.Text);
            if (indexId == -1)
            {
                dt.Rows.Add(new string[] { IdStudentTb.Text, NameStudentTb.Text, DateOfBirthDtp.Text, Gender, ScholarshipTb.Text, ClassCb.SelectedItem.ToString() });
                MessageBox.Show("Thêm thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FillDataToDataGridView(dt);
            }
            NotTypeYet();
            DisabledInformation();
        }

        private void UnSaveBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hủy lưu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            NotTypeYet();
            DisabledInformation();
        }

        private void PrintBtn_Click(object sender, EventArgs e)
        {
            
            
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát?","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void EnabledInformation()
        {
            IdStudentTb.Enabled = false;
            NameStudentTb.Enabled = false;
            DateOfBirthDtp.Enabled = false;
            ScholarshipTb.Enabled = false;
            MaleRbtn.Enabled = false;
            FemaleRbtn.Enabled = false;
            ClassCb.Enabled = false;
        }

        private void DisabledInformation()
        {
            IdStudentTb.Enabled = true;
            NameStudentTb.Enabled = true;
            DateOfBirthDtp.Enabled = true;
            ScholarshipTb.Enabled = true;
            MaleRbtn.Enabled = true;
            FemaleRbtn.Enabled = true;
            ClassCb.Enabled = true;
        }

        private void NotTypeYet()
        {
            SaveBtn.Enabled = UnSaveBtn.Enabled = false;
            InsertBtn.Enabled = DeleteBtn.Enabled = UpdateBtn.Enabled = true;
        }

        private void Typed()
        {
            SaveBtn.Enabled = UnSaveBtn.Enabled = true;
            InsertBtn.Enabled = DeleteBtn.Enabled = UpdateBtn.Enabled = false;
        }
    }
}

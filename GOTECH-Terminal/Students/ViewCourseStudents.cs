using GOTECH.Crypto;
using GOTECH.Data;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GOTECH.Students
{
    public partial class ViewCourseStudents : Form
    {
        private int COURSE_ID = 0;
        private List<Data.Students> StudentsList = Lists.StudentsList;
        private DbEntities db = new DbEntities();

        public ViewCourseStudents(int COURSE_Id,string LabelText)
        {
            InitializeComponent();
            this.COURSE_ID = COURSE_Id;
            this.LabelText.Text = LabelText;
        }

        private void ViewTrainer_Load(object sender, EventArgs e)
        {
            DataGridViewImageColumn cell = (DataGridViewImageColumn)dataGridViewStudents.Columns[5];
            cell.Image = Properties.Resources.Garbage_Closed;
            cell.ImageLayout = DataGridViewImageCellLayout.Zoom;
            DataGrid();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DataGrid()
        {
            dataGridViewStudents.Rows.Clear();
            ArrayList idList = new ArrayList();
            ArrayList SNameList = new ArrayList();
            ArrayList FNameList = new ArrayList();
            ArrayList EmailList = new ArrayList();
            ArrayList ContactList = new ArrayList();


            foreach (var std in StudentsList.Where(c => c.Course_Id == COURSE_ID))
            {
                idList.Add(std.Student_Id);
                SNameList.Add(std.Name);
                FNameList.Add(std.FatherName);
                EmailList.Add(std.Email);
                ContactList.Add(std.Contact);
            }

            int n = 0;
            for (int i = 0; i <= idList.ToArray().Length - 1; i++)
            {
                n = dataGridViewStudents.Rows.Add();
                dataGridViewStudents.Rows[n].Cells[0].Value =idList[i].ToString();
                dataGridViewStudents.Rows[n].Cells[1].Value = Gulipso.DataDecrypt(SNameList[i].ToString());
                dataGridViewStudents.Rows[n].Cells[2].Value = Gulipso.DataDecrypt(FNameList[i].ToString());
                dataGridViewStudents.Rows[n].Cells[3].Value = Gulipso.DataDecrypt(EmailList[i].ToString());
                dataGridViewStudents.Rows[n].Cells[4].Value = Gulipso.DataDecrypt(ContactList[i].ToString());
            }
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            NewStudent newstdform = new NewStudent(COURSE_ID);
            newstdform.ShowDialog();
        }

        private void updateGrid()
        {
            this.Refresh();
            StudentsList = Lists.StudentsList;
            DataGrid();
        }

        private void ViewCourseStudents_Activated(object sender, EventArgs e)
        {
            updateGrid();
        }

        private void dataGridViewStudents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                string std_batch_id = dataGridViewStudents.Rows[e.RowIndex].Cells[0].Value.ToString();

                int std_id = Lists.StudentsList.Where(c => c.Student_Id == std_batch_id).Select(c => c.ID).FirstOrDefault();

                DialogResult result = MessageBox.Show("Are you sure you want to delete this student?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);

                if (result == DialogResult.Yes)
                {
                    var std = db.Students.Where(c => c.ID == std_id).FirstOrDefault();

                    db.Entry(std).State = EntityState.Deleted;
                    db.SaveChanges();

                    DbEntities dbrefresh = new DbEntities();
                    Lists.StudentsList = dbrefresh.Students.ToList();
                    dbrefresh.Dispose();

                    this.updateGrid();
                }
                else
                {
                    return;
                }
            }
        }

        private void dataGridViewStudents_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dataGridViewStudents.Columns[e.ColumnIndex].HeaderText == "Delete")
            {
                dataGridViewStudents.Cursor = Cursors.Hand;
            }
            else
                dataGridViewStudents.Cursor = Cursors.Default;
        }

        private void dataGridViewStudents_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            dataGridViewStudents.Cursor = Cursors.Default;
        }
    }
}

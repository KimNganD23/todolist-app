using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;

namespace ToDoList
{
    public partial class ToDoList : Form
    {
        void checkData()
        {
            if (!Directory.Exists("Database"))
            {
                Directory.CreateDirectory("Database");
            }
            if (!File.Exists(@"Database\Data.db"))
            {
                SQLiteConnection.CreateFile(@"Database\Data.db");
                SQLiteConnection Cn = new SQLiteConnection(@"Data Source=Database\Data.db;Version=3");
                string Command = "CREATE TABLE 'TODOLIST' ( 'ID_TASK' TEXT NOT NULL,'STATUS' TEXT NOT NULL,'TITLE' TEXT NOT NULL,'PRIORITY' TEXT NOT NULL,'TIME_BEGIN' TEXT NOT NULL,'TIME_END' TEXT NOT NULL,'NOTE' TEXT);";
                SQLiteCommand cm = new SQLiteCommand(Command, Cn);
                Cn.Open();
                cm.ExecuteNonQuery();
                Cn.Close();

            }
        }
        public static DataTable Data(string Command1)
        {
            DataTable DT = new DataTable();
            using (SQLiteConnection con = new SQLiteConnection(@"Data Source=Database\Data.db;Version=3"))
            {
                using (SQLiteCommand cmd = new SQLiteCommand(Command1, con))
                {
                    con.Open();
                    SQLiteDataReader Dr = cmd.ExecuteReader();
                    DT.Load(Dr);
                    con.Close();
                }
            }
            return DT;
        }
        public void Update_Database_Default()
        {
            Data_View.DataSource = null;
            Data_View.ReadOnly = true;
            string cmd = "SELECT STATUS,TITLE,PRIORITY,TIME_BEGIN,TIME_END,NOTE FROM TODOLIST";
            Data_View.DataSource = Data(cmd);
            Data_View.Columns[0].HeaderText = "Trạng thái";
            Data_View.Columns[0].Width = 120;
            Data_View.Columns[1].HeaderText = "Nhiệm vụ";
            Data_View.Columns[1].Width = 200;
            Data_View.Columns[2].HeaderText = "Mức độ ưu tiên";
            Data_View.Columns[2].Width = 120;
            Data_View.Columns[3].HeaderText = "Thời gian bắt đầu";
            Data_View.Columns[3].Width = 180;
            Data_View.Columns[4].HeaderText = "Thời gian hoàn thành";
            Data_View.Columns[4].Width = 180;
            Data_View.Columns[5].HeaderText = "Ghi chú";
            Data_View.Columns[5].Width = 200;
            Data_View.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
        void load_form()
        {
            Color C = System.Drawing.ColorTranslator.FromHtml("#F5F7F8");
            Color C1 = System.Drawing.ColorTranslator.FromHtml("#F4CE14");
            Color C2 = System.Drawing.ColorTranslator.FromHtml("#45474B");
            Color C3 = System.Drawing.ColorTranslator.FromHtml("#495E57");
            BackColor = C;
            grbx.BackColor = C1;
            grDT.BackColor = C2;
            cplt_btn.BackColor = C3;
            incplt_btn.BackColor = C3;
            exp_btn.BackColor = C3;
            Prg_btn.BackColor = C3;
            cc_btn.BackColor = C3;
        }
        public ToDoList()
        {
            InitializeComponent();
            load_form();
            checkData();
            Update_Database_Default();
            choose_cb.SelectedIndex = 0;
            Stt_cb.SelectedIndex = 0;
        }

        private void Add_btn_Click(object sender, EventArgs e)
        {
            string ID = DateTime.Now.ToString("ssmmhhddMMyy");
            string Command = $"INSERT INTO TODOLIST VALUES ('{ID}','{Stt_cb.SelectedItem.ToString()}','{task_txt.Text.ToString()}','{choose_cb.SelectedItem.ToString()}','{dateTimeBegin.Value.ToString("dd/MM/yy")}','{dateTimeEnd.Value.ToString("dd/MM/yy")}','{Note_txt.Text}');";
            if (task_txt.Text == "")
            {
                MessageBox.Show("Hãy nhập tên nhiệm vụ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    SQLiteConnection con = new SQLiteConnection(@"Data Source = Database\Data.db;Version=3");
                    SQLiteCommand cmd = new SQLiteCommand(Command, con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    Update_Database_Default();
                    MessageBox.Show("Thêm Thành công");
                }
                catch (SQLiteException loi)
                {
                    MessageBox.Show(loi.Message, "ERROR SQL");
                }
            }
        }
        private void Edit_btn_Click(object sender, EventArgs e)
        {
            DataTable DT = Data("SELECT ID_TASK FROM TODOLIST");
            string command;
            string ID = DT.Rows[Data_View.CurrentRow.Index][0].ToString();
            try
            {
                using (SQLiteConnection cn = new SQLiteConnection(@"Data Source=Database\Data.db;Version=3"))
                {
                    command = $"UPDATE TODOLIST SET STATUS ='{Stt_cb.SelectedItem}',TITLE='{task_txt.Text}',PRIORITY='{choose_cb.SelectedItem}',TIME_BEGIN='{dateTimeBegin.Value.ToString("dd/MM/yy")}',TIME_END='{dateTimeEnd.Value.ToString("dd/MM/yy")}',NOTE='{Note_txt.Text}' WHERE ID_TASK ='{ID}';";
                    using (SQLiteCommand cmd = new SQLiteCommand(command, cn))
                    {
                        cn.Open();
                        cmd.ExecuteNonQuery();
                        cn.Close();
                    }
                    Update_Database_Default();
                    MessageBox.Show("Sửa thành công");
                }
            }
            catch (SQLiteException loi)
            {
                MessageBox.Show(loi.Message, "ERROR SQL");
            }
        }

        private void Data_View_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index_select = Data_View.CurrentRow.Index;
            Stt_cb.SelectedItem = Data_View.Rows[index_select].Cells[0].Value.ToString();
            task_txt.Text = Data_View.Rows[index_select].Cells[1].Value.ToString();
            choose_cb.SelectedItem = Data_View.Rows[index_select].Cells[2].Value.ToString();
            dateTimeBegin.Value = DateTime.Parse(Data_View.Rows[index_select].Cells[3].Value.ToString());
            dateTimeEnd.Value = DateTime.Parse(Data_View.Rows[index_select].Cells[4].Value.ToString());
            Note_txt.Text = Data_View.Rows[index_select].Cells[5].Value.ToString();
        }

        private void Del_btn_Click(object sender, EventArgs e)
        {
            DataTable DT = Data("SELECT ID_TASK FROM TODOLIST");
            string command;
            string ID = DT.Rows[Data_View.CurrentRow.Index][0].ToString();
            try
            {

                using (SQLiteConnection cn = new SQLiteConnection(@"Data Source =Database\Data.db;Version=3"))
                {
                    command = $"DELETE FROM TODOLIST WHERE ID_TASK='{ID}'";
                    using (SQLiteCommand cm = new SQLiteCommand(command, cn))
                    {
                        cn.Open();
                        cm.ExecuteNonQuery();
                        cn.Close();
                    }
                }
                Update_Database_Default();
                MessageBox.Show("Xoá thành công");
            }
            catch (SQLiteException loi)
            {
                MessageBox.Show(loi.Message, "ERROR SQL");
            }
        }

        private void Cplt_btn_Click(object sender, EventArgs e)
        {
            DataTable Dt = Data("SELECT STATUS, TITLE, PRIORITY, TIME_BEGIN, TIME_END, NOTE FROM TODOLIST WHERE STATUS ='Hoàn thành'");
            Data_View.DataSource = Dt;
            edit_btn.Enabled = false;
            del_btn.Enabled = false;
            add_btn.Enabled = false;
        }

        private void Incplt_btn_Click(object sender, EventArgs e)
        {
            DataTable Dt = Data("SELECT STATUS, TITLE, PRIORITY, TIME_BEGIN, TIME_END, NOTE FROM TODOLIST WHERE STATUS ='Chưa hoàn thành'");
            Data_View.DataSource = Dt;
            edit_btn.Enabled = false;
            del_btn.Enabled = false;
            add_btn.Enabled = false;
        }

        private void Exp_btn_Click(object sender, EventArgs e)
        {
            DataTable Dt = Data("SELECT STATUS, TITLE, PRIORITY, TIME_BEGIN, TIME_END, NOTE FROM TODOLIST WHERE STATUS ='Quá Hạn'");
            Data_View.DataSource = Dt;
            edit_btn.Enabled = false;
            del_btn.Enabled = false;
            add_btn.Enabled = false;
        }

        private void Prg_btn_Click(object sender, EventArgs e)
        {
            DataTable Dt = Data("SELECT STATUS, TITLE, PRIORITY, TIME_BEGIN, TIME_END, NOTE FROM TODOLIST WHERE STATUS ='Đang làm'");
            Data_View.DataSource = Dt;
            edit_btn.Enabled = false;
            del_btn.Enabled = false;
            add_btn.Enabled = false;
        }

        private void Cc_btn_Click(object sender, EventArgs e)
        {
            DataTable Dt = Data("SELECT STATUS, TITLE, PRIORITY, TIME_BEGIN, TIME_END, NOTE FROM TODOLIST WHERE STATUS ='Bị huỷ'");
            Data_View.DataSource = Dt;
            edit_btn.Enabled = false;
            del_btn.Enabled = false;
            add_btn.Enabled = false;
        }

        private void Reset_btn_Click(object sender, EventArgs e)
        {
            DataTable Dt = Data("SELECT STATUS, TITLE, PRIORITY, TIME_BEGIN, TIME_END, NOTE FROM TODOLIST");
            Data_View.DataSource = Dt;
            edit_btn.Enabled = true;
            del_btn.Enabled = true;
            add_btn.Enabled = true;
        }

        private void DateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            DataTable Dt = Data($"SELECT STATUS, TITLE, PRIORITY, TIME_BEGIN, TIME_END, NOTE FROM TODOLIST WHERE TIME_END='{dateTime.Value.ToString("dd/MM/yy")}'");
            Data_View.DataSource = Dt;
        }

        private void PrioritySelect_Click(object sender, EventArgs e)
        {
            List<string> Data_list = new List<string>();
            foreach(var item in choose_cb.Items)
            {
                Data_list.Add(item.ToString());
            }
            DataTable Dt = Data($"SELECT STATUS, TITLE, PRIORITY, TIME_BEGIN, TIME_END, NOTE FROM TODOLIST WHERE PRIORITY='{Data_list[0]}'");
           for(int i=1;i<Data_list.Count;i++)
            {
                DataRow[] DTR = Data($"SELECT STATUS, TITLE, PRIORITY, TIME_BEGIN, TIME_END, NOTE FROM TODOLIST WHERE PRIORITY = '{Data_list[i]}'").Select();
                foreach(DataRow item in DTR)
                {
                    Dt.ImportRow(item);
                }
                Data_View.DataSource = Dt;
            }
            edit_btn.Enabled = false;
            del_btn.Enabled = false;
            add_btn.Enabled = false;
        }

        private void Show_btn_Click(object sender, EventArgs e)
        {
            DataTable DT = Data($"SELECT STATUS, TITLE, PRIORITY, TIME_BEGIN, TIME_END, NOTE FROM TODOLIST WHERE TITLE like '%{timkiem_txt.Text}%'");
            Data_View.DataSource = DT;
            edit_btn.Enabled = false;
            del_btn.Enabled = false;
            add_btn.Enabled = false;
        }
    }
}



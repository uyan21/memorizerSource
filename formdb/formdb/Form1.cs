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
using System.Threading;

namespace formdb
{
    public partial class win : Form

    {
        static string path = "data/";
        static string dataRoot = @"Data Source=";
        static string extension = ".db";
        SQLiteConnection conn;
        SQLiteCommand cmd;
        SQLiteDataReader rdr;
        //질문 리스트
        List<String> qList = new List<string>();
        //답 리스트
        List<String> aList = new List<string>();
        int count = 1;
        int qnum;
        int rnum = 0;
        public win()
        {
            InitializeComponent();
        }

        private void win_Load(object sender, EventArgs e)

        {
            refreshList();
        }
        private void refreshList()
        {
            dbList.Items.Clear();
            System.IO.DirectoryInfo di =
                new System.IO.DirectoryInfo(path);
            if (!di.Exists) { di.Create(); }
            string[] files;
            files = Directory.GetFiles(path);
            foreach(string f in files){
                dbList.Items.Add(f.Replace(path, "")
                    .Replace(extension, ""));
            }
            
        }
        private void listChanged(object sender,EventArgs e)
        {
            if (tabControl1.SelectedIndex==0)
            {
                qList.Clear();
                aList.Clear();
                count = 1;
                conn = new SQLiteConnection(dataRoot + path +
                    dbList.SelectedItem.ToString() + extension);

                conn.Open();
                cmd = new SQLiteCommand(conn);
                cmd.CommandText = "SELECT COUNT(*) FROM datatable;";
                using (rdr = cmd.ExecuteReader())
                {
                    rdr.Read();
                    qnum = rdr.GetInt32(0);
                    cmd.Dispose();
                    cmd = new SQLiteCommand(conn);
                    cmd.CommandText = "SELECT * FROM datatable ORDER BY RANDOM();";
                    rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {

                        qList.Add(rdr[1].ToString());
                        aList.Add(rdr[2].ToString());
                    }
                }
                cmd.Dispose();
                conn.Close();
                MessageBox.Show("총 "+ qnum.ToString()+"문제 입니다.");
                drawing(count);
            }
        }
        private void answer_KeyPress(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode == Keys.Enter&dbList.SelectedItem!=null)

            {
                //MessageBox.Show(qList[count - 1] + " " + aList[count - 1]);
                string typing;
                typing = answer.Text.Replace("\r\n", "");
                typing = typing.Replace(" ", "");
                if (typing.Equals(aList[count - 1]))
                {
                    deter.ForeColor = Color.FromArgb(0, 0, 0);
                    deter.Text = "맞았습니다.";
                    rnum++;
                }
                else
                {
                    deter.ForeColor = Color.FromArgb(255, 0, 0);
                    deter.Text = "틀렸습니다.\n" +
                        "오답: " + typing + "\n" +
                        "정답: " + aList[count - 1];
                }
                if (qnum > count)
                {
                    count++;

                }
                else
                {
                    count = 1;
                    MessageBox.Show("총 "+qnum+"문제 중"+rnum+"문제를 맞추었습니다.");
                    rnum =0;
                }
                answer.Text = "";
                
                drawing(count);

            }
        }
        private void dbAdd(object sender, EventArgs e)
        {
            if (dbName.Text!="")
            {
                foreach(string name in dbList.Items)
                {
                    if (name == dbName.Text)
                    {
                        MessageBox.Show("이미 존재하는 DB파일 입니다.");
                        return;
                    }
                }
                conn = new SQLiteConnection(dataRoot + path + dbName.Text + extension);
                conn.Open();
                cmd = new SQLiteCommand(conn);
                cmd.CommandText = "CREATE TABLE dataTable(id integer PRIMARY KEY AUTOINCREMENT," +
                    "Question char(100),Answer char(100));";
                cmd.ExecuteNonQuery();
                //rdr = cmd.ExecuteReader();
                //while (rdr.Read()){MessageBox.Show(rdr[0].ToString());}
                cmd.Dispose();
                conn.Close();
                refreshList();
                MessageBox.Show("DB 생성");

            }
            
            
        }
        private void insert_field(object sender,EventArgs e)
        {
            if (dbList.SelectedItem != null)
            {
                conn = new SQLiteConnection(dataRoot + path + 
                    dbList.SelectedItem.ToString() + extension);
                
                conn.Open();
                cmd = new SQLiteCommand(conn);
                cmd.CommandText = "INSERT INTO datatable(Question,Answer) " +
                    "VALUES ('" + addQ.Text.ToString() + "','" + 
                    addA.Text.ToString() + "');";
                cmd.ExecuteNonQuery();
                /*
                cmd.CommandText = "SELECT * FROM datatable ORDER BY RANDOM();";
                rdr = cmd.ExecuteReader();
                
                string k = "";
                while (rdr.Read())
                {
                    k+=rdr[0].ToString()+";"+rdr[1].ToString()+";"+
                        rdr[2].ToString()+"\n";
                }*/
                MessageBox.Show("필드 추가 됨.");
                conn.Close();
                addQ.Text = "";
                addA.Text = "";
            }
        }
        private void eInsert_field(object sender,KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                insert_field(sender, e);
            }
        }
        private void drawing(int n)
        {
            question.Text = qList[n-1];
            qnumber.Text = count.ToString() + "/" + qnum.ToString();
        }
    }
}

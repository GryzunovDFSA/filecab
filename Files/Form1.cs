using Npgsql;
using System.Data;
using System.Net;
using System.Xml.Linq;

namespace Files
{
    public partial class Form1 : Form
    {
        NpgsqlConnection con = new NpgsqlConnection("Host=localhost;Port=5432;Database=files;Username=postgres;Password=25481");
        public Form1()
        {
            InitializeComponent();
            loadDataDocument();
            connectComboBoxWithData();
            loadDataCard();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var random = new Random();
            int id = random.Next(0, 10000000);
            if (textBox1.Text == "" || textBox2.Text == "" || comboBox1.Text == "")
                MessageBox.Show("Ошибка! Необходимо заполнить поля!");
            else
            {
                string name = textBox1.Text;
                string description = textBox2.Text;
                int address = findIdEmployee(comboBox1.Text);
                con.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("insert into document values('" + name + "', '" + description + "', " + address + ", " + id + ")", con);
                cmd.ExecuteNonQuery();
                con.Close();

                loadDataDocument();
            }

        }

        private void loadDataDocument()
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            string sql = ("SELECT * FROM document");
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, con);
            ds.Reset();
            da.Fill(ds);
            dt = ds.Tables[0];
            dataGridView1.DataSource = dt;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.Columns["document_name"].HeaderText = "Название документа";
            dataGridView1.Columns["detailed_description"].HeaderText = "Описание";
            dataGridView1.Columns["addressee_id"].HeaderText = "ID адресата";
            dataGridView1.Columns["document_id"].HeaderText = "ID документа";
            con.Close();
        }

        private void connectComboBoxWithData()
        {
            con.Open();

            string sql = ("SELECT * FROM employee");
            DataTable tbl1 = new DataTable();
            NpgsqlDataAdapter da1 = new NpgsqlDataAdapter(sql, con);
            da1.Fill(tbl1);
            comboBox1.DataSource = tbl1;
            comboBox1.DisplayMember = "surname";
            comboBox1.ValueMember = "employee_id";
            comboBox1.SelectedIndex = -1;
            comboBox1.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;

            DataTable tbl4 = new DataTable();
            NpgsqlDataAdapter da4 = new NpgsqlDataAdapter(sql, con);
            da4.Fill(tbl4);
            comboBox3.DataSource = tbl4;
            comboBox3.DisplayMember = "surname";
            comboBox3.ValueMember = "employee_id";
            comboBox3.SelectedIndex = -1;
            comboBox3.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBox3.AutoCompleteMode = AutoCompleteMode.SuggestAppend;

            sql = ("SELECT * FROM classifier");
            DataTable tbl2 = new DataTable();
            NpgsqlDataAdapter da2 = new NpgsqlDataAdapter(sql, con);
            da2.Fill(tbl2);
            comboBox2.DataSource = tbl2;
            comboBox2.DisplayMember = "class_name";
            comboBox2.ValueMember = "class_id";
            comboBox2.SelectedIndex = -1;
            comboBox2.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBox2.AutoCompleteMode = AutoCompleteMode.SuggestAppend;

            sql = ("SELECT * FROM document");
            DataTable tbl3 = new DataTable();
            NpgsqlDataAdapter da3 = new NpgsqlDataAdapter(sql, con);
            da3.Fill(tbl3);
            comboBox4.DataSource = tbl3;
            comboBox4.DisplayMember = "document_id";
            comboBox4.ValueMember = "document_id";
            comboBox4.SelectedIndex = -1;
            comboBox4.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBox4.AutoCompleteMode = AutoCompleteMode.SuggestAppend;

            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || comboBox1.Text == "")
                MessageBox.Show("Ошибка! Необходимо заполнить поля!");
            else
            {
                if (dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[3].Value.ToString() == "")
                {
                    MessageBox.Show("Выберите строку, данные которой будут изменены!");
                }
                else
                {
                    string name = textBox1.Text;
                    string description = textBox2.Text;
                    int address = findIdEmployee(comboBox1.Text);

                    con.Open();
                    NpgsqlCommand cmd = new NpgsqlCommand("update document set document_name = '" + name + "', detailed_description = '" + description + "', addressee_id = " + address + " where document_id = " + int.Parse(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[3].Value.ToString()), con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    loadDataDocument();
                }
            }
        }

        private int findIdEmployee(string surname)
        {
            con.Open();
            string sql = "select employee_id from employee " + " where surname = '" + surname+"'";
            using (NpgsqlCommand command = new NpgsqlCommand(sql, con))
            {
                int val = 0;
                NpgsqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    val = int.Parse(reader[0].ToString());

                }
                con.Close();
                return val;
            }
        }

        private int findIdClass(string name)
        {
            con.Open();
            string sql = "select class_id from classifier " + " where class_name = '" + name+"'";
            using (NpgsqlCommand command = new NpgsqlCommand(sql, con))
            {
                int val = 0;
                NpgsqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    val = int.Parse(reader[0].ToString());

                }
                con.Close();
                return val;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[3].Value.ToString() == "")
            {
                MessageBox.Show("Выберите строку для удаления!");
            }
            else
            {
                con.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("delete from document where document_id = " + int.Parse(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[3].Value.ToString()), con);
                cmd.ExecuteNonQuery();
                con.Close();
                loadDataDocument();
            }
        }

        private void loadDataCard()
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            string sql = ("SELECT * FROM card");
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, con);
            ds.Reset();
            da.Fill(ds);
            dt = ds.Tables[0];
            dataGridView2.DataSource = dt;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.Columns["author_id"].HeaderText = "ID автора";
            dataGridView2.Columns["class_id"].HeaderText = "Тип документа";
            dataGridView2.Columns["short_description"].HeaderText = "Описание";
            dataGridView2.Columns["document_id"].HeaderText = "ID документа";
            dataGridView2.Columns["inventory_№"].HeaderText = "Инвентарный номер";
            dataGridView2.Columns["date_of_creation"].HeaderText = "Дата создания";
            con.Close();
        }
       
        private void button6_Click(object sender, EventArgs e)
        {
            var random = new Random();
            int inventory_number = random.Next(0, 10000000);
            if (textBox3.Text == "" || dateTimePicker1.Text == "" || comboBox2.Text == "" || comboBox3.Text == "" || comboBox4.Text == "")
                MessageBox.Show("Ошибка! Необходимо заполнить поля!");
            else
            {
                int author_id = findIdEmployee(comboBox3.Text);
                int type_document = findIdClass(comboBox2.Text);
                string description = textBox3.Text;
                int document_id = int.Parse(comboBox4.Text);
                DateOnly date = DateOnly.FromDateTime(dateTimePicker1.Value);
                con.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("insert into card values(" + author_id + ", " + type_document + ", '" + description + "', " + document_id + ", " + inventory_number + ", '" + date + "')", con);
                cmd.ExecuteNonQuery();
                con.Close();

                loadDataCard();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == "" || dateTimePicker1.Text == "" || comboBox2.Text == "" || comboBox3.Text == "" || comboBox4.Text == "")
                MessageBox.Show("Ошибка! Необходимо заполнить поля!");
            else
            {
                if (dataGridView2.Rows[dataGridView2.CurrentRow.Index].Cells[4].Value.ToString() == "")
                    MessageBox.Show("Выберите строку, данные которой будут изменены!");
                else
                {
                    int author_id = findIdEmployee(comboBox3.Text);
                    int type_document = findIdClass(comboBox2.Text);
                    string description = textBox3.Text;
                    int document_id = int.Parse(comboBox4.Text);
                    DateOnly date = DateOnly.FromDateTime(dateTimePicker1.Value);
                    con.Open();
                    NpgsqlCommand cmd = new NpgsqlCommand("update card set author_id = " + author_id + ", class_id = " + type_document + ", short_description = '" + description + "', document_id = " + document_id + ", date_of_creation = '" + date + "' where inventory_№ = " + int.Parse(dataGridView2.Rows[dataGridView2.CurrentRow.Index].Cells[4].Value.ToString()), con);
                    cmd.ExecuteNonQuery();
                    con.Close();

                    loadDataCard();
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dataGridView2.Rows[dataGridView2.CurrentRow.Index].Cells[4].Value.ToString() == "")
            {
                MessageBox.Show("Выберите строку для удаления!");
            }
            else
            {
                con.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("delete from card where inventory_№ = " + int.Parse(dataGridView2.Rows[dataGridView2.CurrentRow.Index].Cells[4].Value.ToString()), con);
                cmd.ExecuteNonQuery();
                con.Close();
                loadDataCard();
            }
        }
    }
}
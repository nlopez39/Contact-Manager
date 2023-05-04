using System.Data;
using System.Data.SqlClient;

namespace TelephonePart2
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        //database connection
        SqlConnection connect = new SqlConnection("Data Source=SPMNLOPEZ\\SQLEXPRESS;Initial Catalog=Phone;Integrated Security=True");

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void NewButton_Click(object sender, EventArgs e)
        {
            Clear();

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {

            //save a new contact to the DB 
            SqlCommand db_saver = new SqlCommand("Insert INTO Telephone (Id,Name, Last, Number, Type,Email) VALUES (@Id, @Name, @Last, @Number, @Type, @Email)", connect);
            connect.Open();
            db_saver.Parameters.AddWithValue("@Id", idBox.Text);
            db_saver.Parameters.AddWithValue("@Name", FirstBox.Text);
            db_saver.Parameters.AddWithValue("@Last", LastBox.Text);
            db_saver.Parameters.AddWithValue("@Number", PhoneBox.Text);
            db_saver.Parameters.AddWithValue("@Type", comboBox1.SelectedItem.ToString());
            db_saver.Parameters.AddWithValue("@Email", EmailBox.Text);

            db_saver.ExecuteNonQuery();
            connect.Close();
            Display();
            //MessageBox.Show("Database was saved");


        }

        private void Display()
        {


            connect.Open();
            //we want to display the items from the db onto the ListView
            SqlCommand db = new SqlCommand("Select * from Telephone", connect);
            //read the items from the db
            SqlDataReader reader = db.ExecuteReader();
            //clear the listView  
            listView1.Items.Clear();
            //set view property
            listView1.View = View.Details;

            //var items = new List<ListViewItem>();
            while (reader.Read())
            {
                ListViewItem adder = new ListViewItem(reader["Id"].ToString());
                adder.SubItems.Add(reader["Name"].ToString());
                adder.SubItems.Add(reader["Last"].ToString());
                adder.SubItems.Add(reader["Number"].ToString());
                adder.SubItems.Add(reader["Type"].ToString());
                adder.SubItems.Add(reader["Email"].ToString());
                listView1.Items.Add(adder);
            }
            reader.Close();
            db.Dispose();
            connect.Close();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            connect.Open();
            var contactId = listView1.FocusedItem.Text;

            SqlTransaction trans = connect.BeginTransaction();//will allow the db to change or not
            SqlCommand db_delete = new SqlCommand("DELETE From Telephone WHERE Id =@Id ", connect);
            db_delete.Transaction = trans;
            //AddWithValue to assign id, sql server will implicitly convert id to int id
            db_delete.Parameters.AddWithValue("@Id", contactId);
            var should_be_one = db_delete.ExecuteNonQuery();
            if (should_be_one == 1) //delete only one row at a time 
            {
                trans.Commit();//if we chose only one row then delete ; save changes invoked by the transaction 
            }
            else
            {
                trans.Rollback();//undo changes made by the transaction
                throw new Exception("An attempt to delete multiple rows was detected");
            }
            connect.Close();
            Clear();
            Display();




        }

        private void button1_Click(object sender, EventArgs e)
        {
            Display();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem item = listView1.SelectedItems[0];
                idBox.Text = item.SubItems[0].Text;
                FirstBox.Text = item.SubItems[1].Text;
                LastBox.Text = item.SubItems[2].Text;
                PhoneBox.Text = item.SubItems[3].Text;
                comboBox1.SelectedItem = item.SubItems[4].Text;
                EmailBox.Text = item.SubItems[5].Text;

            }
        }
        private void Clear()
        {
            idBox.Clear();
            FirstBox.Clear();
            LastBox.Clear();
            PhoneBox.Clear();
            comboBox1.SelectedIndex = -1;
            EmailBox.Clear();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            connect.Open();


            SqlCommand db_update = new SqlCommand("UPDATE Telephone SET Name=@Name, Last=@Last, Number=@Number, Type=@Type,Email=@Email WHERE  Id=@Id ", connect);

            //AddWithValue to assign id, sql server will implicitly convert id to int id
            db_update.Parameters.AddWithValue("@Id", idBox.Text);
            db_update.Parameters.AddWithValue("@Name", FirstBox.Text);
            db_update.Parameters.AddWithValue("@Last", LastBox.Text);
            db_update.Parameters.AddWithValue("@Number", PhoneBox.Text);
            db_update.Parameters.AddWithValue("@Type", comboBox1.SelectedIndex);
            db_update.Parameters.AddWithValue("@Email", EmailBox.Text);
            db_update.ExecuteNonQuery();

            connect.Close();
            Clear();
            Display();
        }
    }
}
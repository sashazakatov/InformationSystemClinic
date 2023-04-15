using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace MK_K
{
    public partial class Form1 : Form
    {
        private SqlConnection sqlConnection = null;

        public Form1()
        {
            InitializeComponent();
        }
 


        //conect бази даних з прогою
        private void Form1_Load_1(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mK_BDDataSet.Data_base". При необходимости она может быть перемещена или удалена.
            this.data_baseTableAdapter.Fill(this.mK_BDDataSet.Data_base);


            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["Boot"].ConnectionString);

            sqlConnection.Open();

            if (sqlConnection.State == ConnectionState.Open)
            {
                MessageBox.Show("yes_connection");
            }
            else
            {
                MessageBox.Show("Not_connection");
            }
        }
        //додати дані в базу
        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("INSERT INTO Data_base(Name,Surname,Date_birth,Appointment_date,Doctor_who_needs_appointment,The_reason_for_appointment,Medical_history) VALUES (  @Name, @Surname, @Date_birth, @Appointment_date, @Doctor_who_needs_appointment, @The_reason_for_appointment, @Medical_history)", sqlConnection);

            command.Parameters.AddWithValue("Name", Name1.Text);
            command.Parameters.AddWithValue("Surname", Surname1.Text);
            command.Parameters.AddWithValue("Date_birth", Date_birth1.Text);
            command.Parameters.AddWithValue("Appointment_date", AppointmentDate1.Text);
            command.Parameters.AddWithValue("Doctor_who_needs_appointment", Doctor_who_needs_appointment1.Text);
            command.Parameters.AddWithValue("The_reason_for_appointment", The_reason_for_appointment1.Text);
            command.Parameters.AddWithValue("Medical_history", Medical_history1.Text);


            MessageBox.Show(command.ExecuteNonQuery().ToString());

            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM Data_base ", sqlConnection);

            DataSet dataSet = new DataSet();

            dataAdapter.Fill(dataSet);

            dataGridView1.DataSource = dataSet.Tables[0];
        }
        //видалення даних
       
        private void button2_Click_1(object sender, EventArgs e)
        {
            var id = textBox9.Text;
            var deleteQuery = $"delete from  Data_base Where id_Patient = {id}";

            var command = new SqlCommand(deleteQuery, sqlConnection);
            command.ExecuteNonQuery();

            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM Data_base ", sqlConnection);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];
        }

        // Редагування даних
        private void button6_Click(object sender, EventArgs e)
        {
            var Id_Patient = textBox_Id.Text;
            var Names = Name.Text;
            var Surnames = Surname.Text;
            var Date_births = Date_birth.Text;
            var AppointmentDates = AppointmentDate.Text;
            var Doctor_who_needs_appointments = Doctor_who_needs_appointment.Text;
            var The_reason_for_appointments = The_reason_for_appointment.Text;
            var Medical_historys = Medical_history.Text;

            var deleteQuer = $"UPDATE Data_base SET  Name = {Names},Surname = {Surnames}, Date_birth = {Date_births},Appointment_date = {AppointmentDates},Doctor_who_needs_appointment = {Doctor_who_needs_appointments},The_reason_for_appointment = {The_reason_for_appointments},     Medical_history = {Medical_historys} WHERE Id_Patient = {Id_Patient}";

            var commands = new SqlCommand(deleteQuer, sqlConnection);
            commands.ExecuteNonQuery();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM Data_base ", sqlConnection);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }
    }
}

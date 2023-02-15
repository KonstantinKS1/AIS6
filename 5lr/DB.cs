using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace _5lr
{
    class DB
    {   public static MySqlConnection GetConnection()
        {
            string sql = @"server=192.168.1.107;port=3306; database=mydb;uid=root;pwd=123456;";
            MySqlConnection mycon = new MySqlConnection(sql);
            try
            {
                mycon.Open();
            }
            catch (Exception er)
            {
                MessageBox.Show("Connection Error ! " + er.Message, "Information");
            }
            return mycon;
        }

        public static void add_object(Object std)
        {
            string sql = "INSERT INTO Obect (idObect, name_object, type_object, address_object, num_of_Seats, Obj_Pop_idObj_Pop, Event_idEvent, Onwer_idOnwer) VALUES (NULL, @name_object, @type_object, @address_object, @num_of_Seats, @Object_Pop_idObj_Pop, @Event_idEvent, @Onwer_idOnwer)";
            MySqlConnection mycon = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, mycon);
            cmd.CommandType = System.Data.CommandType.Text;
           // cmd.Parameters.Add("idObject", MySqlDbType.Int32).Value = std.ID_Object;
            cmd.Parameters.Add("@name_object", MySqlDbType.String).Value = std.Name_obj;
            cmd.Parameters.Add("@type_object", MySqlDbType.String).Value = std.Type_obj;
            cmd.Parameters.Add("@address_object", MySqlDbType.String).Value = std.Address_Obj;
            cmd.Parameters.Add("@num_of_seats", MySqlDbType.Int32).Value = std.Num_of_Seats;
            cmd.Parameters.Add("@Object_Pop_idObj_Pop", MySqlDbType.Int32).Value = std.Id_obj_pop;
            cmd.Parameters.Add("@Event_idEvent", MySqlDbType.Int32).Value = std.Id_ev;
            cmd.Parameters.Add("@Onwer_idOnwer", MySqlDbType.Int32).Value = std.Id_on;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Add successfull", "!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error Empty" + ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            mycon.Close();
        }
        public static void get_object(DataGridView dgv)
        {
            //string sql = query;
            MySqlConnection mycon = GetConnection();
            //MySqlCommand cmd = new MySqlCommand(sql, mycon);
            MySqlDataAdapter ad = new MySqlDataAdapter("SELECT * FROM obect", mycon);
            DataTable tbl = new DataTable();
            ad.Fill(tbl);
            dgv.DataSource = tbl;
            mycon.Close();
            
        }
        public static void delete_object(Object std)
        {
            string sql = "DELETE FROM Obect WHERE idObect=@idObject";
            MySqlConnection mycon = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, mycon);
            cmd.CommandType = System.Data.CommandType.Text;
            //cmd.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
            cmd.Parameters.Add("idObject", MySqlDbType.Int32).Value = std.ID_Object;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Del successfull", "!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error Empty" + ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            mycon.Close();
        }
        public static void change_object(Object std)
        {
            string sql = "UPDATE Obect SET  name_object=@name_object, type_object=@type_object, address_object=@address_object, num_of_Seats=@num_of_seats, Obj_Pop_idObj_Pop=@Obj_pop, Event_idEvent=@Event, Onwer_idOnwer=@Onwer WHERE  idObect=@id";
            MySqlConnection mycon = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, mycon);
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Parameters.Add("@id", MySqlDbType.Int32).Value = std.ID_Object;
            cmd.Parameters.Add("@name_object", MySqlDbType.String).Value = std.Name_obj;
            cmd.Parameters.Add("@type_object", MySqlDbType.String).Value = std.Type_obj;
            cmd.Parameters.Add("@address_object", MySqlDbType.String).Value = std.Address_Obj;
            cmd.Parameters.Add("@num_of_seats", MySqlDbType.Int32).Value = std.Num_of_Seats;
            cmd.Parameters.Add("@Obj_Pop", MySqlDbType.Int32).Value = std.Id_obj_pop;
            cmd.Parameters.Add("@Event", MySqlDbType.Int32).Value = std.Id_ev;
            cmd.Parameters.Add("@Onwer", MySqlDbType.Int32).Value = std.Id_on;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Update successfull", "!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Not Update" + ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            mycon.Close();
        }
        public static void add_event(Event std)
        {
            string sql = "INSERT INTO Event (idEvent, name_event, data_event, type_event) VALUES (NULL, @name_event, @data_event, @type_event)";
            MySqlConnection mycon = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, mycon);
            cmd.CommandType = System.Data.CommandType.Text;
           // cmd.Parameters.Add("idEvent", MySqlDbType.Int32).Value = std.idEvent;
            cmd.Parameters.Add("@name_event", MySqlDbType.String).Value = std.Name_event;
            cmd.Parameters.Add("@data_event", MySqlDbType.Date).Value = std.Date_event;
            cmd.Parameters.Add("@type_event", MySqlDbType.String).Value = std.Type_event;
            
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("successfull", "!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error Empty" + ex.Message,"error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            mycon.Close();
        }
        public static void get_event(DataGridView dgv)
        {
            MySqlConnection mycon = GetConnection();
            //MySqlCommand cmd = new MySqlCommand(sql, mycon);
            
            MySqlDataAdapter ad = new MySqlDataAdapter("SELECT * FROM event", mycon);
            DataTable tbl = new DataTable();
            ad.Fill(tbl);
            
            dgv.DataSource = tbl;
            mycon.Close();
        }
        public static void delete_event(Event std)
        {
            string sql = "DELETE FROM Event WHERE idEvent=@idEvent";
            MySqlConnection mycon = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, mycon);
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Parameters.Add("idEvent", MySqlDbType.Int32).Value = std.idEvent;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Del successfull", "!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error Empty" + ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            mycon.Close();
        }
        public static void change_event(Event std)
        {
            string sql = "UPDATE Event SET name_event=@name_event, data_event=@data_event, type_event=@type_event WHERE idEvent=@id";
            MySqlConnection mycon = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, mycon);
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Parameters.Add("@id", MySqlDbType.Int32).Value = std.idEvent;
            cmd.Parameters.Add("@name_event", MySqlDbType.String).Value = std.Name_event;
            cmd.Parameters.Add("@data_event", MySqlDbType.String).Value = std.Date_event;
            cmd.Parameters.Add("@type_event", MySqlDbType.String).Value = std.Type_event;


            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Update successfull", "!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Not Update" + ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            mycon.Close();
        }
        public static void add_onwer(Onwer std)
        {
            string sql = "INSERT INTO Onwer (idOnwer, name_onwer, FIO, tel_num, data_open, Status_Onwer_idStatus_Onwer) VALUES (NULL, @name_onwer, @FIO, @tel_num, @data_open, @Status_Onwer)";
            MySqlConnection mycon = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, mycon);
            cmd.CommandType = System.Data.CommandType.Text;
            //cmd.Parameters.Add("idOnwer", MySqlDbType.Int32).Value = std.ID_onwer;
            cmd.Parameters.Add("@name_onwer", MySqlDbType.String).Value = std.Name_onwer;
            cmd.Parameters.Add("@FIO", MySqlDbType.VarChar).Value = std.FIO_CEO;
            cmd.Parameters.Add("@tel_num", MySqlDbType.String).Value = std.Tel_num;
            cmd.Parameters.Add("@data_open", MySqlDbType.Date).Value = std.Date_open;
            cmd.Parameters.Add("@Status_Onwer", MySqlDbType.Int32).Value = std.St_on;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("successfull", "!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error Empty" + ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            mycon.Close();

        }
        public static void get_onwer(DataGridView dgv)
        {
            MySqlConnection mycon = GetConnection();
            //MySqlCommand cmd = new MySqlCommand(sql, mycon);
            MySqlDataAdapter ad = new MySqlDataAdapter("SELECT * FROM Onwer", mycon);
            DataTable tbl = new DataTable();
            ad.Fill(tbl);
            
            dgv.DataSource = tbl;
            mycon.Close();
        }
        public static void delete_onwer(Onwer std)
        {
            string sql = "DELETE FROM Onwer WHERE idOnwer=@id";
            MySqlConnection mycon = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, mycon);
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Parameters.Add("@id", MySqlDbType.Int32).Value = std.ID_onwer;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Del successfull", "!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error Empty" + ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            mycon.Close();
        }
        public static void change_onwer(Onwer std)
        {
            string sql = "UPDATE Onwer SET name_onwer=@name_onwer, FIO=@FIO, tel_num=@tel_num, data_open=@data_open, Status_Onwer_idStatus_Onwer=@Status_Onwer WHERE idOnwer=@id";
            MySqlConnection mycon = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, mycon);
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Parameters.Add("@id", MySqlDbType.Int32).Value = std.ID_onwer;
            cmd.Parameters.Add("@name_onwer", MySqlDbType.String).Value = std.Name_onwer;
            cmd.Parameters.Add("@FIO", MySqlDbType.String).Value = std.FIO_CEO;
            cmd.Parameters.Add("@tel_num", MySqlDbType.Int32).Value = std.Tel_num;
            cmd.Parameters.Add("@data_open", MySqlDbType.Date).Value = std.Date_open;
            cmd.Parameters.Add("@Status_Onwer", MySqlDbType.Int32).Value = std.St_on;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Update successfull", "!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Not Update" + ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            mycon.Close();
        }
        public static void add_obj_pop(Obj_Pop std)
        {
            string sql = "INSERT INTO Obj_Pop (idObj_Pop, date_e, num_pop) VALUES (NULL, @date_e, @num_pop)";
            MySqlConnection mycon = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, mycon);
            cmd.CommandType = System.Data.CommandType.Text;
           // cmd.Parameters.Add("idObj_Pop", MySqlDbType.Int32).Value = std.ID_Obj_pop;
            cmd.Parameters.Add("@date_e", MySqlDbType.Date).Value = std.Date_e;
            cmd.Parameters.Add("@num_pop", MySqlDbType.Int32).Value = std.Num_pop;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("successfull", "!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error Empty" + ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            mycon.Close();
        }
        public static void get_obj_pop(DataGridView dgv)
        {
            MySqlConnection mycon = GetConnection();
            //MySqlCommand cmd = new MySqlCommand(sql, mycon);
            MySqlDataAdapter ad = new MySqlDataAdapter("SELECT * FROM obj_pop", mycon);
            DataTable tbl = new DataTable();
            ad.Fill(tbl);
            
            dgv.DataSource = tbl;
            //ad.Update((DataTable)dgv.DataSource);
            mycon.Close();
        }
        public static void delete_obj_pop(Obj_Pop std)
        {
            string sql = "DELETE FROM Obj_Pop WHERE idObj_Pop=@id";
            MySqlConnection mycon = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, mycon);
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Parameters.Add("@id", MySqlDbType.Int32).Value = std.ID_Obj_pop;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Del successfull", "!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error Empty" + ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            mycon.Close();
        }
        public static void change_obj_pop(Obj_Pop std)
        {
            string sql = "UPDATE Obj_Pop SET  date_e=@date_e, num_pop=@num_pop WHERE idObj_Pop=@id";
            MySqlConnection mycon = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, mycon);
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Parameters.Add("@id", MySqlDbType.Int32).Value = std.ID_Obj_pop;
            cmd.Parameters.Add("@date_e", MySqlDbType.Date).Value = std.Date_e;
            cmd.Parameters.Add("@num_pop", MySqlDbType.Int32).Value = std.Num_pop;

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Update successfull", "!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Not Update" + ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            mycon.Close();
        }
        public static void delete_status_onwer(Status_Onwer std)
        {
            string sql = "DELETE FROM Status_Onwer WHERE idStatus_Onwer=@idStatus_Onwer";
            MySqlConnection mycon = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, mycon);
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Parameters.Add("@idStatus_Onwer", MySqlDbType.Int32).Value = std.ID_status;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Del successfull", "!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error Empty" + ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            mycon.Close();
        }
        public static void change_status_onwer(Status_Onwer std)
        {
            string sql = "UPDATE Status_Onwer SET name_st=@name_st WHERE idStatus_Onwer=@id";
            MySqlConnection mycon = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, mycon);
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Parameters.Add("@id", MySqlDbType.Int32).Value = std.ID_status;
            cmd.Parameters.Add("@name_st", MySqlDbType.String).Value = std.Name_st;


            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Update successfull", "!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Not Update" + ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            mycon.Close();
        }
        public static void add_status_onwer(Status_Onwer std)
        {
            string sql = "INSERT INTO Status_Onwer (idStatus_Onwer, name_st) VALUES (NULL, @name_st)";
            MySqlConnection mycon = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, mycon);
            cmd.CommandType = System.Data.CommandType.Text;
            //cmd.Parameters.Add("idStatus_Onwer", MySqlDbType.Int32).Value = std.ID_status;
            cmd.Parameters.Add("@name_st", MySqlDbType.String).Value = std.Name_st;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("successfull", "!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error Empty" + ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            mycon.Close();
        }
        public static void get_status_onwer(DataGridView dgv)
        {
            MySqlConnection mycon = GetConnection();
            //MySqlCommand cmd = new MySqlCommand(sql, mycon);
            MySqlDataAdapter ad = new MySqlDataAdapter("SELECT * FROM status_onwer", mycon);
            DataTable tbl = new DataTable();
            ad.Fill(tbl);
            dgv.DataSource = tbl;
            mycon.Close();
            
        }


    }
}

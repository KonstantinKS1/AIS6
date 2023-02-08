using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5lr
{
    public partial class Form1 : Form, View_Object, View_Event, View_Obj_Pop, View_Onwer, View_Status_Onwer
    {
        //Controller cont;
                
        public Form1()
        {
            InitializeComponent();
            DB.get_object(tab_Object);
            DB.get_obj_pop(tab_Obj_pop);
            DB.get_onwer(tab_onwer);
            DB.get_status_onwer(tab_status_onwer);
            DB.get_event(tab_event);
        }

        //добавление Object
        private void Add_click_Click(object sender, EventArgs e)
        {

            if (t_name_obj.Text==string.Empty || t_type_Obj.Text == string.Empty || t_address_Obj.Text == string.Empty || t_num_of_Seats.Text == string.Empty || t_onwer.Text == string.Empty || t_event.Text == string.Empty || t_obj_pop.Text == string.Empty )
            {
                MessageBox.Show("Поля пустые", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else 
            { 
                Controller_obj std = new Controller_obj(this);
                std.Add_click();
                DB.get_object(tab_Object);
            }
        }
        //изменение Object
        private void Change_click_Click(object sender, EventArgs e)
        {
            if (t_name_obj.Text == string.Empty || t_type_Obj.Text == string.Empty || t_address_Obj.Text == string.Empty || t_num_of_Seats.Text == string.Empty || t_onwer.Text == string.Empty || t_event.Text == string.Empty || t_obj_pop.Text == string.Empty||t_ID_obj.Text==string.Empty)
            {
                MessageBox.Show("Поля пустые", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                /*Object std = new Object(t_name_obj.Text, t_type_Obj.Text, t_address_Obj.Text, Convert.ToInt32(t_num_of_Seats.Text), Convert.ToInt32(t_onwer.Text), Convert.ToInt32(t_event.Text), Convert.ToInt32(t_obj_pop.Text));*/
                Controller_obj std = new Controller_obj(this);
                std.Change_click();
                //DB.change_object(std);
                DB.get_object(tab_Object);
            }
            
        }
        //удаление Object
        private void Delete_click_Click(object sender, EventArgs e)
        {
            if (t_ID_obj.Text == string.Empty)
            {
                MessageBox.Show("Полe ID пустое", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                Controller_obj std = new Controller_obj(this);
                std.Delete_click();
                //Object std = new Object();
                //DB.delete_object(t_ID_obj.Text);
                DB.get_object(tab_Object);
            }

        }
        //добавление Status_Onwer
        private void Add_click4_Click(object sender, EventArgs e)
        {
            if (t_name_st.Text == string.Empty)
            {
                MessageBox.Show("Поля пустые", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                Controller_st std = new Controller_st(this);
                std.Add_click4();
                DB.get_status_onwer(tab_status_onwer);
            }

        }
        //добавление Event
        private void Add_click5_Click(object sender, EventArgs e)
        {
            if (t_data_event.Text== string.Empty || t_name_event.Text == string.Empty || t_type_event.Text == string.Empty )
            {
                MessageBox.Show("Поля пустые", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                Controller_ev std = new Controller_ev(this);
                std.Add_click5();
                //Event std = new Event(t_data_event.Text, t_name_event.Text, t_type_event.Text);
                //DB.add_event(std);
                DB.get_event(tab_event);
            }

        }
        //изменение Event
        private void Change_click5_Click(object sender, EventArgs e)
        {
            if (t_data_event.Text == string.Empty || t_name_event.Text == string.Empty || t_type_event.Text == string.Empty|| t_ID_event.Text == string.Empty)
            {
                MessageBox.Show("Поля пустые", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                Controller_ev std = new Controller_ev(this);
                std.Change_click5();
                //Event std = new Event(t_data_event.Text, t_name_event.Text, t_type_event.Text);
                //DB.change_event(std, t_ID_event.Text);
                DB.get_event(tab_event);
            }

        }
        //удаление Event
        private void Delete_click5_Click(object sender, EventArgs e)
        {
            if (t_ID_event.Text == string.Empty)
            {
                MessageBox.Show("Полe ID пустое", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                Controller_ev std = new Controller_ev(this);
                std.Delete_click5();
                DB.get_event(tab_event);
            }

        }
        //изменение Status_Onwer
        private void Change_click4_Click(object sender, EventArgs e)
        {
            if (t_name_st.Text == string.Empty)
            {
                MessageBox.Show("Поля пустые", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                Controller_st std = new Controller_st(this);
                std.Change_click4();
              
                DB.get_status_onwer(tab_status_onwer);
            }
                
        }
        //удаление Status_Onwer
        private void Delete_click4_Click(object sender, EventArgs e)
        {
            if (t_ID_status.Text == string.Empty)
            {
                MessageBox.Show("Полe ID пустое", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                Controller_st std = new Controller_st(this);
                std.Delete_click4();
                DB.get_status_onwer(tab_status_onwer);
            }

        }
        //добавление Onwer
        private void Add_click3_Click(object sender, EventArgs e)
        {
            if (t_data_open.Text == string.Empty || t_tel_num.Text == string.Empty || t_name_onwer.Text == string.Empty || t_status.Text == string.Empty || t_name_onwer.Text == string.Empty)
            {
                MessageBox.Show("Поля пустые", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                Controller_on std = new Controller_on(this);
                std.Add_click3();
                //Onwer std = new Onwer(t_data_open.Text, Convert.ToInt32(t_tel_num.Text), t_name_onwer.Text, Convert.ToInt32(t_status.Text), t_name_onwer.Text);
                //DB.add_onwer(std);
                DB.get_onwer(tab_onwer);
            }

        }
        //Изменение Onwer
        private void Change_click3_Click(object sender, EventArgs e)
        {
            if (t_data_open.Text == string.Empty || t_tel_num.Text == string.Empty || t_name_onwer.Text == string.Empty || t_status.Text == string.Empty || t_name_onwer.Text == string.Empty)
            {
                MessageBox.Show("Поля пустые", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                Controller_on std = new Controller_on(this);
                std.Change_click3();
                DB.get_onwer(tab_onwer);
            }

        }
        //удаление Onwer
        private void Delete_click3_Click(object sender, EventArgs e)
        {
            if (t_ID_onwer.Text == string.Empty)
            {
                MessageBox.Show("Полe ID пустое", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                Controller_on std = new Controller_on(this);
                std.Delete_click3();
                DB.get_onwer(tab_onwer);
            }

        }
        //добавление Obj_Pop
        private void Add_click2_Click(object sender, EventArgs e)
        {
            if (t_data_e.Text == string.Empty || t_num_pop.Text == string.Empty )
            {
                MessageBox.Show("Поля пустые", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                Controller_obj_pop std = new Controller_obj_pop(this);
                std.Add_click2();
                //Obj_Pop std = new Obj_Pop(t_data_e.Text, Convert.ToInt32(t_num_pop.Text));
               // DB.add_obj_pop(std);
                DB.get_obj_pop(tab_Obj_pop);
            }

        }
        //изменение Obj_Pop
        private void Change_click2_Click(object sender, EventArgs e)
        {
            if (t_data_e.Text == string.Empty || t_num_pop.Text == string.Empty)
            {
                MessageBox.Show("Поля пустые", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                Controller_obj_pop std = new Controller_obj_pop(this);
                std.Change_click2();
                DB.get_obj_pop(tab_Obj_pop);
            }

        }
        //удаление Obj_Pop
        private void Delete_click2_Click(object sender, EventArgs e)
        {
            if (t_ID_Obj_pop.Text == string.Empty)
            {
                MessageBox.Show("Полe ID пустое", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                Controller_obj_pop std = new Controller_obj_pop(this);
                std.Delete_click2();
                DB.get_obj_pop(tab_Obj_pop);
            }

        }

        //ограничение на ввод символов

        private void t_ID_obj_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(Convert.ToChar(number)))
            {
                e.Handled = true;
            }
        }

        private void t_ID_Obj_pop_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(Convert.ToChar(number)))
            {
                e.Handled = true;
            }
        }

        private void t_ID_onwer_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(Convert.ToChar(number)))
            {
                e.Handled = true;
            }
        }

        private void t_ID_status_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(Convert.ToChar(number)))
            {
                e.Handled = true;
            }
        }

        private void t_ID_event_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(Convert.ToChar(number)))
            {
                e.Handled = true;
            }
        }



        int View_Status_Onwer.ID_status { get => Convert.ToInt32(this.t_ID_status.Text); set => this.t_ID_status.Text = value.ToString(); }
        string View_Status_Onwer.Name_st { get => this.t_name_st.Text; set => this.t_name_st.Text = value; }
        int View_Onwer.ID_onwer { get => Convert.ToInt32(this.t_ID_onwer.Text); set => this.t_ID_onwer.Text = value.ToString(); }
        int View_Onwer.Status { get => Convert.ToInt32(this.t_status.Text); set => this.t_status.Text = value.ToString(); }
        string View_Onwer.Name_Onwer { get => this.t_name_onwer.Text; set => this.t_name_onwer.Text = value; }
        string View_Onwer.FIO { get => this.t_FIO.Text; set => this.t_FIO.Text = value; }
        int View_Onwer.Tel_num { get => Convert.ToInt32(this.t_tel_num.Text); set => this.t_tel_num.Text = value.ToString(); }
        string View_Onwer.Data_open { get => this.t_data_open.Text; set => this.t_data_open.Text = value; }
        int View_Obj_Pop.ID_obj_pop { get => Convert.ToInt32(this.t_ID_Obj_pop.Text); set => this.t_ID_Obj_pop.Text = value.ToString(); }
        int View_Obj_Pop.Num_pop { get => Convert.ToInt32(this.t_num_pop.Text); set => this.t_num_pop.Text = value.ToString(); }
        string View_Obj_Pop.Data_e { get => this.t_data_e.Text; set => this.t_data_e.Text = value; }
        int View_Object.ID_obj { get => Convert.ToInt32(this.t_ID_obj.Text); set => this.t_ID_obj.Text =value.ToString(); }
        string View_Object.Type_obj { get => this.t_type_Obj.Text; set => this.t_type_Obj.Text = value; }
        string View_Object.Name_obj { get => this.t_name_obj.Text; set => this.t_name_obj.Text = value; }
        string View_Object.Address_Obj { get => this.t_address_Obj.Text; set => this.t_address_Obj.Text = value; }
        int View_Object.Num_of_Seats { get => Convert.ToInt32(this.t_num_of_Seats.Text); set => this.t_num_of_Seats.Text = value.ToString(); }
        int View_Object.Onwer { get => Convert.ToInt32(this.t_onwer.Text); set => this.t_onwer.Text = value.ToString(); }
        int View_Object.Event { get => Convert.ToInt32(this.t_event.Text); set => this.t_event.Text = value.ToString(); }
        int View_Object.Obj_pop { get => Convert.ToInt32(this.t_obj_pop.Text); set => this.t_obj_pop.Text = value.ToString(); }
        int View_Event.ID_Event { get => Convert.ToInt32(this.t_ID_event.Text); set => this.t_ID_event.Text = value.ToString(); }
        string View_Event.Data_event { get => this.t_data_e.Text; set => this.t_data_e.Text = value; }
        string View_Event.Name_Event { get => this.t_name_event.Text; set => this.t_name_event.Text = value; }
        string View_Event.Type_Event { get => this.t_type_event.Text; set => this.t_type_event.Text = value;  }




    }
    }

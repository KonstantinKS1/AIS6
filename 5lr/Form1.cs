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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DB.get_object(tab_Object);
            DB.get_obj_pop(tab_Obj_pop);
            DB.get_onwer(tab_onwer);
            DB.get_status_onwer(tab_status_onwer);
            DB.get_event(tab_event);
        }

        private void Add_click_Click(object sender, EventArgs e)
        {
            if (t_name_obj.Text==string.Empty || t_type_Obj.Text == string.Empty || t_address_Obj.Text == string.Empty || t_num_of_Seats.Text == string.Empty || t_onwer.Text == string.Empty || t_event.Text == string.Empty || t_obj_pop.Text == string.Empty )
            {
                MessageBox.Show("Поля пустые", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else 
            { 
                Object std = new Object(t_name_obj.Text, t_type_Obj.Text, t_address_Obj.Text, Convert.ToInt32(t_num_of_Seats.Text), Convert.ToInt32(t_onwer.Text), Convert.ToInt32(t_event.Text), Convert.ToInt32(t_obj_pop.Text));
                DB.add_object(std);
                DB.get_object(tab_Object);
            }
        }

        private void Change_click_Click(object sender, EventArgs e)
        {
            if (t_name_obj.Text == string.Empty || t_type_Obj.Text == string.Empty || t_address_Obj.Text == string.Empty || t_num_of_Seats.Text == string.Empty || t_onwer.Text == string.Empty || t_event.Text == string.Empty || t_obj_pop.Text == string.Empty)
            {
                MessageBox.Show("Поля пустые", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                Object std = new Object(t_name_obj.Text, t_type_Obj.Text, t_address_Obj.Text, Convert.ToInt32(t_num_of_Seats.Text), Convert.ToInt32(t_onwer.Text), Convert.ToInt32(t_event.Text), Convert.ToInt32(t_obj_pop.Text));
                DB.change_object(std, t_ID_obj.Text);
                DB.get_object(tab_Object);
            }
            
        }

        private void Delete_click_Click(object sender, EventArgs e)
        {
            if (t_ID_obj.Text == string.Empty)
            {
                MessageBox.Show("Полe ID пустое", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                Object std = new Object();
                DB.delete_object(t_ID_obj.Text);
                DB.get_object(tab_Object);
            }

        }

        private void Add_click4_Click(object sender, EventArgs e)
        {
            if (t_name_st.Text == string.Empty)
            {
                MessageBox.Show("Поля пустые", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                Status_Onwer std = new Status_Onwer(t_name_st.Text);
                DB.add_status_onwer(std);
                DB.get_status_onwer(tab_status_onwer);
            }

        }

        private void Add_click5_Click(object sender, EventArgs e)
        {
            if (t_data_event.Text== string.Empty || t_name_event.Text == string.Empty || t_type_event.Text == string.Empty )
            {
                MessageBox.Show("Поля пустые", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                Event std = new Event(t_data_event.Text, t_name_event.Text, t_type_event.Text);
                DB.add_event(std);
                DB.get_event(tab_event);
            }

        }

        private void Change_click5_Click(object sender, EventArgs e)
        {
            if (t_data_event.Text == string.Empty || t_name_event.Text == string.Empty || t_type_event.Text == string.Empty)
            {
                MessageBox.Show("Поля пустые", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                Event std = new Event(t_data_event.Text, t_name_event.Text, t_type_event.Text);
                DB.change_event(std, t_ID_event.Text);
                DB.get_event(tab_event);
            }

        }

        private void Delete_click5_Click(object sender, EventArgs e)
        {
            if (t_ID_event.Text == string.Empty)
            {
                MessageBox.Show("Полe ID пустое", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                Event std = new Event();
                DB.delete_event(t_ID_event.Text);
                DB.get_event(tab_event);
            }

        }

        private void Change_click4_Click(object sender, EventArgs e)
        {
            if (t_name_st.Text == string.Empty)
            {
                MessageBox.Show("Поля пустые", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                Status_Onwer std = new Status_Onwer(t_name_st.Text);
                DB.change_status_onwer(std, t_ID_status.Text);
                DB.get_status_onwer(tab_status_onwer);
            }
                
        }

        private void Delete_click4_Click(object sender, EventArgs e)
        {
            if (t_ID_status.Text == string.Empty)
            {
                MessageBox.Show("Полe ID пустое", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                Status_Onwer std = new Status_Onwer();
                DB.delete_status_onwer(t_ID_status.Text);
                DB.get_status_onwer(tab_status_onwer);
            }

        }

        private void Add_click3_Click(object sender, EventArgs e)
        {
            if (t_data_open.Text == string.Empty || t_tel_num.Text == string.Empty || t_name_onwer.Text == string.Empty || t_status.Text == string.Empty || t_name_onwer.Text == string.Empty)
            {
                MessageBox.Show("Поля пустые", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                Onwer std = new Onwer(t_data_open.Text, Convert.ToInt32(t_tel_num.Text), t_name_onwer.Text, Convert.ToInt32(t_status.Text), t_name_onwer.Text);
                DB.add_onwer(std);
                DB.get_onwer(tab_onwer);
            }

        }

        private void Change_click3_Click(object sender, EventArgs e)
        {
            if (t_data_open.Text == string.Empty || t_tel_num.Text == string.Empty || t_name_onwer.Text == string.Empty || t_status.Text == string.Empty || t_name_onwer.Text == string.Empty)
            {
                MessageBox.Show("Поля пустые", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                Onwer std = new Onwer(t_data_open.Text, Convert.ToInt32(t_tel_num.Text), t_name_onwer.Text, Convert.ToInt32(t_status.Text), t_name_onwer.Text);
                DB.change_onwer(std, t_ID_onwer.Text);
                DB.get_onwer(tab_onwer);
            }

        }

        private void Delete_click3_Click(object sender, EventArgs e)
        {
            if (t_ID_onwer.Text == string.Empty)
            {
                MessageBox.Show("Полe ID пустое", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                Onwer std = new Onwer();
                DB.delete_onwer(t_ID_onwer.Text);
                DB.get_onwer(tab_onwer);
            }

        }

        private void Add_click2_Click(object sender, EventArgs e)
        {
            if (t_data_e.Text == string.Empty || t_num_pop.Text == string.Empty )
            {
                MessageBox.Show("Поля пустые", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                Obj_Pop std = new Obj_Pop(t_data_e.Text, Convert.ToInt32(t_num_pop.Text));
                DB.add_obj_pop(std);
                DB.get_obj_pop(tab_Obj_pop);
            }

        }

        private void Change_click2_Click(object sender, EventArgs e)
        {
            if (t_data_e.Text == string.Empty || t_num_pop.Text == string.Empty)
            {
                MessageBox.Show("Поля пустые", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                Obj_Pop std = new Obj_Pop(t_data_e.Text, Convert.ToInt32(t_num_pop.Text));
                DB.change_obj_pop(std, t_ID_Obj_pop.Text);
                DB.get_obj_pop(tab_Obj_pop);
            }

        }

        private void Delete_click2_Click(object sender, EventArgs e)
        {
            if (t_ID_Obj_pop.Text == string.Empty)
            {
                MessageBox.Show("Полe ID пустое", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                Obj_Pop std = new Obj_Pop();
                DB.delete_obj_pop(t_ID_Obj_pop.Text);
                DB.get_obj_pop(tab_Obj_pop);
            }

        }

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
    }
}

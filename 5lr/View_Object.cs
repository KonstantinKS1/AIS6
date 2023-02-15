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
    public partial class View_Object : Form
    {
        public View_Object()
        {
            InitializeComponent();
            DB.get_object(tab_Object);

        }

        private void viewEventToolStripMenuItem_Click(object sender, EventArgs e)
        {
            View_Event new_form = new View_Event();
            //new_form.Show();
            new_form.ShowDialog();
        }

        private void objPopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            View_Obj_Pop new_form = new View_Obj_Pop();
            //new_form.Show();
            new_form.ShowDialog();
        }

        private void onwerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            View_Onwer new_form = new View_Onwer();
            //new_form.Show();
            new_form.ShowDialog();
        }

        private void statusOnwerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            View_Status_Onwer new_form = new View_Status_Onwer();
            //new_form.Show();
            new_form.ShowDialog();
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
                    //Object std = new Object(t_name_obj.Text, t_type_Obj.Text, t_address_Obj.Text, Convert.ToInt32(t_num_of_Seats.Text), Convert.ToInt32(t_onwer.Text), Convert.ToInt32(t_event.Text), Convert.ToInt32(t_obj_pop.Text), Convert.ToInt32(t_ID_obj.Text));
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

        //ограничение на ввод символов

        private void t_ID_obj_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(Convert.ToChar(number)))
            {
                e.Handled = true;
            }
        }
        public int ID_obj { get => Convert.ToInt32(this.t_ID_obj.Text); set => this.t_ID_obj.Text = value.ToString(); }
        public string Type_obj { get => this.t_type_Obj.Text; set => this.t_type_Obj.Text = value; }
        public string Name_obj { get => this.t_name_obj.Text; set => this.t_name_obj.Text = value; }
        public string Address_Obj { get => this.t_address_Obj.Text; set => this.t_address_Obj.Text = value; }
        public int Num_of_Seats { get => Convert.ToInt32(this.t_num_of_Seats.Text); set => this.t_num_of_Seats.Text = value.ToString(); }
        public int Onwer { get => Convert.ToInt32(this.t_onwer.Text); set => this.t_onwer.Text = value.ToString(); }
        public int Event { get => Convert.ToInt32(this.t_event.Text); set => this.t_event.Text = value.ToString(); }
        public int Obj_pop { get => Convert.ToInt32(this.t_obj_pop.Text); set => this.t_obj_pop.Text = value.ToString(); }

    }
}

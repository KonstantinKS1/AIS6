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
    public partial class View_Obj_Pop : Form
    {
        public View_Obj_Pop()
        {
            InitializeComponent();
            DB.get_obj_pop(tab_Obj_pop);
        }
        //ограничение на ввод символов
        private void t_ID_Obj_pop_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(Convert.ToChar(number)))
            {
                e.Handled = true;
            }
        }
        //добавление Obj_Pop
        private void Add_click2_Click(object sender, EventArgs e)
        {
            if (t_data_e.Text == string.Empty || t_num_pop.Text == string.Empty)
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
        public int ID_obj_pop { get => Convert.ToInt32(this.t_ID_Obj_pop.Text); set => this.t_ID_Obj_pop.Text = value.ToString(); }
        public int Num_pop { get => Convert.ToInt32(this.t_num_pop.Text); set => this.t_num_pop.Text = value.ToString(); }
        public string Data_e { get => this.t_data_e.Text; set => this.t_data_e.Text = value; }
    }
}

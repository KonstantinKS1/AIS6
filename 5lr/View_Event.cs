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
    public partial class View_Event : Form
    {
        public View_Event()
        {
            InitializeComponent();
            DB.get_event(tab_event);
        }
        //ограничение на ввод символов
        private void t_ID_event_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(Convert.ToChar(number)))
            {
                e.Handled = true;
            }
        }
        //добавление Event
        private void Add_click5_Click(object sender, EventArgs e)
        {
            if (t_data_event.Text == string.Empty || t_name_event.Text == string.Empty || t_type_event.Text == string.Empty)
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
            if (t_data_event.Text == string.Empty || t_name_event.Text == string.Empty || t_type_event.Text == string.Empty || t_ID_event.Text == string.Empty)
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
        public int ID_Event { get => Convert.ToInt32(this.t_ID_event.Text); set => this.t_ID_event.Text = value.ToString(); }
        public string Data_event { get => this.t_data_event.Text; set => this.t_data_event.Text = value; }
        public string Name_Event { get => this.t_name_event.Text; set => this.t_name_event.Text = value; }
        public string Type_Event { get => this.t_type_event.Text; set => this.t_type_event.Text = value; }

    }
}

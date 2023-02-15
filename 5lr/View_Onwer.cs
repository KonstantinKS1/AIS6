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
    public partial class View_Onwer : Form
    {
        public View_Onwer()
        {
            InitializeComponent();
            DB.get_onwer(tab_onwer);
        }
        //ограничение на ввод символов
        private void t_ID_onwer_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(Convert.ToChar(number)))
            {
                e.Handled = true;
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
        public int ID_onwer { get => Convert.ToInt32(this.t_ID_onwer.Text); set => this.t_ID_onwer.Text = value.ToString(); }
        public int Status { get => Convert.ToInt32(this.t_status.Text); set => this.t_status.Text = value.ToString(); }
        public string Name_Onwer { get => this.t_name_onwer.Text; set => this.t_name_onwer.Text = value; }
        public string FIO { get => this.t_FIO.Text; set => this.t_FIO.Text = value; }
        public int Tel_num { get => Convert.ToInt32(this.t_tel_num.Text); set => this.t_tel_num.Text = value.ToString(); }
        public string Data_open { get => this.t_data_open.Text; set => this.t_data_open.Text = value; }
    }
}

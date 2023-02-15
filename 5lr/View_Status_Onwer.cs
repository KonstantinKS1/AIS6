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
    public partial class View_Status_Onwer : Form
    {
        public View_Status_Onwer()
        {
            InitializeComponent();
            DB.get_status_onwer(tab_status_onwer);
        }
        private void t_ID_status_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(Convert.ToChar(number)))
            {
                e.Handled = true;
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
        public int ID_status { get => Convert.ToInt32(this.t_ID_status.Text); set => this.t_ID_status.Text = value.ToString(); }
        public string Name_st { get => this.t_name_st.Text; set => this.t_name_st.Text = value; }
    }
}

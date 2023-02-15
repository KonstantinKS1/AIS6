using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5lr
{
    class Onwer
    {
        public string Date_open
        {
            get;
            set; 
        }
        public int Tel_num
        {
            get;
            set; 
        }
        public string Name_onwer
        {
            get; 
            set;
        }
        public  int St_on
        {
            get;
            set; 
        }
        public int ID_onwer
        {
            get;
            set; 
        }
        public string FIO_CEO
        {
            get;
            set; 
        }
        public Onwer() { }
        public Onwer(string dt_op, int tel, string nm_on, int st_on,  string ceo, int id_o)
        {
            Date_open = dt_op;
            Tel_num = tel;
            Name_onwer = nm_on;
            St_on = st_on;
            ID_onwer = id_o;
            FIO_CEO = ceo;
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5lr
{
    class Status_Onwer
    {
        public int ID_status
        {
            get;
            set;
        }
        public string Name_st
        {
            get; 
            set;
        }
        public Status_Onwer() { }
        public Status_Onwer( string nm_st, int id_st)
        {
            ID_status = id_st;
            Name_st = nm_st;
        }
    }
}

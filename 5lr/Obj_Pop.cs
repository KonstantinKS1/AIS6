using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5lr
{
    class Obj_Pop
    {
        public string Date_e
        {
            get; 
            set;
        }
        public int Num_pop
        {
            get; 
            set; 
        }
        public int ID_Obj_pop
        {
            get;
            set; 
        }
        public Obj_Pop() { }
        public Obj_Pop(string dt, int nm_pp, int id_pop)
        {
            Date_e = dt;
            Num_pop = nm_pp;
            ID_Obj_pop = id_pop;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5lr
{
    public class Object
    {
        public int ID_Object
        {
            get;
            set;
        }
        public string Name_obj
        {
            get; 
            set; 
        }
        public string Type_obj
        {
            get; 
            set; 
        }
        public string Address_Obj
        {
            get; 
            set; 
        }
        public int Num_of_Seats
        {
            get; 
            set; 
        }
        
        public int Id_on
        {
            get; 
            set; 
        }
        public int Id_ev
        {
            get; 
            set; 
        }
        public  int Id_obj_pop
        {
            get; 
            set; 
        }

        public Object() { }
        public Object( string name_ob, string type, string address, int num_pop, int onw, int ev, int obj,int id)
        {
            ID_Object = id;
            Name_obj = name_ob;
            Type_obj = type;
            Address_Obj = address;
            Num_of_Seats = num_pop;
            Id_on =onw;
            Id_ev = ev;
            Id_obj_pop = obj;

        }
    }
}

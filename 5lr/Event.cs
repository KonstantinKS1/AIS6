using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5lr
{
    public class Event
    {
        public int idEvent
        {
            get; 
            set; 
        }
        public string Date_event
        {
            get; 
            set; 
        }
        public string Name_event
        {
            get; 
            set; 
        }
        public string Type_event
        {
            get; 
            set; 
        }        
        public Event() { }
        public Event(string dt_e,string nm_e,  string tp_e, int id_ev) 
        {
            idEvent = id_ev;
            Date_event = dt_e;
            Name_event = nm_e;
            Type_event = tp_e;
        }
    }
}

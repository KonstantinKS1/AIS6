using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace _5lr
{
    public class Controller_obj
    {
        View_Object v_obj;
        
        public Controller_obj(View_Object view_Object)
        {
            v_obj = view_Object;

        }
        
        public void Add_click() 
        {
            Object std = new Object();
            std.Name_obj = v_obj.Name_obj;
            std.Type_obj = v_obj.Type_obj;
            std.Address_Obj = v_obj.Address_Obj;
            std.Num_of_Seats = Convert.ToInt32(v_obj.Num_of_Seats);
            std.Id_on = Convert.ToInt32(v_obj.Onwer);
            std.Id_ev = Convert.ToInt32(v_obj.Event);
            std.Id_obj_pop=Convert.ToInt32(v_obj.Obj_pop);
            DB.add_object(std);
        }
        public void Change_click()
        {
            
            Object std = new Object();
            std.Name_obj = v_obj.Name_obj;
            std.Type_obj = v_obj.Type_obj;
            std.Address_Obj = v_obj.Address_Obj;
            std.Num_of_Seats = Convert.ToInt32(v_obj.Num_of_Seats);
            std.Id_on = Convert.ToInt32(v_obj.Onwer);
            std.Id_ev = Convert.ToInt32(v_obj.Event);
            std.Id_obj_pop = Convert.ToInt32(v_obj.Obj_pop);
            std.ID_Object = Convert.ToInt32(v_obj.ID_obj);
            DB.change_object(std);
        }
        public void Delete_click()
        {
            Object std = new Object();
            std.ID_Object = Convert.ToInt32(v_obj.ID_obj);
            DB.delete_object(std);
        }
    }
    public class Controller_ev
    {
        View_Event v_ev;

        public Controller_ev(View_Event view_Event)
        {
            v_ev = view_Event;

        }

        public void Add_click5()
        {
            Event std = new Event();
            std.Name_event = v_ev.Name_Event;
            std.Type_event = v_ev.Type_Event;
            std.Date_event = v_ev.Data_event;
            //std.idEvent = Convert.ToInt32(v_ev.ID_Event);
            DB.add_event(std);
        }
        public void Change_click5()
        {
            Event std = new Event();
            std.Name_event = v_ev.Name_Event;
            std.Type_event = v_ev.Type_Event;
            std.Date_event = v_ev.Data_event;
            std.idEvent = Convert.ToInt32(v_ev.ID_Event);
            DB.change_event(std);
        }
        public void Delete_click5()
        {
            Event std = new Event();
            std.idEvent = Convert.ToInt32(v_ev.ID_Event);
            DB.delete_event(std);
        }
    }
    public class Controller_obj_pop
    {
        View_Obj_Pop v_obj_pop;

        public Controller_obj_pop(View_Obj_Pop view_Obj_Pop)
        {
            v_obj_pop = view_Obj_Pop;
            
        }

        public void Add_click2()
        {
            Obj_Pop std = new Obj_Pop();
            std.Num_pop = Convert.ToInt32(v_obj_pop.Num_pop);
            std.Date_e = v_obj_pop.Data_e;
            //std.ID_Obj_pop = Convert.ToInt32(v_obj_pop.ID_obj_pop);
            DB.add_obj_pop(std);
        }
        public void Change_click2()
        {
            Obj_Pop std = new Obj_Pop();
            std.Num_pop = Convert.ToInt32(v_obj_pop.Num_pop);
            std.Date_e = v_obj_pop.Data_e;
            std.ID_Obj_pop = Convert.ToInt32(v_obj_pop.ID_obj_pop);
            DB.change_obj_pop(std);
        }
        public void Delete_click2()
        {
            Obj_Pop std = new Obj_Pop();
            
            std.ID_Obj_pop = Convert.ToInt32(v_obj_pop.ID_obj_pop);
            DB.delete_obj_pop(std);
        }
    }
    public class Controller_on
    {
        
        View_Onwer v_onw;
        
        public Controller_on(View_Onwer view_Onwer)
        {
            v_onw = view_Onwer;

        }

        public void Add_click3()
        {
            Onwer std = new Onwer();
            std.Date_open = v_onw.Data_open;
            std.FIO_CEO = v_onw.FIO;
            std.Name_onwer = v_onw.Name_Onwer;
            std.St_on = Convert.ToInt32(v_onw.Status);
            std.Tel_num = Convert.ToInt32(v_onw.Tel_num);
            //std.ID_onwer = Convert.ToInt32(v_onw.ID_onwer);
            DB.add_onwer(std);
        }
        public void Change_click3()
        {
            Onwer std = new Onwer();
            std.Date_open = v_onw.Data_open;
            std.FIO_CEO = v_onw.FIO;
            std.Name_onwer = v_onw.Name_Onwer;
            std.St_on = Convert.ToInt32(v_onw.Status);
            std.Tel_num = Convert.ToInt32(v_onw.Tel_num);
            std.ID_onwer = Convert.ToInt32(v_onw.ID_onwer);
            DB.change_onwer(std);
        }
        public void Delete_click3()
        {
            Onwer std = new Onwer();

            std.ID_onwer = Convert.ToInt32(v_onw.ID_onwer);
            DB.delete_onwer(std);
        }
    }
    public class Controller_st
    {
        View_Status_Onwer v_stat;
        public Controller_st(View_Status_Onwer view_Status_Onwer)
        {
            v_stat = view_Status_Onwer;
        }

        public void Add_click4()
        {
            Status_Onwer std = new Status_Onwer();
            std.Name_st = v_stat.Name_st;
            //std.ID_status = Convert.ToInt32(v_stat.ID_status);
            DB.add_status_onwer(std);
        }
        public void Change_click4()
        {
            Status_Onwer std = new Status_Onwer();
            std.Name_st = v_stat.Name_st;
            std.ID_status = Convert.ToInt32(v_stat.ID_status);
            DB.change_status_onwer(std);
        }
        public void Delete_click4()
        {
            Status_Onwer std = new Status_Onwer();

            std.ID_status = Convert.ToInt32(v_stat.ID_status);
            DB.delete_status_onwer(std);
        }
    }


}

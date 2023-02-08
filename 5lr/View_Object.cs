using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5lr
{
    public interface View_Object
    {
        int ID_obj { set; get; }
        string Type_obj { set; get; }
        string Name_obj { set; get; }
        string Address_Obj { set; get; }
        int Num_of_Seats { set; get; }
        int Onwer { set; get; }
        int Event { set; get; }
        int Obj_pop { set; get; }

        

    }
}

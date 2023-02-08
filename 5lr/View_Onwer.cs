using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5lr
{
    public interface View_Onwer
    {
        int ID_onwer { set; get; }
        int Status { set; get; }
        string Name_Onwer { set; get; }
        string FIO { set; get; }
        int Tel_num { set; get; }
        string Data_open { set; get; }

    }
}

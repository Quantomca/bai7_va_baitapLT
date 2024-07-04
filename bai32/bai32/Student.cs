using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai32
{
    public class Student : Person, KPI
    {
        public string Major { get; set; }

        public void kpi()
        {
            // Thực hiện logic cho phương thức kpi
            Console.WriteLine("Calculating KPI for student.");
        }
    }

}

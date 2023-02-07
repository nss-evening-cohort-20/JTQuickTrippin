using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JTQuickTrippin
{
    public class Employee
    {
        public string name { get; set; }
        public int age { get; set; }
        public int storeId { get; set; }

    }

    public class Manager : Employee
    {

    }

    public class AssistantManager : Employee
    {

    }
}

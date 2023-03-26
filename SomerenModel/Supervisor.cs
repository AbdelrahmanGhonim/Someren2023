using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenModel
{
    public class Supervisor : Teacher
    {
        public int ActivityId { get; set; }         // Lecturer Activity Id
        public string ActivityName { get; set; }    // Lecturer Activity Description
    }
}

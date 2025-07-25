using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Education.Centure.CRM.DataAccess.Entities
{
    public class Course : BaseEntity
    {
        public string Name { get; set; }
        public int MyProperty { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Safa.SchoolManager.Domain.Entities
{
    public class Cours
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int CoursTypeID { get; set; }
        public int ProgramID { get; set; }
        public int Sequence { get; set; }
    }
}

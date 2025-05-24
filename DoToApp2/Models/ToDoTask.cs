using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoToApp2.Models
{
    public class ToDoTask
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Desc { get; set; }

        public bool IsFinished { get; set; }

    }
}

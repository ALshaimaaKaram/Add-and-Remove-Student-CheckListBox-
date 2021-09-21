using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlerForm
{
    class Labs
    {
        public string Name { get; set; }

        public List<Student> students { get; set; }
        //public Labs(int size)
        //{
        //    students = new Student[size];
        //}

        public List<Student> this[string name]
        {
            get => students;
            set => students = value;
        }
    }
}

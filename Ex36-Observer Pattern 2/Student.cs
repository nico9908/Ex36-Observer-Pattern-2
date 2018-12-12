using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex36_Observer_Pattern_2
{
    public class Student : IStudent
    {
        private IAcademy academy;
        public string message;

        public Student(IAcademy academy, string name)
        {

        }
        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}

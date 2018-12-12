using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex36_Observer_Pattern_2
{
    public class Academy : IAcademy
    {
        private IStudent students;

        public string message;

        public Academy(string name, string address)
        {

        }

        public void Attach(IStudent s)
        {
            throw new NotImplementedException();
        }

        public void Detach(IStudent s)
        {
            throw new NotImplementedException();
        }

        public void Notify()
        {
            throw new NotImplementedException();
        }
    }
}

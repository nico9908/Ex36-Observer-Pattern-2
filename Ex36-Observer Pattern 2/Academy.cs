﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex36_Observer_Pattern_2
{
    public class Academy : Organization, IAcademy
    {
        private List<NotifyHandler> students = new List<NotifyHandler>();
        public string message;

        public string Message
        {
            get
            {
                return message;
            }
            set
            {
                message = value;
                Notify();
            }
        }
        public Academy(string _name, string _address)
        {
            name = _name;
            Address = _address;

        }

        public void Attach(IStudent student)
        {
            students.Add(student.Update);
        }

        public void Detach(IStudent student)
        {
            students.Remove(student.Update);
        }

        public void Notify()
        {
            foreach (IStudent s in students)
            {
                s.Update(this);
            }
        }
    }
}

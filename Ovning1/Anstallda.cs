﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning1
{
    class Anstallda
            {
       private string name;
       private string salary;
        public Anstallda(string name, string salary) {
            this.name = name;
            this.salary = salary;
        }

        public string GetName() { 
        return name; }

        public string GetSalary()
        {
            return salary;
        }
        public void SkrivUtAnstallda() {
            Console.WriteLine("Namn för anställda är {0}, lön: {1}", GetName(), GetSalary());
        }

    }
}
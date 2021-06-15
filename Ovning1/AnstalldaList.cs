using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning1
{
    class AnstalldaList
    {
     
        
        
        public List<Anstallda> anstalldas = new List<Anstallda>();

        public void AddNewWorker(string name, string salary)        {
            Anstallda newWorker = new Anstallda(name, salary);      
                anstalldas.Add(newWorker);
                Console.WriteLine("Worker added: {0}", name);        

        }

        public void GetAllWorker()
        {
            Console.WriteLine("All worker: ");
            foreach (Anstallda elem in anstalldas)
            {               
                Console.WriteLine(elem);
            }

        }

    }
}

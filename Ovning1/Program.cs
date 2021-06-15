using System;

namespace Ovning1
{
    public class Program
    {
       public string name, salary;

       public AnstalldaList list = new AnstalldaList();//-----------------------------------------

        static void Main(string[] args)
        {

            Program prog = new Program();
            prog.GetNewWorker();           
            prog.GetWorkerList();
        }

        public  void GetNewWorker() {
            do {      
                Console.WriteLine("Write name for the new worker: ");
                name = Console.ReadLine();

                Console.WriteLine("Write salary for the new worker: ");
                salary = Console.ReadLine();
                list.AddNewWorker(name, salary);            
            } while (name != "");
            
                } 
        

        public void GetWorkerList() {
            list.GetAllWorker();
        }
    }
}

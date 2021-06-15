using System;

namespace Ovning1
{
    public class Program
    {
       public string name, salary;
        string answer;
        public AnstalldaList list = new AnstalldaList();//-----------------------------------------

        static void Main(string[] args)
        {

            Program prog = new Program();
            prog.GetNewWorker();           
            prog.GetWorkerList();
        }

        public  void GetNewWorker() {
            /*
            do {      
                Console.WriteLine("Write name for the new worker: ");
                name = Console.ReadLine();

                Console.WriteLine("Write salary for the new worker: ");
                salary = Console.ReadLine();
                list.AddNewWorker(name, salary);            
            } while (name != "");
            */


            do { 

            Console.WriteLine("Write name for the new worker: ");
            name = Console.ReadLine();

                if (name != "")
                {
                    Console.WriteLine("Write salary for the new worker: ");
                    salary = Console.ReadLine();
                    list.AddNewWorker(name, salary);
                }
                else Console.WriteLine("you dont register anything");
              
                } while (name != "") ;










                } 
        

        public void GetWorkerList() {
            list.GetAllWorker();
        }
    }
}

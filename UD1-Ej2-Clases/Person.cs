using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UD1_Ej2_Clases
{
    public class Person
    {

        //Variables
        private int salary;
        public string Name { get; set; }
        public int Salary
        {
            get { return salary; }
            set
            {
                if (value > 0)
                {
                    salary = value;
                }
                else
                {
                    salary = 0;
                }
            }
        }

            //Metodos

            public Person()
            {
                Name = "Juan";
                Salary = 1500;
            }


        
            public void MostrarInformacion()
            {
                Console.WriteLine($"Nombre de la persona: {Name} y su salario {Salary}");
            }

        }
    
}

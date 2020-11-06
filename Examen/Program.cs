using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    class Program
    {
        static void Main(string[] args)
        {
            Cargar();
        }
       private  static double Cargar()
        {
           Double[] Sueldo = new Double[5];
          Console.WriteLine("Sueldo de los empleados");
          Console.WriteLine("Digite el primer sueldo");
          Sueldo[1]  = Convert.ToInt32(Console.ReadLine());
          Console.WriteLine("Digite el segundo sueldo");
          Sueldo[2]   = Convert.ToInt32(Console.ReadLine());
          Console.WriteLine("Digite el tercer sueldo");
          Sueldo[3]   = Convert.ToInt32(Console.ReadLine());
          Console.WriteLine("Digite el cuarto sueldo");
          Sueldo[4]   = Convert.ToInt32(Console.ReadLine());
          Console.WriteLine("Digite el quinto sueldo");
          Sueldo[5]   = Convert.ToInt32(Console.ReadLine());
         
            
        }
       private  static double mostrar()
        {

            Console.WriteLine("sueldo 1= {0}", Cargar());
            Console.WriteLine("sueldo 2= {1}", Cargar());
            Console.WriteLine("sueldo 3= {2}", Cargar());
            Console.WriteLine("sueldo 4= {3}", Cargar());
            Console.WriteLine("sueldo 5= {4}", Cargar());
            return (mostrar());
            
        }
        
        
            
        
    }
}

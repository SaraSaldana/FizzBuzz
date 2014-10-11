using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
   public   class Multiplos
    {
       public string  Multiplo( int  num)
       {
            var respuesta = "";

           if ( num % 3 == 0 && num % 5== 0)
          {
              respuesta += "FizzBuzz";
              num -= 15;
          }

         else if (num % 5 == 0)
            {
                respuesta += "Buzz";
                num -= 5;
            }
            
          else if  (num%3==0 )
                {
                    respuesta += "Fizz";
                    num -= 3;
                }
          
          else  
          {
              respuesta += num;
          }
                
           
            return respuesta;
       }
    }
}

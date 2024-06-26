using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterfaceVendas
{
    public class Pagamento
    {
       protected int data { get; set; }

       private double total { get; set; }

       public Pagamento()
        {            
        }
        public Pagamento(int data, double total)
        {
            Data = data;
            Total = total;
        }
        public virtual void Mostrar()
        {
            Console.WriteLine("Data: " + data + "\tTotal: " + total);
        }

        public abstract void ProcessarPagamento();
        
        public int Data{
            get { return data;}
            set { data = value;}
        }
        public double Total{
            get { return total;}
            set { total = value;}
        } 
        
    }
}

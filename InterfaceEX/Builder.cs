using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceEX
{
    public class Builder : IDeveloper
    {
        
        public string Tool { get; set; }

        public void Create()
        {
            Console.WriteLine("Builder created something great)))");
        }
        public void Destroy()
        {
            Console.WriteLine("Builder destroyed his or her creation(((");
        }
    }
}

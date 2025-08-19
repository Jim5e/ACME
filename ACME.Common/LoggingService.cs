using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACME.Common
{
    public static class LoggingService
    {
        public static void WritetoFile(this List<ILoggable> itemstoLog)
        {
            foreach (var item in itemstoLog)
            {
                Console.WriteLine(item.Log());
            }
        }

        
    }
}

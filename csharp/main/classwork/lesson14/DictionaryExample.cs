using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp.main.classwork.lesson14
{
    class DictionaryExample
    {
        public void DictEx() {
            int int1;
            Dictionary<String, Int32> warehouse = new Dictionary<string, int>();
            warehouse.Add("Zara", 8);
            warehouse.Add("Dior", 21);
            warehouse.Add("DG", 11);
            if (warehouse.TryGetValue("Dior", out int1)) {
                Console.WriteLine(warehouse["Dior"]);
            }
        }
    }
}

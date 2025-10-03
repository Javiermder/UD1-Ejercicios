using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UD1_Ej6_list
{
    public class Chrome
    {
        //Propiedades
        public int CodeChrome { get; set; }
        public string NameChrome { get; set; }

        public enum CategoryChrome { Gold, Silver, Bronze }

        public CategoryChrome Categories { get; set; }

        //Metodos y constructores

        public Chrome() { }
        public Chrome(int code, string name, CategoryChrome categories ) {
            CodeChrome = code;
            NameChrome = name;
            Categories = categories;
        }
    }
}

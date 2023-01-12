using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorProject.Loops
{
    public class Product
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public float Price { get; set; }
        public Guid Guid { get; set; }

        //Constructor de Objeto -> Siempre utilizarlo sin parametros ya que se autogenera
        public Product() 
        { 
            Guid = Guid.NewGuid();
        }

        //Autollama al metodo set() -> Al escribir
        public Product(int id, string name, float price)
        {
            //Acedemos a las Automatic Propierties para acceder a los atributos privados
            Id = id;
            Name = name;
            Price = price;
            Guid = Guid.NewGuid();
        }

        //Autollama al metodo get() -> Al leer/Obtener/Mostrar
        public override string ToString()
        {
            return "Product: " + Id + ","+Name +","+Price+".";
        }
    }
}

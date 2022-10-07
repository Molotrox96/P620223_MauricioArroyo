using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class Categoria
    {
        //primero escribimos las propiedades simples

       public int IDCategoria { get; set; } 
        
       public string nombreCategoria { get; set; }

        
        //escribimos las funciones y metodos(operaciones)
        public DataTable Listar()
        {
            DataTable R = new DataTable();
            
            //TODO: hay que programar la llamada al SP que retorna datos
            
            return R;


        }
    }
}

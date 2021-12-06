using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib.DAL
{
    public class Fruta
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public DateTime fechaModificado { get; set; }
        public Forma forma { get; set; }

        public Fruta()
        {
            this.nombre = "Sin asignar";
            this.descripcion = "Sin asignar";
        }
        public Fruta(COR_Fruta fruta)
        {
            this.nombre = fruta.Nombre;
            this.descripcion = fruta.Descripcion;
            this.fechaModificado = DateTime.Now;
        }

        public void save()
        {
            using(FrutaEntities ctx = new FrutaEntities())
            {
                COR_Fruta fruta = ctx.COR_Fruta.Where(x => x.ID == this.id).FirstOrDefault();
                if (fruta == null)
                {
                    fruta = new COR_Fruta();
                    ctx.COR_Fruta.Add(fruta);
                    ctx.SaveChanges(); 
                }
                fruta.Nombre = this.nombre;
                fruta.Descripcion = this.descripcion;
                fruta.FechaModificado  = this.fechaModificado;
                ctx.SaveChanges();
            }
        }

        public void deleteByNombre(string nombre)
        {

            using (FrutaEntities ctx = new FrutaEntities())
            {
                COR_Fruta fruta = ctx.COR_Fruta.Where(x => x.Nombre == nombre).FirstOrDefault();
                if (fruta != null)
                {
                    ctx.COR_Fruta.Remove(fruta);
                    ctx.SaveChanges();
                } else
                {
                    Console.WriteLine("La fruta introducida no existe");
                }
            }
        }

        public Fruta findById(int id)
        {
            using(FrutaEntities ctx = new FrutaEntities())
            {
                COR_Fruta fruta = ctx.COR_Fruta.Where(x => x.ID == id).FirstOrDefault();
                if(fruta == null)
                {
                    Console.WriteLine("El ID introducido no se encuentra en la base de datos");
                }

                Fruta newFruta = new Fruta(fruta);

                return newFruta;
            }
        }

        public List<Fruta> findAll()
        {
            using(FrutaEntities ctx = new FrutaEntities())
            {
                List<Fruta> frutas = ctx.COR_Fruta.ToList().Select(x=> new Fruta(x)).ToList();
                
                return frutas;
            }
        }
    }
}

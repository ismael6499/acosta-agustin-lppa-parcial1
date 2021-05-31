using practica1parciallppa1.Data;
using practica1parciallppa1.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace practica1parciallppa1.Business
{
    public class AfiliadoBiz
    {
        BaseDataService<Afiliado> db;
        public AfiliadoBiz()
        {
            db = new BaseDataService<Afiliado>();
        }

       public Afiliado Agregar(Afiliado model)
        {
           return db.Create(model);
        }

        public List<Afiliado> Listar()
        {
           
            var lista = db.Get();
            return lista;
        }

        public Afiliado Get(int id)
        {
            return db.GetById(id);
        }

        public void Eliminar(Afiliado model)
        {
            db.Delete(model);
        }

        public void Update(Afiliado model)
        {
            db.Update(model);
        }
    }
}
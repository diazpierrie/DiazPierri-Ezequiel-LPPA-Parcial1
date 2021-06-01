using DiazPierri_Ezequiel_LPPA_Parcial1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace DiazPierri_Ezequiel_LPPA_Parcial1.Services
{
    public class AfiliadoDataServices
    {
        private AfiliadoContext db;

        public AfiliadoDataServices()
        {
            this.db = new AfiliadoContext();
        }
        public List<Afiliado> TraerTodo()
        {
            return db.Afiliados.ToList();
        }

        public Afiliado TraerUno(int id)
        {
            return db.Afiliados.SingleOrDefault(o => o.Id == id);
        }

        internal void Crear(Afiliado model)
        {
            db.Afiliados.Add(model);
            db.SaveChanges();
        }

        internal void Eliminar(Afiliado model)
        {
            db.Afiliados.Attach(model);
            db.Afiliados.Remove(model);
            db.SaveChanges();
        }

        internal void Editar(Afiliado model)
        {
            db.Entry(model).State = EntityState.Modified;
            db.SaveChanges();
        }
    }
}
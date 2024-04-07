using SICO.modelos;
using SICO.modelos.viewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SICO.controladores
{
    internal class RolesControlador
    {
        public int? GetId(int? id)
        {
            try
            {
                return id; 
            }
            catch
            {
                return null; 
            }
        }

        //Consulta los registros de la tabla
        public IEnumerable<RolesViewModel> GetList()
        {
            using (SicoDBEntities db = new SicoDBEntities())
            {
                IEnumerable<RolesViewModel> list = (from roles in db.roles
                                           select new RolesViewModel
                                           {
                                               idRol = roles.id_rol,
                                               tipoRol = roles.tipo_rol,
                                               descripcion = roles.descripcion
                                           }).ToList(); 
                return list;
            }
        }

        //Inserta un nuevo registro en la tabla
        public void Save(string tipoRol, string descripcion)
        {
            try
            {
                using (SicoDBEntities db = new SicoDBEntities())
                {
                    roles objRoles = new roles();

                    objRoles.tipo_rol = tipoRol;
                    objRoles.descripcion = descripcion;

                    db.roles.Add(objRoles);
                    db.SaveChanges();
                    MessageBox.Show("El rol " + objRoles.tipo_rol + " ha sido guardado exitosamente.", null, MessageBoxButtons.OK, MessageBoxIcon.Information);
                } 
            }
            catch
            {
                MessageBox.Show("¡Ups! Algo ha salido mal. Verifica que tus datos esten correctos."); 
            }
        }

        //Modifica un registro existente en la tabla
        public void Update(int? id, string tipoRol, string descripcion)
        {
            using (SicoDBEntities db = new SicoDBEntities())
            {
                int? idEncontrado = GetId(id);

                if (idEncontrado != null)
                {
                    roles objRoles = db.roles.Find(idEncontrado);

                    objRoles.tipo_rol = tipoRol;
                    objRoles.descripcion= descripcion;

                    db.Entry(objRoles).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges(); 
                }
            }
        }

        //Consulta un registro en la tabla
        public roles Search(int? id)
        {
            using (SicoDBEntities db = new SicoDBEntities())
            {
                int? idEncontrado = GetId(id);
                roles objRoles = db.roles.Find(idEncontrado); 
                
                if(id != null)
                {
                    return objRoles;
                }

                return null; 
            }
        }

        //Elimina un registro en la tabla
        public void Delete(int? id)
        {
            int? idEncontrado = GetId(id);

            if(idEncontrado != null)
            {
                using (SicoDBEntities db = new SicoDBEntities())
                {
                    roles objRoles = db.roles.Find(idEncontrado);
                    db.roles.Remove(objRoles); 

                    db.SaveChanges();
                }
            }
        }
    }
}

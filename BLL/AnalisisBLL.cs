using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entidades;

namespace BLL
{
    public class AnalisisBLL
    {
        public static bool Guardar(OrdenAnalisis analisi)
        {
            bool paso = false;
            Contexto db = new Contexto();
            try
            {
                RepositorioBase<TipoAnalisis> prod = new RepositorioBase<TipoAnalisis>();
                RepositorioBase<Pacientes> client = new RepositorioBase<Pacientes>();



                if (db.OrdenAnalisis.Add(analisi) != null)
                {

                    foreach (var item in analisi.detalles)
                    {
                        var producto = prod.Buscar(item.TipoAnalisisId);
                        producto.CantidadVeses = producto.CantidadVeses + 1;
                        prod.Modificar(producto);

                    }

                    var cliente = client.Buscar(analisi.PacienteId);
                    cliente.Balance = cliente.Balance + analisi.Balance;
                    client.Modificar(cliente);

                    paso = db.SaveChanges() > 0;
                }

            }
            catch (Exception)
            {
                throw;
            }

            return paso;
        }
        
        public static bool Eliminar(int id)
        {
            bool paso = false;
            Contexto db = new Contexto();
     
            RepositorioBase<TipoAnalisis> prod = new RepositorioBase<TipoAnalisis>();
            RepositorioBase<Pacientes> client = new RepositorioBase<Pacientes>();


            try
            {
                OrdenAnalisis venta = db.OrdenAnalisis.Find(id);
                var cliente = client.Buscar(venta.PacienteId);
                cliente.Balance = cliente.Balance - venta.Total;
                client.Modificar(cliente);

                foreach (var item in venta.detalles)
                {
                    var producto = prod.Buscar(item.TipoAnalisisId);
                    producto.CantidadVeses = producto.CantidadVeses -1;
                    prod.Modificar(producto);

                }


                db.OrdenAnalisis.Remove(venta);
                if (db.SaveChanges() > 0)
                {
                    paso = true;

                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return paso;
        }
        
        public static void ModificarBien(OrdenAnalisis Analisis, OrdenAnalisis AnalisisAnteriores)
        {
            Contexto contexto = new Contexto();

            RepositorioBase<Pacientes> paci = new RepositorioBase<Pacientes>();
            RepositorioBase<OrdenAnalisis> orden = new RepositorioBase<OrdenAnalisis>();





            var Cliente = paci.Buscar(Analisis.PacienteId);
            var ClientesAnteriores = paci.Buscar(AnalisisAnteriores.PacienteId);

            Cliente.Balance += Analisis.Total;
            ClientesAnteriores.Balance -= AnalisisAnteriores.Total;
            paci.Modificar(Cliente);
            paci.Modificar(ClientesAnteriores);






        }

        public static bool Modificar(OrdenAnalisis Analisis)
        {
            bool paso = false;
            Contexto db = new Contexto();
            RepositorioBase<Pacientes> client = new RepositorioBase<Pacientes>();
            RepositorioBase<OrdenAnalisis> vent = new RepositorioBase<OrdenAnalisis>();
            RepositorioBase<TipoAnalisis> prod = new RepositorioBase<TipoAnalisis>();
            try
            {
                var venta = vent.Buscar(Analisis.OrdenId);

                if (Analisis.PacienteId != venta.PacienteId)
                {
                    ModificarBien(Analisis, venta);
                }

                if (Analisis != null)
                {
                    foreach (var item in venta.detalles)
                    {
                        db.TipoAnaliss.Find(item.TipoAnalisisId).CantidadVeses -=1;

                        if (!Analisis.detalles.ToList().Exists(v => v.OrdenAnalisisdetalle == item.OrdenAnalisisdetalle))
                        {

                            db.Entry(item).State = EntityState.Deleted;
                        }
                    }

                    foreach (var item in Analisis.detalles)
                    {
                        db.TipoAnaliss.Find(item.TipoAnalisisId).CantidadVeses +=1;
                        var estado = item.OrdenAnalisisdetalle > 0 ? EntityState.Modified : EntityState.Added;
                        db.Entry(item).State = estado;
                    }

                    db.Entry(Analisis).State = EntityState.Modified;
                }

              Modifica(Analisis, venta, db);

                if (db.SaveChanges() > 0)
                {
                    paso = true;
                }
                db.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }

        public static void Modifica(OrdenAnalisis factura, OrdenAnalisis FactAnt, Contexto contexto)
        {
            RepositorioBase<Pacientes> client = new RepositorioBase<Pacientes>();
            RepositorioBase<OrdenAnalisis> venta = new RepositorioBase<OrdenAnalisis>();



            decimal modificado = factura.Total - FactAnt.Total;

            var Cliente = client.Buscar(factura.PacienteId);
            Cliente.Balance += modificado;
            client.Modificar(Cliente);




            decimal balance = factura.Total - FactAnt.Total;
            FactAnt.Balance += balance;
            factura.Balance = FactAnt.Balance;
            venta.Modificar(factura);

        }


    }
}

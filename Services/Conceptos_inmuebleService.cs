using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Claims;
using System.Text;
using Microsoft.Extensions.Options;
using Tasa_back.Entities;
namespace Tasa_back.Services
{
    public class Conceptos_inmuebleService : IConceptos_inmuebleService
    {
        public Conceptos_inmueble getByPk(int cod_concepto_inmueble)
        {
            try
            {
                return Conceptos_inmueble.getByPk(cod_concepto_inmueble);
            }
            catch (Exception)
            {
                throw;
            }
        }
        public List<Conceptos_inmueble> read()
        {
            try
            {
                return Conceptos_inmueble.read();
            }
            catch (Exception)
            {
                throw;
            }
        }
        public int insert(Conceptos_inmueble obj)
        {
            try
            {
                return Conceptos_inmueble.insert(obj);
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void update(Conceptos_inmueble obj)
        {
            try
            {
                Conceptos_inmueble.update(obj);
            }
            catch (Exception )
            {
                throw ;
            }
        }
        public void delete(Conceptos_inmueble obj)
        {
            try
            {
                Conceptos_inmueble.delete(obj);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}


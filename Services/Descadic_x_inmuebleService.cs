using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Transactions;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using Tasa_back.Entities;
using Tasa_back.Entities.AUDITORIA;

namespace Tasa_back.Services
{
    public class Descadic_x_inmuebleService : IDescadic_x_inmuebleService
    {
        public List<Descadic_x_inmueble> getByPk(
    int circunscripcion, int seccion, int manzana, int parcela, int p_h,
    int cod_concepto_inmueble)
        {
            try
            {
                return Descadic_x_inmueble.getByPk(
                    circunscripcion, seccion, manzana, parcela, p_h, cod_concepto_inmueble);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<Descadic_x_inmueble> listConceptosXinmueble(
    int circunscripcion, int seccion, int manzana, int parcela, int p_h)
        {
            try
            {
                return Descadic_x_inmueble.listConceptosXinmueble(
                    circunscripcion, seccion, manzana, parcela, p_h);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<Descadic_x_inmueble> read()
        {
            try
            {
                return Descadic_x_inmueble.read();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int insert(Descadic_x_inmueble obj)
        {
            using (TransactionScope scope = new TransactionScope())
            {
                int id = 0;
                obj.objAuditoria.identificacion = Utils.armoDenominacion2(
                    obj.circunscripcion, obj.seccion, obj.manzana, obj.parcela, obj.p_h);
                obj.objAuditoria.proceso = "MODIFICACION DE CONCEPTO";
                obj.objAuditoria.detalle = JsonConvert.SerializeObject(
                    Entities.Inmuebles.getByPk(
                    obj.circunscripcion, obj.seccion, obj.manzana, obj.parcela, obj.p_h)); obj.objAuditoria.observaciones += string.Format(" Fecha auditoria: {0}", DateTime.Now);
                id = Descadic_x_inmueble.insert(obj);
                AuditoriaD.InsertAuditoria(obj.objAuditoria);
                scope.Complete();
                return id;
            }
        }
        public void update(Descadic_x_inmueble obj)
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    obj.objAuditoria.identificacion = Utils.armoDenominacion2(
                        obj.circunscripcion, obj.seccion, obj.manzana, obj.parcela, obj.p_h);
                    obj.objAuditoria.proceso = "MODIFICACION DE CONCEPTO";
                    obj.objAuditoria.detalle = Utils.armoDenominacion(
                        obj.circunscripcion, obj.seccion, obj.manzana, obj.parcela, obj.p_h);
                    obj.objAuditoria.observaciones += string.Format(" Fecha auditoria: {0}", DateTime.Now);
                    Descadic_x_inmueble.update(obj);
                    AuditoriaD.InsertAuditoria(obj.objAuditoria);
                    scope.Complete();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void delete(Descadic_x_inmueble obj)
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    Auditoria objAuditoria = new Entities.AUDITORIA.Auditoria();
                    objAuditoria.identificacion = Utils.armoDenominacion2(
                        obj.circunscripcion, obj.seccion, obj.manzana, obj.parcela, obj.p_h);
                    objAuditoria.proceso = "BAJA DE CONCEPTO";
                    objAuditoria.detalle = JsonConvert.SerializeObject(
                        Entities.Inmuebles.getByPk(
                        obj.circunscripcion, obj.seccion, obj.manzana, obj.parcela, obj.p_h));
                    objAuditoria.observaciones += string.Format(" Fecha auditoria: {0}", DateTime.Now);
                    Descadic_x_inmueble.delete(obj);
                    scope.Complete();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}


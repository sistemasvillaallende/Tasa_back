
using Tasa_back.Entities;

namespace Tasa_back.Services
{
    public class Ctasctes_inmueblesService : ICtasctes_inmueblesService
    {
        public List<Ctasctes_inmuebles> ListarCtacte(
    int cir, int sec, int man, int par, int p_h, int tipo_consulta,
        int cate_deuda_desde, int cate_deuda_hasta)
        {
            try
            {
                return Ctasctes_inmuebles.ListarCtacte(cir, sec, man, par, p_h,
                    tipo_consulta, cate_deuda_desde, cate_deuda_hasta);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public string Datos_transaccion(int tipo_transaccion, int nro_transaccion)
        {
            try
            {
                return Ctasctes_inmuebles.Datos_transaccion(tipo_transaccion, nro_transaccion);
            }
            catch (Exception)
            {
                throw;
            }
        }
        public List<DETALLE_DEUDA> DetalleDeuda(int nroTransaccion)
        {
            try
            {
                return DETALLE_DEUDA.read(nroTransaccion);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DETALLE_PAGO DetallePago(int nroCedulon, int nroTransaccion)
        {
            try
            {
                DETALLE_PAGO objDet = DETALLE_PAGO.read(nroCedulon, nroTransaccion);
                return objDet;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Ctasctes_inmuebles getByPk(int tipo_transaccion, int nro_transaccion, int nro_pago_parcial)
        {
            try
            {
                return Ctasctes_inmuebles.getByPk(tipo_transaccion, nro_transaccion, nro_pago_parcial);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<Ctasctes_inmuebles> read()
        {
            try
            {
                return Ctasctes_inmuebles.read();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int insert(Ctasctes_inmuebles obj)
        {
            try
            {
                return Ctasctes_inmuebles.insert(obj);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void update(Ctasctes_inmuebles obj)
        {
            try
            {
                Ctasctes_inmuebles.update(obj);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void delete(Ctasctes_inmuebles obj)
        {
            try
            {
                Ctasctes_inmuebles.delete(obj);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public GrillaTasa DetalleProcuracion(int nro_proc)
        {
            try
            {
                return GrillaTasa.DetalleProcuracion(nro_proc);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public PlanPago DetPlanPago(int nro_plan)
        {
            try
            {
                PlanPago objPlan = PlanPago.get(nro_plan);
                objPlan.procuraciones_incluidas = PlanPago.getProcuraciones(nro_plan, 1);

                return objPlan;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<LstDeudaTasa> getListDeudaTasa(int cir, int sec, int man, int par, int p_h)
        {
            try
            {
                List<LstDeudaTasa> lst = LstDeudaTasa.getListDeudaTasa(cir, sec, man, par, p_h);

                return lst;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<LstDeudaTasa> getListDeudaTasaProcurada(int cir, int sec, int man, int par, int p_h)
        {
            try
            {
                return LstDeudaTasa.getListDeudaTasaProcurada(cir, sec, man, par, p_h);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public List<LstDeudaTasa> getListDeudaTasaNoVencida(int cir, int sec, int man, int par, int p_h)
        {
            try
            {
                return LstDeudaTasa.getListDeudaTasaNoVencida(cir, sec, man, par, p_h);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<Combo> ListarCategoriasTasa()
        {
            try
            {
                return Ctasctes_inmuebles.ListarCategoriasTasa();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}


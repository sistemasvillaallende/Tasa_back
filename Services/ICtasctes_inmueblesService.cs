using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tasa_back.Entities;
namespace Tasa_back.Services
{
    public interface ICtasctes_inmueblesService
    {
        public List<Ctasctes_inmuebles> read();
        public Ctasctes_inmuebles getByPk(int tipo_transaccion, int nro_transaccion, int nro_pago_parcial);
        public int insert(Ctasctes_inmuebles obj);
        public void update(Ctasctes_inmuebles obj);
        public void delete(Ctasctes_inmuebles obj);
        public List<Ctasctes_inmuebles> ListarCtacte(
    int cir, int sec, int man, int par, int p_h, int tipo_consulta,
        int cate_deuda_desde, int cate_deuda_hasta);
        public List<DETALLE_DEUDA> DetalleDeuda(int nroTransaccion);
        public string Datos_transaccion(int tipo_transaccion, int nro_transaccion);
        public DETALLE_PAGO DetallePago(int nroCedulon, int nroTransaccion);
        public GrillaTasa DetalleProcuracion(int nro_proc);
        public PlanPago DetPlanPago(int nro_plan);
        public List<LstDeudaTasa> getListDeudaTasa(int cir, int sec, int man, int par, int p_h);
        public List<LstDeudaTasa> getListDeudaTasaProcurada(int cir, int sec, int man, int par, int p_h);
        public List<LstDeudaTasa> getListDeudaTasaNoVencida(int cir, int sec, int man, int par, int p_h);
        public List<Combo> ListarCategoriasTasa();
    }
}


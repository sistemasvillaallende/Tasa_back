using Microsoft.AspNetCore.Mvc;
using IHostingEnvironment = Microsoft.AspNetCore.Hosting.IHostingEnvironment;
using Tasa_back.Services;
using Tasa_back.Entities;

namespace Tasa_back.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class Ctasctes_inmueblesController : Controller
    {
        private ICtasctes_inmueblesService _Ctasctes_inmuebles;
        public Ctasctes_inmueblesController(ICtasctes_inmueblesService Ctasctes_inmueblesService)
        {
            _Ctasctes_inmuebles = Ctasctes_inmueblesService;
        }
        [HttpGet]
        public ActionResult<List<Ctasctes_inmuebles>> ListarCtacte(
            int cir, int sec, int man, int par, int p_h, int tipo_consulta, 
            int cate_deuda_desde, int cate_deuda_hasta)
        {
            var Ctasctes = _Ctasctes_inmuebles.ListarCtacte(
                cir, sec, man, par, p_h, tipo_consulta, cate_deuda_desde, cate_deuda_hasta);

            return Ok(Ctasctes);
        }
        [HttpGet]
        public ActionResult<List<DETALLE_DEUDA>> DetalleDeuda(int nro_transaccion)
        {
            var Ctasctes = _Ctasctes_inmuebles.DetalleDeuda(nro_transaccion);

            return Ok(Ctasctes);
        }
        [HttpGet]
        public ActionResult DetalleProcuracion(int nro_proc)
        {
            var Ctasctes = _Ctasctes_inmuebles.DetalleProcuracion(nro_proc);

            return Ok(Ctasctes);
        }
        [HttpGet]
        public ActionResult DetallePlan(int nro_plan)
        {
            var Ctasctes = _Ctasctes_inmuebles.DetPlanPago(nro_plan);

            return Ok(Ctasctes);
        }
        [HttpGet]
        public ActionResult<string> Datos_transaccion(int tipo_transaccion, int nro_transaccion)
        {
            var Transaccion = _Ctasctes_inmuebles.Datos_transaccion(tipo_transaccion, nro_transaccion);
            if (Transaccion == null)
            {
                return BadRequest(new { message = "No se encontraron datos!" });
            }
            return Ok(Transaccion);
        }
        [HttpGet]
        public ActionResult DetallePago(int nro_cedulon, int nro_transaccion)
        {
            var Transaccion = _Ctasctes_inmuebles.DetallePago(nro_cedulon, nro_transaccion);
            if (Transaccion == null)
            {
                return BadRequest(new { message = "No se encontraron datos!" });
            }
            return Ok(Transaccion);
        }
        [HttpGet]
        public ActionResult getListDeudaTasa(int cir, int sec, int man, int par, int p_h)
        {
            var lstDeuda = _Ctasctes_inmuebles.getListDeudaTasa(cir, sec, man, par, p_h);
            if (lstDeuda == null)
            {
                return BadRequest(new { message = "No se encontraron datos!" });
            }
            return Ok(lstDeuda);
        }
        [HttpGet]
        public ActionResult getListDeudaTasaNoVencida(int cir, int sec, int man, int par, int p_h)
        {
            var lstDeuda = _Ctasctes_inmuebles.getListDeudaTasaNoVencida(cir, sec, man, par, p_h);
            if (lstDeuda == null)
            {
                return BadRequest(new { message = "No se encontraron datos!" });
            }
            return Ok(lstDeuda);
        }
        [HttpGet]
        public ActionResult getListDeudaTasaProcurada(int cir, int sec, int man, int par, int p_h)
        {
            var lstDeuda = _Ctasctes_inmuebles.getListDeudaTasaProcurada(cir, sec, man, par, p_h);
            if (lstDeuda == null)
            {
                return BadRequest(new { message = "No se encontraron datos!" });
            }
            return Ok(lstDeuda);
        }
        [HttpGet]
        public ActionResult<List<Combo>> ListarCategoriasTasa()
        {
            var categorias = _Ctasctes_inmuebles.ListarCategoriasTasa();
            return Ok(categorias);
        }
    }
}






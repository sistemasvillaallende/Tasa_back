using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tasa_back.Helpers;

namespace Tasa_back.Entities
{
    public class Ctasctes_inmuebles : DALBase
    {
        public int tipo_transaccion { get; set; }
        public int nro_transaccion { get; set; }
        public int circunscripcion { get; set; }
        public int seccion { get; set; }
        public int manzana { get; set; }
        public int parcela { get; set; }
        public int p_h { get; set; }
        public DateTime fecha_transaccion { get; set; }
        public string periodo { get; set; }
        public bool cedulon_impreso { get; set; }
        public int nro_pago_parcial { get; set; }
        public decimal monto_original { get; set; }
        public int nro_plan { get; set; }
        public bool pagado { get; set; }
        public decimal debe { get; set; }
        public decimal haber { get; set; }
        public bool deuda_activa { get; set; }
        public bool pago_parcial { get; set; }
        public int categoria_deuda { get; set; }
        public int nro_procuracion { get; set; }
        public DateTime vencimiento { get; set; }
        public int nro_cedulon { get; set; }
        public decimal monto_pagado { get; set; }
        public decimal recargo { get; set; }
        public decimal honorarios { get; set; }
        public decimal iva_hons { get; set; }
        public Int16 tipo_deuda { get; set; }
        public string decreto { get; set; }
        public string observaciones { get; set; }
        public Int64 nro_cedulon_paypertic { get; set; }
        //
        //Las propiedades de abajo son
        //
        public string des_movimiento { get; set; }
        public string des_categoria { get; set; }
        public decimal deuda { get; set; }
        public int sel { get; set; }
        public decimal costo_financiero { get; set; }
        public string des_rubro { get; set; }
        public int cod_tipo_per { get; set; }
        public decimal sub_total { get; set; }
        public Ctasctes_inmuebles()
        {
            des_categoria = string.Empty;
            des_movimiento = string.Empty;
            deuda = int.MinValue;
            sel = int.MinValue;
            costo_financiero = decimal.MinValue;
            des_rubro = string.Empty;
            tipo_transaccion = 0;
            nro_transaccion = 0;
            circunscripcion = 0;
            seccion = 0;
            manzana = 0;
            parcela = 0;
            p_h = 0;
            fecha_transaccion = DateTime.Now;
            periodo = string.Empty;
            cedulon_impreso = false;
            nro_pago_parcial = 0;
            monto_original = 0;
            nro_plan = 0;
            pagado = false;
            debe = 0;
            haber = 0;
            deuda_activa = false;
            pago_parcial = false;
            categoria_deuda = 0;
            nro_procuracion = 0;
            vencimiento = DateTime.Now;
            nro_cedulon = 0;
            monto_pagado = 0;
            recargo = 0;
            honorarios = 0;
            iva_hons = 0;
            tipo_deuda = 0;
            decreto = string.Empty;
            observaciones = string.Empty;
            nro_cedulon_paypertic = 0;
        }

        private static List<Ctasctes_inmuebles> mapeo(SqlDataReader dr)
        {
            List<Ctasctes_inmuebles> lst = new List<Ctasctes_inmuebles>();
            Ctasctes_inmuebles obj;
            if (dr.HasRows)
            {
                int tipo_transaccion = dr.GetOrdinal("tipo_transaccion");
                int nro_transaccion = dr.GetOrdinal("nro_transaccion");
                int circunscripcion = dr.GetOrdinal("circunscripcion");
                int seccion = dr.GetOrdinal("seccion");
                int manzana = dr.GetOrdinal("manzana");
                int parcela = dr.GetOrdinal("parcela");
                int p_h = dr.GetOrdinal("p_h");
                int fecha_transaccion = dr.GetOrdinal("fecha_transaccion");
                int periodo = dr.GetOrdinal("periodo");
                int cedulon_impreso = dr.GetOrdinal("cedulon_impreso");
                int nro_pago_parcial = dr.GetOrdinal("nro_pago_parcial");
                int monto_original = dr.GetOrdinal("monto_original");
                int nro_plan = dr.GetOrdinal("nro_plan");
                int pagado = dr.GetOrdinal("pagado");
                int debe = dr.GetOrdinal("debe");
                int haber = dr.GetOrdinal("haber");
                int deuda_activa = dr.GetOrdinal("deuda_activa");
                int pago_parcial = dr.GetOrdinal("pago_parcial");
                int categoria_deuda = dr.GetOrdinal("categoria_deuda");
                int nro_procuracion = dr.GetOrdinal("nro_procuracion");
                int vencimiento = dr.GetOrdinal("vencimiento");
                int nro_cedulon = dr.GetOrdinal("nro_cedulon");
                int monto_pagado = dr.GetOrdinal("monto_pagado");
                int recargo = dr.GetOrdinal("recargo");
                int honorarios = dr.GetOrdinal("honorarios");
                int iva_hons = dr.GetOrdinal("iva_hons");
                int tipo_deuda = dr.GetOrdinal("tipo_deuda");
                int decreto = dr.GetOrdinal("decreto");
                int observaciones = dr.GetOrdinal("observaciones");
                int nro_cedulon_paypertic = dr.GetOrdinal("nro_cedulon_paypertic");
                while (dr.Read())
                {
                    obj = new Ctasctes_inmuebles();
                    if (!dr.IsDBNull(tipo_transaccion)) { obj.tipo_transaccion = dr.GetInt32(tipo_transaccion); }
                    if (!dr.IsDBNull(nro_transaccion)) { obj.nro_transaccion = dr.GetInt32(nro_transaccion); }
                    if (!dr.IsDBNull(circunscripcion)) { obj.circunscripcion = dr.GetInt32(circunscripcion); }
                    if (!dr.IsDBNull(seccion)) { obj.seccion = dr.GetInt32(seccion); }
                    if (!dr.IsDBNull(manzana)) { obj.manzana = dr.GetInt32(manzana); }
                    if (!dr.IsDBNull(parcela)) { obj.parcela = dr.GetInt32(parcela); }
                    if (!dr.IsDBNull(p_h)) { obj.p_h = dr.GetInt32(p_h); }
                    if (!dr.IsDBNull(fecha_transaccion)) { obj.fecha_transaccion = dr.GetDateTime(fecha_transaccion); }
                    if (!dr.IsDBNull(periodo)) { obj.periodo = dr.GetString(periodo); }
                    if (!dr.IsDBNull(cedulon_impreso)) { obj.cedulon_impreso = dr.GetBoolean(cedulon_impreso); }
                    if (!dr.IsDBNull(nro_pago_parcial)) { obj.nro_pago_parcial = dr.GetInt32(nro_pago_parcial); }
                    if (!dr.IsDBNull(monto_original)) { obj.monto_original = dr.GetDecimal(monto_original); }
                    if (!dr.IsDBNull(nro_plan)) { obj.nro_plan = dr.GetInt32(nro_plan); }
                    if (!dr.IsDBNull(pagado)) { obj.pagado = dr.GetBoolean(pagado); }
                    if (!dr.IsDBNull(debe)) { obj.debe = dr.GetDecimal(debe); }
                    if (!dr.IsDBNull(haber)) { obj.haber = dr.GetDecimal(haber); }
                    if (!dr.IsDBNull(deuda_activa)) { obj.deuda_activa = dr.GetBoolean(deuda_activa); }
                    if (!dr.IsDBNull(pago_parcial)) { obj.pago_parcial = dr.GetBoolean(pago_parcial); }
                    if (!dr.IsDBNull(categoria_deuda)) { obj.categoria_deuda = dr.GetInt32(categoria_deuda); }
                    if (!dr.IsDBNull(nro_procuracion)) { obj.nro_procuracion = dr.GetInt32(nro_procuracion); }
                    if (!dr.IsDBNull(vencimiento)) { obj.vencimiento = dr.GetDateTime(vencimiento); }
                    if (!dr.IsDBNull(nro_cedulon)) { obj.nro_cedulon = dr.GetInt32(nro_cedulon); }
                    if (!dr.IsDBNull(monto_pagado)) { obj.monto_pagado = dr.GetDecimal(monto_pagado); }
                    if (!dr.IsDBNull(recargo)) { obj.recargo = dr.GetDecimal(recargo); }
                    if (!dr.IsDBNull(honorarios)) { obj.honorarios = dr.GetDecimal(honorarios); }
                    if (!dr.IsDBNull(iva_hons)) { obj.iva_hons = dr.GetDecimal(iva_hons); }
                    if (!dr.IsDBNull(tipo_deuda)) { obj.tipo_deuda = dr.GetInt16(tipo_deuda); }
                    if (!dr.IsDBNull(decreto)) { obj.decreto = dr.GetString(decreto); }
                    if (!dr.IsDBNull(observaciones)) { obj.observaciones = dr.GetString(observaciones); }
                    if (!dr.IsDBNull(nro_cedulon_paypertic)) { obj.nro_cedulon_paypertic = dr.GetInt64(nro_cedulon_paypertic); }
                    lst.Add(obj);
                }
            }
            return lst;
        }

        public static List<Ctasctes_inmuebles> read()
        {
            try
            {
                List<Ctasctes_inmuebles> lst = new List<Ctasctes_inmuebles>();
                using (SqlConnection con = GetConnection())
                {
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "SELECT *FROM Ctasctes_inmuebles";
                    cmd.Connection.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    lst = mapeo(dr);
                    return lst;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static string Datos_transaccion(int tipo_transaccion, int nro_transaccion)
        {
            try
            {
                string strSQL = @"SELECT A.*, B.des_categoria,
                                    des_movimiento=(SELECT t.Descripcion 
                                                FROM TIPOS_TRANSACCIONES t 
                                                WHERE t.tipo_transaccion=a.Tipo_transaccion)
                                    FROM CTASCTES_INMUEBLES A
                                    JOIN CATE_DEUDA_INMUEBLE B on
                                      A.categoria_deuda=B.cod_categoria
                                    WHERE
                                      A.tipo_transaccion=@tipo_transaccion AND
                                      A.nro_transaccion=@nro_transaccion";
                DateTimeFormatInfo culturaFecArgentina = new CultureInfo("es-AR", false).DateTimeFormat;
                StringBuilder strRetorno = new StringBuilder();
                List<Ctasctes_inmuebles> lst = new List<Ctasctes_inmuebles>();
                using (SqlConnection con = GetConnection())
                {
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = strSQL.ToString();
                    cmd.Parameters.AddWithValue("@nro_transaccion", nro_transaccion);
                    cmd.Parameters.AddWithValue("@tipo_transaccion", tipo_transaccion);
                    cmd.Connection.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    Ctasctes_inmuebles? obj;
                    obj = new();
                    if (dr.HasRows)
                    {
                        int des_movimiento = dr.GetOrdinal("des_movimiento");
                        int periodo = dr.GetOrdinal("periodo");
                        int vencimiento = dr.GetOrdinal("vencimiento");
                        int fecha_transaccion = dr.GetOrdinal("fecha_transaccion");
                        int monto_original = dr.GetOrdinal("monto_original");
                        int debe = dr.GetOrdinal("debe");
                        int haber = dr.GetOrdinal("haber");
                        int nro_plan = dr.GetOrdinal("nro_plan");
                        int nro_procuracion = dr.GetOrdinal("nro_procuracion");
                        int categoria = dr.GetOrdinal("des_categoria");
                        int nro_cedulon = dr.GetOrdinal("nro_cedulon");
                        int monto_pagado = dr.GetOrdinal("monto_pagado");
                        while (dr.Read())
                        {
                            //obj = new();
                            obj.tipo_transaccion = tipo_transaccion;
                            obj.nro_transaccion = nro_transaccion;
                            if (!dr.IsDBNull(des_movimiento)) { obj.des_movimiento = dr.GetString(des_movimiento); }
                            if (!dr.IsDBNull(periodo)) { obj.periodo = dr.GetString(periodo); }
                            if (!dr.IsDBNull(vencimiento)) { obj.vencimiento = Convert.ToDateTime(dr.GetDateTime(vencimiento), culturaFecArgentina); }
                            if (!dr.IsDBNull(fecha_transaccion)) { obj.fecha_transaccion = Convert.ToDateTime(dr.GetDateTime(fecha_transaccion), culturaFecArgentina); }
                            if (!dr.IsDBNull(monto_original)) { obj.monto_original = dr.GetDecimal(monto_original); }
                            if (!dr.IsDBNull(debe)) { obj.debe = dr.GetDecimal(debe); }
                            if (!dr.IsDBNull(haber)) { obj.haber = dr.GetDecimal(haber); }
                            if (!dr.IsDBNull(nro_plan)) { obj.nro_plan = dr.GetInt32(nro_plan); }
                            if (!dr.IsDBNull(nro_procuracion)) { obj.nro_procuracion = dr.GetInt32(nro_procuracion); }
                            if (!dr.IsDBNull(categoria)) { obj.des_categoria = dr.GetString(categoria); }
                            if (!dr.IsDBNull(nro_cedulon)) { obj.nro_cedulon = dr.GetInt32(nro_cedulon); }
                            if (!dr.IsDBNull(monto_pagado)) { obj.monto_pagado = dr.GetDecimal(monto_pagado); }
                            lst.Add(obj);
                        }
                        if (lst.Count > 0)
                            obj = lst[0];
                        strRetorno.AppendLine("Fecha Transacci�n: " + Convert.ToString(obj.fecha_transaccion, culturaFecArgentina));
                        strRetorno.AppendLine("Vencimiento: " + Convert.ToString(obj.vencimiento, culturaFecArgentina));
                        switch (obj.tipo_transaccion)
                        {
                            case 1:
                                strRetorno.AppendLine("Mov.Deuda");
                                strRetorno.AppendLine("Per�odo: " + obj.periodo);
                                strRetorno.AppendLine(obj.des_categoria.ToString());
                                if (obj.pago_parcial)
                                    strRetorno.AppendLine("Deuda con Pago Parcial");
                                strRetorno.AppendLine("Nro Transacci�n: " + obj.nro_transaccion.ToString());
                                break;
                            case 2:
                                if (obj.nro_cedulon != 0)
                                    strRetorno.AppendLine("Mov.Pago con N� Cedulon:" + obj.nro_cedulon.ToString());
                                else
                                    strRetorno.AppendLine("Mov.Pago");
                                strRetorno.AppendLine("Per�odo:" + obj.periodo.ToString());
                                strRetorno.AppendLine(obj.des_categoria);
                                if (obj.pago_parcial)
                                    strRetorno.AppendLine("Pago Parcial");
                                strRetorno.AppendLine("Nro Transacci�n: " + obj.nro_transaccion.ToString());
                                strRetorno.AppendLine("Monto Pagado:" + obj.monto_pagado.ToString());
                                break;
                            case 3:
                                strRetorno.AppendLine("Mov.Fin de Plan de Pago");
                                strRetorno.AppendLine("Plan de Pago N�:" + obj.nro_plan.ToString());
                                strRetorno.AppendLine("Nro Transaccion:" + obj.nro_transaccion.ToString());
                                strRetorno.AppendLine(obj.des_categoria);
                                break;
                            case 4:
                                strRetorno.AppendLine("Mov.Bonificaci�n por pago anticipado");
                                strRetorno.AppendLine("Nro Transaccion:" + obj.nro_transaccion.ToString());
                                strRetorno.AppendLine(obj.des_categoria);
                                break;
                            case 5:
                                strRetorno.AppendLine("Mov.Ajuste Positivo");
                                strRetorno.AppendLine("Nro Transaccion:" + obj.nro_transaccion.ToString());
                                strRetorno.AppendLine(obj.des_categoria);
                                break;
                            case 6:
                                strRetorno.AppendLine("Mov.Ajuste Negativo");
                                strRetorno.AppendLine("Nro Transaccion:" + obj.nro_transaccion.ToString());
                                strRetorno.AppendLine(obj.des_categoria);
                                break;
                            case 7:
                                strRetorno.AppendLine("Mov.Cancelaci�n Operativa");
                                strRetorno.AppendLine("Nro Transaccion:" + obj.nro_transaccion.ToString());
                                strRetorno.AppendLine(obj.des_categoria);
                                break;
                            case 8:
                                strRetorno.AppendLine("Mov.Decreto o Resoluci�n");
                                strRetorno.AppendLine("Nro Transaccion:" + obj.nro_transaccion.ToString());
                                strRetorno.AppendLine(obj.des_categoria);
                                break;
                            case 9:
                                strRetorno.AppendLine("Mov.Baja de Plan de Pagos");
                                strRetorno.AppendLine("Plan de Pago N�:" + obj.nro_plan.ToString());
                                strRetorno.AppendLine("Nro Transaccion:" + obj.nro_transaccion.ToString());
                                strRetorno.AppendLine(obj.des_categoria);
                                break;
                            default:
                                break;
                        }
                    }
                    if (obj.nro_cedulon > 0)
                    { strRetorno.AppendLine(Tipos_pago(obj.nro_cedulon)); }
                    string texto = strRetorno.ToString();
                    string[] lineas = texto.Split(new[] { Environment.NewLine }, StringSplitOptions.None);
                    string ret = "<div>";
                    foreach (string linea in lineas)
                    {
                        ret += string.Format("<p>{0}</p>", linea);
                    }
                    ret += "</div>";
                    return ret;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        public static Ctasctes_inmuebles getByPk(
        int tipo_transaccion, int nro_transaccion, int nro_pago_parcial)
        {
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.AppendLine("SELECT *FROM Ctasctes_inmuebles WHERE");
                sql.AppendLine("tipo_transaccion = @tipo_transaccion");
                sql.AppendLine("AND nro_transaccion = @nro_transaccion");
                sql.AppendLine("AND nro_pago_parcial = @nro_pago_parcial");
                Ctasctes_inmuebles obj = null;
                using (SqlConnection con = GetConnection())
                {
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = sql.ToString();
                    cmd.Parameters.AddWithValue("@tipo_transaccion", tipo_transaccion);
                    cmd.Parameters.AddWithValue("@nro_transaccion", nro_transaccion);
                    cmd.Parameters.AddWithValue("@nro_pago_parcial", nro_pago_parcial);
                    cmd.Connection.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    List<Ctasctes_inmuebles> lst = mapeo(dr);
                    if (lst.Count != 0)
                        obj = lst[0];
                }
                return obj;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static List<Ctasctes_inmuebles> ListarCtacte(
            int cir, int sec, int man, int par, int p_h, int tipo_consulta, 
                int cate_deuda_desde, int cate_deuda_hasta)
        {
            try
            {
                DateTimeFormatInfo culturaFecArgentina = new CultureInfo("es-AR", false).DateTimeFormat;
                StringBuilder strSql = new StringBuilder();
                strSql.AppendLine(@"SELECT 
	                                movimiento=
		                                (SELECT t.Descripcion 
		                                FROM TIPOS_TRANSACCIONES t 
		                                WHERE t.tipo_transaccion=a.Tipo_transaccion), 
	                                a.tipo_transaccion, 
	                                a.nro_transaccion, 
	                                a.periodo, 
	                                a.fecha_transaccion, 
	                                a.monto_original, 
	                                a.debe, 
	                                a.haber, 
	                                a.nro_plan, 
	                                a.nro_procuracion,
	                                categoria = 
		                                (SELECT c.des_categoria 
		                                FROM CATE_DEUDA_INMUEBLE c 
		                                WHERE c.cod_categoria = a.Categoria_deuda ),
	                                a.pagado,
	                                a.nro_cedulon
                                FROM CTASCTES_INMUEBLES A WITH (NOLOCK) 
                                WHERE  
	                                A.circunscripcion=@cir AND  
	                                A.seccion=@sec AND 
	                                A.manzana=@man AND 
	                                A.parcela=@par AND 
	                                A.p_h=@p_h AND 
	                                A.deuda_activa = 1 AND");
                if (tipo_consulta == 1)// toda la cuenta corriente
                {
                    if (cate_deuda_desde == cate_deuda_hasta)
                    {
                        strSql.AppendLine(@"A.categoria_deuda = @categoria_desde");
                    }
                    else
                    {
                        strSql.AppendLine(@"A.categoria_deuda between @categoria_desde and @categoria_hasta");
                    }
                    strSql.AppendLine(@"ORDER BY PERIODO, NRO_TRANSACCION, TIPO_TRANSACCION");
                }
                else  // solo deudas
                {
                    if (cate_deuda_desde == cate_deuda_hasta)
                    {
                        strSql.AppendLine(@"A.categoria_deuda = @categoria_desde AND");
                    }
                    else
                    {
                        strSql.AppendLine(@"A.categoria_deuda between @categoria_desde and @categoria_hasta AND");
                    }
                    strSql.AppendLine(@"
                        ((A.tipo_transaccion=1 AND A.pagado=0) OR
                        (A.tipo_transaccion <> 1 AND NOT EXISTS 
                        (SELECT * FROM CTASCTES_INMUEBLES B WHERE B.tipo_transaccion = 1 AND 
                        B.nro_transaccion = A.nro_transaccion AND pagado = 1)))
                        ORDER BY PERIODO, NRO_TRANSACCION, TIPO_TRANSACCION");

                }
                List<Ctasctes_inmuebles> lst = new List<Ctasctes_inmuebles>();
                using (SqlConnection con = GetConnection())
                {
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = strSql.ToString();
                    cmd.Parameters.AddWithValue("@cir", cir);
                    cmd.Parameters.AddWithValue("@sec", sec);
                    cmd.Parameters.AddWithValue("@man", man);
                    cmd.Parameters.AddWithValue("@par", par);
                    cmd.Parameters.AddWithValue("@p_h", p_h);
                    cmd.Parameters.AddWithValue("@categoria_desde", cate_deuda_desde);
                    cmd.Parameters.AddWithValue("@categoria_hasta", cate_deuda_hasta);
                    cmd.Connection.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    Ctasctes_inmuebles? obj;
                    if (dr.HasRows)
                    {
                        int movimiento = dr.GetOrdinal("movimiento");
                        int periodo = dr.GetOrdinal("periodo");
                        int tipo_transaccion = dr.GetOrdinal("tipo_transaccion");
                        int nro_transaccion = dr.GetOrdinal("nro_transaccion");
                        int fecha_transaccion = dr.GetOrdinal("fecha_transaccion");
                        int monto_original = dr.GetOrdinal("monto_original");
                        int debe = dr.GetOrdinal("debe");
                        int haber = dr.GetOrdinal("haber");
                        int nro_plan = dr.GetOrdinal("nro_plan");
                        int nro_procuracion = dr.GetOrdinal("nro_procuracion");
                        int categoria = dr.GetOrdinal("categoria");
                        int pagado = dr.GetOrdinal("pagado");
                        int nro_cedulon = dr.GetOrdinal("nro_cedulon");
                        while (dr.Read())
                        {
                            obj = new();
                            if (!dr.IsDBNull(movimiento)) { obj.des_movimiento = dr.GetString(movimiento); }
                            if (!dr.IsDBNull(periodo)) { obj.periodo = dr.GetString(periodo); }
                            if (!dr.IsDBNull(tipo_transaccion)) { obj.tipo_transaccion = dr.GetInt32(tipo_transaccion); }
                            if (!dr.IsDBNull(nro_transaccion)) { obj.nro_transaccion = dr.GetInt32(nro_transaccion); }
                            if (!dr.IsDBNull(fecha_transaccion)) { obj.fecha_transaccion = Convert.ToDateTime(dr.GetDateTime(fecha_transaccion), culturaFecArgentina); }
                            if (!dr.IsDBNull(monto_original)) { obj.monto_original = dr.GetDecimal(monto_original); }
                            if (!dr.IsDBNull(debe)) { obj.debe = dr.GetDecimal(debe); }
                            if (!dr.IsDBNull(haber)) { obj.haber = dr.GetDecimal(haber); }
                            if (!dr.IsDBNull(nro_plan)) { obj.nro_plan = dr.GetInt32(nro_plan); }
                            if (!dr.IsDBNull(nro_procuracion)) { obj.nro_procuracion = dr.GetInt32(nro_procuracion); }
                            if (!dr.IsDBNull(categoria)) { obj.des_categoria = dr.GetString(categoria); }
                            if (!dr.IsDBNull(pagado)) { obj.pagado = dr.GetBoolean(pagado); }
                            if (!dr.IsDBNull(nro_cedulon)) { obj.nro_cedulon = dr.GetInt32(nro_cedulon); }
                            lst.Add(obj);
                        }
                    }

                    for (int i = 0; i < lst.Count; i++)
                    {
                        if (i == 0)
                            lst[i].sub_total = -lst[i].debe + lst[i].haber;
                        else
                            lst[i].sub_total = lst[i - 1].sub_total - lst[i].debe + lst[i].haber;
                    }
                    return lst;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static int insert(Ctasctes_inmuebles obj)
        {
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.AppendLine("INSERT INTO Ctasctes_inmuebles(");
                sql.AppendLine("tipo_transaccion");
                sql.AppendLine(", nro_transaccion");
                sql.AppendLine(", circunscripcion");
                sql.AppendLine(", seccion");
                sql.AppendLine(", manzana");
                sql.AppendLine(", parcela");
                sql.AppendLine(", p_h");
                sql.AppendLine(", fecha_transaccion");
                sql.AppendLine(", periodo");
                sql.AppendLine(", cedulon_impreso");
                sql.AppendLine(", nro_pago_parcial");
                sql.AppendLine(", monto_original");
                sql.AppendLine(", nro_plan");
                sql.AppendLine(", pagado");
                sql.AppendLine(", debe");
                sql.AppendLine(", haber");
                sql.AppendLine(", deuda_activa");
                sql.AppendLine(", pago_parcial");
                sql.AppendLine(", categoria_deuda");
                sql.AppendLine(", nro_procuracion");
                sql.AppendLine(", vencimiento");
                sql.AppendLine(", nro_cedulon");
                sql.AppendLine(", monto_pagado");
                sql.AppendLine(", recargo");
                sql.AppendLine(", honorarios");
                sql.AppendLine(", iva_hons");
                sql.AppendLine(", tipo_deuda");
                sql.AppendLine(", decreto");
                sql.AppendLine(", observaciones");
                sql.AppendLine(", nro_cedulon_paypertic");
                sql.AppendLine(")");
                sql.AppendLine("VALUES");
                sql.AppendLine("(");
                sql.AppendLine("@tipo_transaccion");
                sql.AppendLine(", @nro_transaccion");
                sql.AppendLine(", @circunscripcion");
                sql.AppendLine(", @seccion");
                sql.AppendLine(", @manzana");
                sql.AppendLine(", @parcela");
                sql.AppendLine(", @p_h");
                sql.AppendLine(", @fecha_transaccion");
                sql.AppendLine(", @periodo");
                sql.AppendLine(", @cedulon_impreso");
                sql.AppendLine(", @nro_pago_parcial");
                sql.AppendLine(", @monto_original");
                sql.AppendLine(", @nro_plan");
                sql.AppendLine(", @pagado");
                sql.AppendLine(", @debe");
                sql.AppendLine(", @haber");
                sql.AppendLine(", @deuda_activa");
                sql.AppendLine(", @pago_parcial");
                sql.AppendLine(", @categoria_deuda");
                sql.AppendLine(", @nro_procuracion");
                sql.AppendLine(", @vencimiento");
                sql.AppendLine(", @nro_cedulon");
                sql.AppendLine(", @monto_pagado");
                sql.AppendLine(", @recargo");
                sql.AppendLine(", @honorarios");
                sql.AppendLine(", @iva_hons");
                sql.AppendLine(", @tipo_deuda");
                sql.AppendLine(", @decreto");
                sql.AppendLine(", @observaciones");
                sql.AppendLine(", @nro_cedulon_paypertic");
                sql.AppendLine(")");
                using (SqlConnection con = GetConnection())
                {
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = sql.ToString();
                    cmd.Parameters.AddWithValue("@tipo_transaccion", obj.tipo_transaccion);
                    cmd.Parameters.AddWithValue("@nro_transaccion", obj.nro_transaccion);
                    cmd.Parameters.AddWithValue("@circunscripcion", obj.circunscripcion);
                    cmd.Parameters.AddWithValue("@seccion", obj.seccion);
                    cmd.Parameters.AddWithValue("@manzana", obj.manzana);
                    cmd.Parameters.AddWithValue("@parcela", obj.parcela);
                    cmd.Parameters.AddWithValue("@p_h", obj.p_h);
                    cmd.Parameters.AddWithValue("@fecha_transaccion", obj.fecha_transaccion);
                    cmd.Parameters.AddWithValue("@periodo", obj.periodo);
                    cmd.Parameters.AddWithValue("@cedulon_impreso", obj.cedulon_impreso);
                    cmd.Parameters.AddWithValue("@nro_pago_parcial", obj.nro_pago_parcial);
                    cmd.Parameters.AddWithValue("@monto_original", obj.monto_original);
                    cmd.Parameters.AddWithValue("@nro_plan", obj.nro_plan);
                    cmd.Parameters.AddWithValue("@pagado", obj.pagado);
                    cmd.Parameters.AddWithValue("@debe", obj.debe);
                    cmd.Parameters.AddWithValue("@haber", obj.haber);
                    cmd.Parameters.AddWithValue("@deuda_activa", obj.deuda_activa);
                    cmd.Parameters.AddWithValue("@pago_parcial", obj.pago_parcial);
                    cmd.Parameters.AddWithValue("@categoria_deuda", obj.categoria_deuda);
                    cmd.Parameters.AddWithValue("@nro_procuracion", obj.nro_procuracion);
                    cmd.Parameters.AddWithValue("@vencimiento", obj.vencimiento);
                    cmd.Parameters.AddWithValue("@nro_cedulon", obj.nro_cedulon);
                    cmd.Parameters.AddWithValue("@monto_pagado", obj.monto_pagado);
                    cmd.Parameters.AddWithValue("@recargo", obj.recargo);
                    cmd.Parameters.AddWithValue("@honorarios", obj.honorarios);
                    cmd.Parameters.AddWithValue("@iva_hons", obj.iva_hons);
                    cmd.Parameters.AddWithValue("@tipo_deuda", obj.tipo_deuda);
                    cmd.Parameters.AddWithValue("@decreto", obj.decreto);
                    cmd.Parameters.AddWithValue("@observaciones", obj.observaciones);
                    cmd.Parameters.AddWithValue("@nro_cedulon_paypertic", obj.nro_cedulon_paypertic);
                    cmd.Connection.Open();
                    return cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void update(Ctasctes_inmuebles obj)
        {
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.AppendLine("UPDATE  Ctasctes_inmuebles SET");
                sql.AppendLine("circunscripcion=@circunscripcion");
                sql.AppendLine(", seccion=@seccion");
                sql.AppendLine(", manzana=@manzana");
                sql.AppendLine(", parcela=@parcela");
                sql.AppendLine(", p_h=@p_h");
                sql.AppendLine(", fecha_transaccion=@fecha_transaccion");
                sql.AppendLine(", periodo=@periodo");
                sql.AppendLine(", cedulon_impreso=@cedulon_impreso");
                sql.AppendLine(", monto_original=@monto_original");
                sql.AppendLine(", nro_plan=@nro_plan");
                sql.AppendLine(", pagado=@pagado");
                sql.AppendLine(", debe=@debe");
                sql.AppendLine(", haber=@haber");
                sql.AppendLine(", deuda_activa=@deuda_activa");
                sql.AppendLine(", pago_parcial=@pago_parcial");
                sql.AppendLine(", categoria_deuda=@categoria_deuda");
                sql.AppendLine(", nro_procuracion=@nro_procuracion");
                sql.AppendLine(", vencimiento=@vencimiento");
                sql.AppendLine(", nro_cedulon=@nro_cedulon");
                sql.AppendLine(", monto_pagado=@monto_pagado");
                sql.AppendLine(", recargo=@recargo");
                sql.AppendLine(", honorarios=@honorarios");
                sql.AppendLine(", iva_hons=@iva_hons");
                sql.AppendLine(", tipo_deuda=@tipo_deuda");
                sql.AppendLine(", decreto=@decreto");
                sql.AppendLine(", observaciones=@observaciones");
                sql.AppendLine(", nro_cedulon_paypertic=@nro_cedulon_paypertic");
                sql.AppendLine("WHERE");
                sql.AppendLine("tipo_transaccion=@tipo_transaccion");
                sql.AppendLine("AND nro_transaccion=@nro_transaccion");
                sql.AppendLine("AND nro_pago_parcial=@nro_pago_parcial");
                using (SqlConnection con = GetConnection())
                {
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = sql.ToString();
                    cmd.Parameters.AddWithValue("@tipo_transaccion", obj.tipo_transaccion);
                    cmd.Parameters.AddWithValue("@nro_transaccion", obj.nro_transaccion);
                    cmd.Parameters.AddWithValue("@circunscripcion", obj.circunscripcion);
                    cmd.Parameters.AddWithValue("@seccion", obj.seccion);
                    cmd.Parameters.AddWithValue("@manzana", obj.manzana);
                    cmd.Parameters.AddWithValue("@parcela", obj.parcela);
                    cmd.Parameters.AddWithValue("@p_h", obj.p_h);
                    cmd.Parameters.AddWithValue("@fecha_transaccion", obj.fecha_transaccion);
                    cmd.Parameters.AddWithValue("@periodo", obj.periodo);
                    cmd.Parameters.AddWithValue("@cedulon_impreso", obj.cedulon_impreso);
                    cmd.Parameters.AddWithValue("@nro_pago_parcial", obj.nro_pago_parcial);
                    cmd.Parameters.AddWithValue("@monto_original", obj.monto_original);
                    cmd.Parameters.AddWithValue("@nro_plan", obj.nro_plan);
                    cmd.Parameters.AddWithValue("@pagado", obj.pagado);
                    cmd.Parameters.AddWithValue("@debe", obj.debe);
                    cmd.Parameters.AddWithValue("@haber", obj.haber);
                    cmd.Parameters.AddWithValue("@deuda_activa", obj.deuda_activa);
                    cmd.Parameters.AddWithValue("@pago_parcial", obj.pago_parcial);
                    cmd.Parameters.AddWithValue("@categoria_deuda", obj.categoria_deuda);
                    cmd.Parameters.AddWithValue("@nro_procuracion", obj.nro_procuracion);
                    cmd.Parameters.AddWithValue("@vencimiento", obj.vencimiento);
                    cmd.Parameters.AddWithValue("@nro_cedulon", obj.nro_cedulon);
                    cmd.Parameters.AddWithValue("@monto_pagado", obj.monto_pagado);
                    cmd.Parameters.AddWithValue("@recargo", obj.recargo);
                    cmd.Parameters.AddWithValue("@honorarios", obj.honorarios);
                    cmd.Parameters.AddWithValue("@iva_hons", obj.iva_hons);
                    cmd.Parameters.AddWithValue("@tipo_deuda", obj.tipo_deuda);
                    cmd.Parameters.AddWithValue("@decreto", obj.decreto);
                    cmd.Parameters.AddWithValue("@observaciones", obj.observaciones);
                    cmd.Parameters.AddWithValue("@nro_cedulon_paypertic", obj.nro_cedulon_paypertic);
                    cmd.Connection.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void delete(Ctasctes_inmuebles obj)
        {
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.AppendLine("DELETE  Ctasctes_inmuebles ");
                sql.AppendLine("WHERE");
                sql.AppendLine("tipo_transaccion=@tipo_transaccion");
                sql.AppendLine("AND nro_transaccion=@nro_transaccion");
                sql.AppendLine("AND nro_pago_parcial=@nro_pago_parcial");
                using (SqlConnection con = GetConnection())
                {
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = sql.ToString();
                    cmd.Parameters.AddWithValue("@tipo_transaccion", obj.tipo_transaccion);
                    cmd.Parameters.AddWithValue("@nro_transaccion", obj.nro_transaccion);
                    cmd.Parameters.AddWithValue("@nro_pago_parcial", obj.nro_pago_parcial);
                    cmd.Connection.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static string Tipos_pago(int nro_cedulon)
        {
            try
            {
                string strSQL = @"
                                SELECT c.nro_movimiento, Tipo_pago=t.Descripcion,forma_pago=e.descripcion, 
                                CASE 
                                   WHEN c.efectivo>0 THEN 'EFECTIVO'
                                   ELSE   ''
                                   END AS EFECTIVO,
                                CASE   
                                   WHEN C.debitos>0 THEN 'DEBITO'
                                   ELSE   ''
                                   END AS DEBITO,
                                CASE   
                                   WHEN C.creditos>0 THEN 'CREDITO'
                                   ELSE   ''
                                   END AS CREDITO,
                                CASE   
                                   WHEN C.cheques>0 THEN 'CHEQUE'
                                   ELSE   ''
                                   END AS CHEQUE,
                                CASE   
                                   WHEN C.documentos>0 THEN 'DOCUMENTO'
                                   ELSE   ''
                                   END AS DOCUMENTOS,   
                                CASE   
                                   WHEN C.canje>0 THEN 'CANJE'
                                   ELSE   ''
                                   END AS CANJE,
   
                                CASE   
                                   WHEN C.bonos>0 THEN 'BONOS'
                                   ELSE   ''
                                   END AS BONOS ,     
                                CASE   
                                   WHEN C.acreditacion_bcos>0 THEN 'ACRED. BANCOS'
                                   ELSE   ''
                                   END AS BANCOS      
     
                                FROM ENTIDAD_RECAUDADORA e 
                                LEFT JOIN MOVIM_CAJA_V2 c ON e.Id_entidad=c.cod_forma_pago
                                LEFT JOIN COMPR_X_MOVIM_CAJA_V2 d ON d.nro_movimiento = c.nro_movimiento
                                LEFT JOIN TIPOS_INGRESO_PAGO t ON t.id_tipo_ingreso_pago=e.id_tipo_ingreso_pago
                                WHERE d.nro_cedulon=@nro_cedulon";
                StringBuilder strRetorno = new StringBuilder();
                List<Tipo_pago> lst = new List<Tipo_pago>();
                using (SqlConnection con = GetConnection())
                {
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = strSQL.ToString();
                    cmd.Parameters.AddWithValue("@nro_cedulon", nro_cedulon);
                    cmd.Connection.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    Tipo_pago? obj;
                    obj = new();
                    if (dr.HasRows)
                    {
                        int tipo_pago = dr.GetOrdinal("tipo_pago");
                        int efectivo = dr.GetOrdinal("efectivo");
                        int debito = dr.GetOrdinal("debito");
                        int credito = dr.GetOrdinal("credito");
                        int cheque = dr.GetOrdinal("cheque");
                        int documentos = dr.GetOrdinal("documentos");
                        int canje = dr.GetOrdinal("canje");
                        int bonos = dr.GetOrdinal("bonos");
                        int bancos = dr.GetOrdinal("bancos");
                        while (dr.Read())
                        {
                            //obj = new();
                            if (!dr.IsDBNull(tipo_pago)) { obj.tipo_pago = dr.GetString(tipo_pago); }
                            if (!dr.IsDBNull(efectivo)) { obj.efectivo = dr.GetString(efectivo); }
                            if (!dr.IsDBNull(debito)) { obj.debito = dr.GetString(debito); }
                            if (!dr.IsDBNull(credito)) { obj.credito = dr.GetString(credito); }
                            if (!dr.IsDBNull(cheque)) { obj.cheque = dr.GetString(cheque); }
                            if (!dr.IsDBNull(documentos)) { obj.documentos = dr.GetString(documentos); }
                            if (!dr.IsDBNull(canje)) { obj.canje = dr.GetString(canje); }
                            if (!dr.IsDBNull(bonos)) { obj.bonos = dr.GetString(bonos); }
                            if (!dr.IsDBNull(bancos)) { obj.bancos = dr.GetString(bancos); }
                            lst.Add(obj);
                        }
                        if (lst.Count > 0)
                            obj = lst[0];
                        strRetorno.AppendLine("TIPO PAGO: " + obj.tipo_pago);
                        strRetorno.AppendLine("FORMA PAGO: " + obj.forma_pago);
                        strRetorno.AppendLine(obj.efectivo + '-' + obj.credito + '-' + obj.debito + '-' + obj.bancos + '-' +
                            obj.cheque + '-' + obj.documentos + '-' + obj.canje + '-' + obj.bonos);
                    }
                    return strRetorno.ToString();


                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        public static List<Combo> ListarCategoriasTasa()
        {
            try
            {
                List<Combo> lst = new List<Combo>();
                using (SqlConnection con = GetConnection())
                {
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "SELECT * FROM CATE_DEUDA_INMUEBLE";
                    cmd.Connection.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    Combo? obj;
                    obj = new Combo();
                    obj.text = "TODAS LAS DEUDAS";
                    obj.value = "0";
                    lst.Add(obj);
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            obj = new();
                            if (!dr.IsDBNull(0)) { obj.value = Convert.ToString(dr.GetInt32(0)); }
                            if (!dr.IsDBNull(1)) { obj.text = dr.GetString(1); }
                            lst.Add(obj);
                        }
                    }
                    return lst;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}


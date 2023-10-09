using System.Data.SqlClient;
using System.Data;

namespace Tasa_back.Entities
{
    public class CtaCteInm : DALBase
    {
        public string movimiento { get; set; }
        public string periodo { get; set; }
        public int tipo_transaccion { get; set; }
        public int NRO_TRANSACCION { get; set; }
        public DateTime fecha_transaccion { get; set; }
        public decimal monto_original { get; set; }
        public decimal debe { get; set; }
        public decimal haber { get; set; }
        public int nro_plan { get; set; }
        public int nro_procuracion { get; set; }
        public string des_categoria { get; set; }
        public bool pagado { get; set; }
        public decimal recargo { get; set; }
        public decimal saldo { get; set; }
        public int nro_cedulon { get; set; }


        public CtaCteInm()
        { 
            movimiento = string.Empty;
            periodo = string.Empty;
            tipo_transaccion = int.MinValue;
            monto_original= decimal.MinValue;
            recargo = decimal.MinValue; 
            debe = decimal.MinValue;
            haber = decimal.MinValue;
            saldo = decimal.MinValue;
            nro_plan = int.MinValue;
            nro_procuracion = int.MinValue; 
            nro_cedulon = int.MinValue; 
            NRO_TRANSACCION = int.MinValue;
            des_categoria = string.Empty;

        }
        public static List<CtaCteInm> read(int cir, int sec, int mza, int par, int p_h)
        {
            try
            {
                List<CtaCteInm> lst = new List<CtaCteInm>();
                CtaCteInm obj;
                decimal acumulado = 0;
                using (SqlConnection con = GetConnection())
                {
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandText = "sp_proc_get_ctacte_inm";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@cir", cir);
                    cmd.Parameters.AddWithValue("@sec", sec);
                    cmd.Parameters.AddWithValue("@mza", mza);
                    cmd.Parameters.AddWithValue("@par", par);
                    cmd.Parameters.AddWithValue("@p_h", p_h);

                    cmd.Connection.Open();

                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.HasRows)
                    {
                        int movimiento = dr.GetOrdinal("movimiento");
                        int periodo = dr.GetOrdinal("periodo");
                        int monto_original = dr.GetOrdinal("monto_original");
                        int debe = dr.GetOrdinal("debe");
                        int recargo = dr.GetOrdinal("recargo");
                        int nro_plan = dr.GetOrdinal("nro_plan");
                        int nro_procuracion = dr.GetOrdinal("nro_procuracion");
                        int haber = dr.GetOrdinal("haber");
                        int NRO_TRANSACCION = dr.GetOrdinal("NRO_TRANSACCION");
                        int nro_cedulon = dr.GetOrdinal("nro_cedulon");
                        while (dr.Read())
                        {
                            obj = new CtaCteInm();
                            if (!dr.IsDBNull(movimiento)) { obj.movimiento = dr.GetString(movimiento); }
                            if (!dr.IsDBNull(periodo)) { obj.periodo = dr.GetString(periodo); }
                            if (!dr.IsDBNull(monto_original)) { obj.monto_original = dr.GetDecimal(monto_original); }
                            if (!dr.IsDBNull(recargo)) { obj.recargo = dr.GetDecimal(recargo); }
                            if (!dr.IsDBNull(debe)) { obj.debe = dr.GetDecimal(debe); }
                            if (!dr.IsDBNull(recargo)) { obj.recargo = dr.GetDecimal(recargo); }
                            if (!dr.IsDBNull(nro_plan)) { obj.nro_plan = dr.GetInt32(nro_plan); }
                            if (!dr.IsDBNull(nro_procuracion)) { obj.nro_procuracion = dr.GetInt32(nro_procuracion); }
                            if (!dr.IsDBNull(haber)) { obj.haber = dr.GetDecimal(haber); }
                            if (!dr.IsDBNull(NRO_TRANSACCION)) { obj.NRO_TRANSACCION = dr.GetInt32(NRO_TRANSACCION); }
                            if (!dr.IsDBNull(nro_cedulon)) { obj.nro_cedulon = dr.GetInt32(nro_cedulon); }

                            acumulado = acumulado + obj.debe - obj.haber;
                            obj.saldo = acumulado;
                            lst.Add(obj);
                        }
                    }
                }
                return lst;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static List<CtaCteInm> getDetDeudaNoProc(int cir, int sec, int mza, int par, int p_h)
        {
            try
            {
                List<CtaCteInm> lst = new List<CtaCteInm>();
                CtaCteInm obj;
                using (SqlConnection con = GetConnection())
                {
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandText = "sp_proc_get_deuda_no_proc_inm";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@cir", cir);
                    cmd.Parameters.AddWithValue("@sec", sec);
                    cmd.Parameters.AddWithValue("@mza", mza);
                    cmd.Parameters.AddWithValue("@par", par);
                    cmd.Parameters.AddWithValue("@p_h", p_h);

                    cmd.Connection.Open();

                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.HasRows)
                    {
                        int movimiento = dr.GetOrdinal("movimiento");
                        int periodo = dr.GetOrdinal("periodo");
                        int monto_original = dr.GetOrdinal("monto_original");
                        int debe = dr.GetOrdinal("debe");
                        int recargo = dr.GetOrdinal("recargo");
                        while (dr.Read())
                        {
                            obj = new CtaCteInm();
                            if (!dr.IsDBNull(movimiento)) { obj.movimiento = dr.GetString(movimiento); }
                            if (!dr.IsDBNull(periodo)) { obj.periodo = dr.GetString(periodo); }
                            if (!dr.IsDBNull(monto_original)) { obj.monto_original = dr.GetDecimal(monto_original); }
                            if (!dr.IsDBNull(recargo)) { obj.recargo = dr.GetDecimal(recargo); }
                            if (!dr.IsDBNull(debe)) { obj.debe = dr.GetDecimal(debe); }
                            if (!dr.IsDBNull(recargo)) { obj.recargo = dr.GetDecimal(recargo); }
                            lst.Add(obj);
                        }
                    }
                }
                return lst;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static List<CtaCteInm> getTotalDetDeudaNoProc(int cir, int sec, int mza, int par, int p_h)
        {
            try
            {
                List<CtaCteInm> lst = new List<CtaCteInm>();
                CtaCteInm obj;
                using (SqlConnection con = GetConnection())
                {
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandText = "sp_proc_total_deuda_no_proc_inm";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@cir", cir);
                    cmd.Parameters.AddWithValue("@sec", sec);
                    cmd.Parameters.AddWithValue("@mza", mza);
                    cmd.Parameters.AddWithValue("@par", par);
                    cmd.Parameters.AddWithValue("@p_h", p_h);

                    cmd.Connection.Open();

                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.HasRows)
                    {
                        int monto_original = dr.GetOrdinal("monto_original");
                        int debe = dr.GetOrdinal("debe");
                        int recargo = dr.GetOrdinal("recargo");
                        while (dr.Read())
                        {
                            obj = new CtaCteInm();
                            if (!dr.IsDBNull(monto_original)) { obj.monto_original = dr.GetDecimal(monto_original); }
                            if (!dr.IsDBNull(recargo)) { obj.recargo = dr.GetDecimal(recargo); }
                            if (!dr.IsDBNull(debe)) { obj.debe = dr.GetDecimal(debe); }
                            lst.Add(obj);
                        }
                    }
                }
                return lst;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static List<CtaCteInm> getTotalDetDeudaNoProcIndyC(int leg)
        {
            try
            {
                List<CtaCteInm> lst = new List<CtaCteInm>();
                CtaCteInm obj;
                using (SqlConnection con = GetConnection())
                {
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandText = "sp_proc_total_deuda_no_proc_indyCom";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@leg", leg);

                    cmd.Connection.Open();

                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.HasRows)
                    {
                        int monto_original = dr.GetOrdinal("monto_original");
                        int debe = dr.GetOrdinal("debe");
                        int recargo = dr.GetOrdinal("recargo");
                        while (dr.Read())
                        {
                            obj = new CtaCteInm();
                            if (!dr.IsDBNull(monto_original)) { obj.monto_original = dr.GetDecimal(monto_original); }
                            if (!dr.IsDBNull(recargo)) { obj.recargo = dr.GetDecimal(recargo); }
                            if (!dr.IsDBNull(debe)) { obj.debe = dr.GetDecimal(debe); }
                            lst.Add(obj);
                        }
                    }
                }
                return lst;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema.Models
{
    public class Persona
    {
        public int ID { get; set; }
        public string sexo { get; set; }
        public int age { get; set; }
        public int antiguedad { get; set; }
        public string segmento { get; set; }
        public int renta { get; set; }
        public int ind_ahor_fin_ult1 { get; set; }   //Cuenta de ahorro
        public int ind_aval_fin_ult1 { get; set; }   //Garantias
        public int ind_cco_fin_ult1 { get; set; }    //Cuentas corrientes
        public int ind_cder_fin_ult1 { get; set; }   //Cuenta derivada
        public int ind_cno_fin_ult1 { get; set; }    //Cuenta de nómina
        public int ind_ctju_fin_ult1 { get; set; }   //Cuenta Junior
        public int ind_ctma_fin_ult1 { get; set; }   //Cuenta más particular
        public int ind_ctop_fin_ult1 { get; set; }   //Cuenta particular
        public int ind_ctpp_fin_ult1 { get; set; }   //particular cuenta plus
        public int ind_deco_fin_ult1 { get; set; }   //depositos a corto plazo
        public int ind_deme_fin_ult1 { get; set; }   //depositos a medio plazo
        public int ind_dela_fin_ult1 { get; set; }   //depositos a largo plazo
        public int ind_ecue_fin_ult1 { get; set; }   //cuenta electronica
        public int ind_fond_fin_ult1 { get; set; }   //fondos
        public int ind_hip_fin_ult1 { get; set; }    //hipoteca
        public int ind_plan_fin_ult1 { get; set; }   //Pensiones  
        public int ind_pres_fin_ult1 { get; set; }   //Prestamos
        public int ind_reca_fin_ult1 { get; set; }   //Impuestos
        public int ind_tjcr_fin_ult1 { get; set; }   //Tarjeta de credito
        public int ind_valo_fin_ult1 { get; set; }   //Valores
        public int ind_viv_fin_ult1 { get; set; }    //Cuenta de inicio (hogar)
        public int ind_nomina_ult1 { get; set; }     //Nomina
        public int ind_nom_pens_ult1 { get; set; }   //Pensiones
        public int ind_recibo_ult1 { get; set; }     //debito directo

    }
}

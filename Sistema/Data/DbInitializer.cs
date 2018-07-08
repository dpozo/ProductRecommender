using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sistema.Models;

namespace Sistema.Data
{
    public class DbInitializer
    {
        public static void Initialize (SistemaContext context)
        {
            context.Database.EnsureCreated();

            if (context.Persona.Any())
            {
                return;
            }
            var personas = new Persona[]
            {
                new Persona{sexo="H", age=23, antiguedad= 36, segmento = "03", renta= 30000, ind_ahor_fin_ult1=0, ind_aval_fin_ult1=0, ind_cco_fin_ult1=0, ind_cder_fin_ult1=0, ind_cno_fin_ult1=0, ind_ctju_fin_ult1=0, ind_ctma_fin_ult1=0, ind_ctop_fin_ult1=0, ind_ctpp_fin_ult1=0, ind_deco_fin_ult1=0, ind_dela_fin_ult1=0, ind_deme_fin_ult1=0, ind_ecue_fin_ult1=0, ind_fond_fin_ult1=0, ind_hip_fin_ult1=0, ind_nomina_ult1=1, ind_nom_pens_ult1=0, ind_plan_fin_ult1=0, ind_pres_fin_ult1=0, ind_reca_fin_ult1=0, ind_recibo_ult1=0, ind_tjcr_fin_ult1=0, ind_valo_fin_ult1=0, ind_viv_fin_ult1=0 },
                new Persona{sexo="V", age=32, antiguedad= 36, segmento = "02", renta= 20000, ind_ahor_fin_ult1=0, ind_aval_fin_ult1=0, ind_cco_fin_ult1=0, ind_cder_fin_ult1=0, ind_cno_fin_ult1=0, ind_ctju_fin_ult1=0, ind_ctma_fin_ult1=0, ind_ctop_fin_ult1=0, ind_ctpp_fin_ult1=0, ind_deco_fin_ult1=0, ind_dela_fin_ult1=0, ind_deme_fin_ult1=0, ind_ecue_fin_ult1=0, ind_fond_fin_ult1=0, ind_hip_fin_ult1=1, ind_nomina_ult1=1, ind_nom_pens_ult1=0, ind_plan_fin_ult1=0, ind_pres_fin_ult1=0, ind_reca_fin_ult1=0, ind_recibo_ult1=0, ind_tjcr_fin_ult1=0, ind_valo_fin_ult1=0, ind_viv_fin_ult1=0 }
            };

            foreach (Persona p in personas)
            {
                context.Persona.Add(p);
            }
            context.SaveChanges();
        }
    }
}

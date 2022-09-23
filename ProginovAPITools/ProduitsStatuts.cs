using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProginovAPITools
{
    public enum StatutsPROGINOV
    {
        RAS = 0,
        Normal = 1,
        A_supprimer = 9,
        Interdit_vente = 2,
        Interdit_vente_et_achat = 8,
        Default = -1
    }
    public static class ProduitsStatuts
    {
        public static List<int> GetEnumValues()
        {
            List<int> values = new List<int>();
            var enumList = Enum.GetValues(typeof(StatutsPROGINOV));
            foreach (StatutsPROGINOV statut in enumList)
            {
                values.Add((int)statut);
            }
            return values;
        }
        public static StatutsPROGINOV ConvertStatus(int statut)
        {

            if (GetEnumValues().Contains(statut))
                return ((StatutsPROGINOV)statut);
            else
                return StatutsPROGINOV.Default;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valida
{
    public static class ValdacaoCNPJ
    {
        public static bool Cnpj(string cnpj)
        {
            cnpj = cnpj.Trim();
            cnpj = cnpj.Replace(".", "").Replace("-", "").Replace("/", "");

            try
            {
                if (cnpj.Length != 14)
                    return false;
            }
            catch
            {

                return true;
            }
            return true;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WSOpusDigitalizacao.Util
{
    public static class Util
    {

        /// <summary>
        /// Método utilitário que formata a data no formato (dd/mm/yyyy)
        /// </summary>
        /// <param name="dt">data como string</param>
        /// <returns>String</returns>
        public static string dateFormatPTBR(string dt)
        {

            string[] data = dt.Split('T')[0].Split('-');

            return new DateTime(int.Parse(data[0]), int.Parse(data[1]), int.Parse(data[2])).ToString("dd/MM/yyyy");

        }

    }
}
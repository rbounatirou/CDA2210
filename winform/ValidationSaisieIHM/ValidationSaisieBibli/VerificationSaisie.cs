using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ValidationSaisieBibli
{
    public static class VerificationSaisie
    {

       

        /// <summary>
        /// Check if string is only composed of alphabetics characters and '-'
        /// </summary>
        /// <param name="str"></param>
        /// <returns>true if match, false if not</returns>
        public static bool MatchForAlphabetics(string str) => matchFor(str, "^\\p{L}{2,}(?:[-]\\p{L}{2,}){0,1}$");


        public static bool MatchForcharactersLength(string str, uint nbMinChar, uint? nbMaxChar = null)
        {
            if (nbMinChar <= nbMaxChar || nbMaxChar == null)
            {
                return matchFor(str, "^.{" + nbMinChar + "," + (nbMaxChar != null ? nbMaxChar : "") + "}$");
            }
            return false;
        }

        /// <summary>
        /// Check if the string match for a 5 figure length integer number
        /// </summary>
        /// <returns></returns>
        public static bool MatchForPostalCode(string str) => matchFor(str, "^[0-9]{5}$");

        /// <summary>
        /// Check if the string match for a decimal value with '.' or ',' delimiter with a 2 figure length after dot
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static bool MatchForPrice(string str) => matchFor(str, "^[0-9]*(?:(?:[.]|[,]){1}[0-9]{1,2}){0,1}$");


        /// <summary>
        /// Check if the value is date
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static bool MatchForDate(string str) => DateTime.TryParse(str, out DateTime i);
        private static bool matchFor(string str, string regex)
        {
            Regex rg = new Regex(regex);
            return rg.IsMatch(str);
        }
    }
}

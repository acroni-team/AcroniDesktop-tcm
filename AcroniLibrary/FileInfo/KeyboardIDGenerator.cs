using System;

namespace AcroniLibrary.FileInfo
{
    public class KeyboardIDGenerator
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="KeyboardType">
        ///     Passa a primeira letra do teclado em inglês. 
        /// </param>
        /// <returns></returns>
        public static string GenerateID(char KeyboardType)
        {
            string utc = DateTime.UtcNow.ToString();
            utc = utc.Replace(":","").Replace("/","").Replace(" ", "").Trim();
            return $"{KeyboardType}{utc}";
        }
    }
}

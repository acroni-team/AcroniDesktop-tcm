using System;

namespace AcroniLibrary.FileInfo
{
    class KeyboardIDGenerator
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="KeyboardType">
        ///     Passa a primeira letra do teclado em inglês. 
        /// </param>
        /// <returns></returns>
        static string GenerateID(char KeyboardType)
        {
            return $"{KeyboardType}{DateTime.UtcNow}";
        }
    }
}

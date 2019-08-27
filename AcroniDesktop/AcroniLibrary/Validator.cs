using System;
using System.Text.RegularExpressions;

namespace AcroniLibrary
{
    public class Validator
    {
        public static bool IsCPF(String CPF)
        {
            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            string tempCPF;
            string digito;
            int soma;
            int resto;
            CPF = CPF.Trim();
            CPF = CPF.Replace(".", "").Replace("-", "");
            if (CPF.Length != 11)
                return false;
            tempCPF = CPF.Substring(0, 9);
            soma = 0;

            for (int i = 0; i < 9; i++)
                soma += int.Parse(tempCPF[i].ToString()) * multiplicador1[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = resto.ToString();
            tempCPF = tempCPF + digito;
            soma = 0;
            for (int i = 0; i < 10; i++)
                soma += int.Parse(tempCPF[i].ToString()) * multiplicador2[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = digito + resto.ToString();
            return CPF.EndsWith(digito);
        }

        public static PasswordType CheckPasswordLevel(string password)
        {
            int level;
            if (password == null || password.Length < 7)
                return PasswordType.VERY_WEAK;

            level = _size(password) + _hasNonCapitalChar(password) + _hasCapitalChars(password) + _hasDigits(password) + _hasSimbols(password) - _hasRepetition(password);

            if (level < 30)
                return PasswordType.VERY_WEAK;
            else if (level < 45)
                return PasswordType.WEAK;
            else if (level < 60)
                return PasswordType.OK;
            else
                return PasswordType.STRONG;
        }

        #region Métodos de Validação de Senha
        private static int _size(string senha)
        {
            return Math.Min(10, senha.Length) * 6;
        }

        private static int _hasNonCapitalChar(string senha)
        {
            int rawplacar = senha.Length - Regex.Replace(senha, "[a-z]", "").Length;
            return Math.Min(2, rawplacar) * 5;
        }

        private static int _hasCapitalChars(string senha)
        {
            int rawplacar = senha.Length - Regex.Replace(senha, "[A-Z]", "").Length;
            return Math.Min(2, rawplacar) * 5;
        }

        private static int _hasDigits(string senha)
        {
            int rawplacar = senha.Length - Regex.Replace(senha, "[0-9]", "").Length;
            return Math.Min(2, rawplacar) * 5;
        }

        private static int _hasSimbols(string senha)
        {
            int rawplacar = Regex.Replace(senha, "[a-zA-Z0-9]", "").Length;
            return Math.Min(2, rawplacar) * 5;
        }

        private static int _hasRepetition(string senha)
        {
            System.Text.RegularExpressions.Regex regex = new System.Text.RegularExpressions.Regex(@"(\w)*.*\1");
            bool repete = regex.IsMatch(senha);
            if (repete)
            {
                return 30;
            }
            else
            {
                return 0;
            }
        }
        #endregion
    }
    public enum PasswordType
    {
        VERY_WEAK,
        WEAK,
        OK,
        STRONG,
    }
}

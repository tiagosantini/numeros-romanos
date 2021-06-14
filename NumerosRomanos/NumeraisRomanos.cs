using System;
using System.Collections.Generic;

namespace NumerosRomanos
{
    public class NumeraisRomanos
    {
        #region Dicionario de Numerais Romanos

        private readonly Dictionary<char, int> numeraisRomanos = new Dictionary<char, int>()
        {
            { 'I', 1 },
            { 'V', 5 },
            { 'X', 10 },
            { 'L', 50 },
            { 'C', 100 },
            { 'D', 500 },
            { 'M', 1000 },
            { 'Í', 1000 },
            { 'Ú' , 5000},
            { 'K', 10000 }
        };

        #endregion

        public string IndoArabicoParaRomano(int numeroIndoArabico)
        {
            string numeroRomano = "";

            if (numeroIndoArabico >= 1000)
            {
                int numeroMilhar = numeroIndoArabico / 1000;

                numeroRomano = ConverterMilharParaRomano(numeroRomano, numeroMilhar);

                numeroIndoArabico %= 1000;
            }

            if (numeroIndoArabico >= 100)
            {
                int numeroCentena = numeroIndoArabico / 100;

                numeroRomano = ConverterCentenaParaRomano(numeroRomano, numeroCentena);

                numeroIndoArabico %= 100;
            }

            if (numeroIndoArabico > 10)
            {
                int numeroDezena = numeroIndoArabico / 10;

                numeroRomano = ConverterDezenaParaRomano(numeroRomano, numeroDezena);
            }

            else
                numeroRomano = ConverterUnidadeParaRomano(numeroIndoArabico, numeroRomano);

            return numeroRomano;
        }

        public string RomanoParaInteiro(string romano)
        {
            int numero = 0;

            VerificarRepeticaoDeNumerais(romano);

            string[] arrMacron = { "Ī", "V̄", "X̄" };

            for (int i = 0; i < arrMacron.Length; i++)
            {
                if (romano.Contains(arrMacron[i]))
                {
                    romano = romano.Replace("Ī", "Í");
                    romano = romano.Replace("V̄", "Ú");
                    romano = romano.Replace("X̄", "K");
                }
            }

            for (int i = 0; i < romano.Length; i++)
            {
                if (i + 1 < romano.Length && NumeroEhMenorQueOProximo(romano, i))
                    numero -= numeraisRomanos[romano[i]];
                else
                    numero += numeraisRomanos[romano[i]];
            }

            return numero.ToString();
        }

        #region Métodos privados

        private static string ConverterUnidadeParaRomano(int numeroIndoArabico, string numeroRomano)
        {
            switch (numeroIndoArabico)
            {
                case 1: numeroRomano += "I"; break;
                case 2: numeroRomano += "II"; break;
                case 3: numeroRomano += "III"; break;
                case 4: numeroRomano += "IV"; break;
                case 5: numeroRomano += "V"; break;
                case 6: numeroRomano += "VI"; break;
                case 7: numeroRomano += "VII"; break;
                case 8: numeroRomano += "VIII"; break;
                case 9: numeroRomano += "IX"; break;
                case 10: numeroRomano += "X"; break;

            }
            return numeroRomano;
        }

        private static string ConverterDezenaParaRomano(string numeroRomano, int numeroDezena)
        {
            switch (numeroDezena)
            {
                case 1: numeroRomano += "XI"; break;
                case 2: numeroRomano += "XII"; break;
                case 3: numeroRomano += "XIII"; break;
                case 4: numeroRomano += "XIV"; break;
                case 5: numeroRomano += "XV"; break;
                case 6: numeroRomano += "XVI"; break;
                case 7: numeroRomano += "XVII"; break;
                case 8: numeroRomano += "XVIII"; break;
                case 9: numeroRomano += "XIX"; break;
            }
            return numeroRomano;
        }

        private static string ConverterCentenaParaRomano(string numeroRomano, int numeroCentena)
        {
            switch (numeroCentena)
            {
                case 1: numeroRomano += "C"; break;
                case 2: numeroRomano += "CC"; break;
                case 3: numeroRomano += "CCC"; break;
                case 4: numeroRomano += "CD"; break;
                case 5: numeroRomano += "D"; break;
                case 6: numeroRomano += "DC"; break;
                case 7: numeroRomano += "DCC"; break;
                case 8: numeroRomano += "DCCC"; break;
                case 9: numeroRomano += "CM"; break;
            }
            return numeroRomano;
        }

        private static string ConverterMilharParaRomano(string numeroRomano, int numeroMilhar)
        {
            switch (numeroMilhar)
            {
                case 1: numeroRomano += "M"; break;
                case 2: numeroRomano += "MM"; break;
                case 3: numeroRomano += "MMM"; break;
                case 4: numeroRomano += "ĪV̄"; break;
                case 5: numeroRomano += "V̄"; break;
                case 6: numeroRomano += "V̄Ī"; break;
                case 7: numeroRomano += "V̄ĪĪ"; break;
                case 8: numeroRomano += "V̄ĪĪĪ"; break;
                case 9: numeroRomano += "ĪX̄"; break;
            }
            return numeroRomano;
        }

        private bool NumeroEhMenorQueOProximo(string romano, int i)
        {
            return numeraisRomanos[romano[i]] < numeraisRomanos[romano[i + 1]];
        }

        private bool NaoEhValorExcluso(char letra)
        {
            return letra != 'V' && letra != 'L' && letra != 'D';
        }

        private void VerificarRepeticaoDeNumerais(string romano)
        {
            for (int i = 0; i < romano.Length - 1; i++)
            {
                if (NaoEhValorExcluso(romano[i]) && romano[i] == romano[i + 1] && romano[i] == romano[i + 2])
                    throw new ArgumentException("Apenas os valores V, L e D podem repetir mais de 3 vezes");
            }
        }

        #endregion

    }
}


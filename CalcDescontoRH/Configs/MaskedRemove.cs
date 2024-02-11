namespace Interface.Configs
{
    public static class MaskedRemove
    {
        public static double RemoveFormatacao(string texto)
        {
            if (decimal.TryParse(texto.Replace("R$", "").Trim(), System.Globalization.NumberStyles.Currency,System.Globalization.CultureInfo.GetCultureInfo("pt-BR"), out decimal valor))
            {
                return (double)valor;
            }
            else
            {
                return -1;
            }
        }
    }
}

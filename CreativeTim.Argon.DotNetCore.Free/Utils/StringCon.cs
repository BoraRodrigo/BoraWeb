using Microsoft.Extensions.Configuration;

namespace JuntoSeguros.Utils
{
    public static class StringCon
    {
        public static IConfiguration Configuration { get; }
        public static string ConString()
        {
            var ambiente = "P"; //PRODUCAO

            string ConString = "";
            if (ambiente == "P")
            {
                ConString = $"Server=localhost;Database=DEV_BORA_WEB;User Id=user_dev_bora_web; Password=Bb@222abcdegrb36";
            }
            else if (ambiente == "D")
            {
               
            }
            else if (ambiente == "H")
            {
               
            }
            return ConString;
        }
    }
}

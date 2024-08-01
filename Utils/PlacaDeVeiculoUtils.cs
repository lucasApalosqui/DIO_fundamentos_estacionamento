namespace DioFundamentosEstacionamento.Utils
{
    public static class PlacaDeVeiculoUtils
    {
        public static bool VerificarPlacaValida(string placa)
        {
          if(placa.Length != 7)
              return false;
           
          for(int i = 0; i < placa.Length; i++)
            {
               if(i <= 2 && int.TryParse(placa[i].ToString(), out int val) == true)
                    return false;

               if(i == 3 && int.TryParse(placa[i].ToString(), out val) == false)
                    return false;

               if(i == 4 && int.TryParse(placa[i].ToString(), out val) == true)
                    return false;

               if(i >= 5 && int.TryParse(placa[i].ToString(), out val) == false)
                    return false;
            }

          return true;
        }
    }
}

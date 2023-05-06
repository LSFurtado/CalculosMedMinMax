public class Calculos
{
    
    //cálculo de média
    public float Media(int n1, int n2, int n3) //tipo de acesso
    {
        float resultado = (n1 + n2 + n3) / 3; //tipo de saída

        return resultado;
    }

    //cálculo de Máxima
    public int Max(int n1, int n2, int n3) //tipo de acesso
    {

        int resultado; //tipo de saída

            if (n1 > n2) 
            {
                if (n1 > n3) 
                { 
                    resultado = n1;
                } 
                else 
                {
                    resultado = n3;
                }
            }
    
            else if (n2 > n3)
            {
                resultado = n2;
            }      
            else
            {
                resultado = n3;
            }
       
                return resultado;

    }

    //cálculo de Mínima
    public int Min(int n1, int n2, int n3) //tipo de acesso
    {

        int resultado; //tipo de saída


            if (n1 < n2) 
            {
                if (n1 < n3) 
                { 
                    resultado = n1;
                } 
                else 
                {
                    resultado = n3;
                }
            }
    
            else if (n2 < n3)
            {
                resultado = n2;
            }      
            else
            {
                resultado = n3;
            }
       
                return resultado;

    }

}






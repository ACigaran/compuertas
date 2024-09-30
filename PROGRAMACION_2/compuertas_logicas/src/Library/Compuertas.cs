namespace Library
{
    public class CompuertaAnd : Icompuerta
    {
        public string Nombre { get; set; }
        public List<int> Entradas { get; set; } = new List<int>();
        public int Salida { get; set; }

        public CompuertaAnd(string nombre)
        {
            this.Nombre = nombre;
        }

        public void AgregarEntrada(int valor)
        {
            Entradas.Add(valor); 
        }

        public int Calcular()
        {
            int prod = 1;
            foreach (var entrada in Entradas)
            {
                if (entrada == 0 || entrada == 1)
                {
                    prod *= entrada;
                }
            }
            return prod;
        }
    }
    
    /// <summary>
    /// ///////////////////
    /// </summary>
    
    public class CompuertaOr : Icompuerta
    {
        public string Nombre { get; set; }
        public List<int> Entradas { get; set; } = new List<int>();
        public int Salida { get; set; }

        public CompuertaOr(string nombre)
        {
            this.Nombre = nombre;
        }

        public void AgregarEntrada(int valor)
        {
            Entradas.Add(valor);
        }

        public int Calcular()
        {
            int suma = 0;
            foreach (var entrada in Entradas)
            {
                if (entrada == 1)
                {
                    suma = 1;
                    break; 
                }
            }
            return suma; 
        }
    }
    
    /// <summary>
    /// ////////
    /// </summary>
    
    public class CompuertaNot : Icompuerta
    {
        public string Nombre { get; set; }
        public int Entrada { get; set; } // Solo una entrada
        public int Salida { get; set; }

        public CompuertaNot(string nombre)
        {
            this.Nombre = nombre;
        }

        public void AgregarEntrada(int valor)
        {
            this.Entrada = valor; // Solo una entrada para NOT
        }

        public int Calcular()
        {
            return Entrada == 1 ? 0 : 1; // Invierte el valor de la entrada
        }
    }
}
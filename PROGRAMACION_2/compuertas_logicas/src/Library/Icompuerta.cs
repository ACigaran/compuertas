namespace Library
{
    public interface Icompuerta
    {
        string Nombre { get; set; }
        void AgregarEntrada(int valor);
        int Calcular();
    }
}
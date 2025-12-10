namespace ArvoreApi.Models
{
    public class Node
    {
        public int Valor { get; set; }
        public Node? Esquerda { get; set; }
        public Node? Direita { get; set; }
    }
}
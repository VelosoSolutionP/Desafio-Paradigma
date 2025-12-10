using ArvoreApi.Models;

namespace ArvoreApi.Services
{
    public class ArvoreService
    {
        public Node ConstruirArvore(int[] numeros)
        {
            if (numeros == null || numeros.Length == 0)
                throw new ArgumentException("O array não pode estar vazio.");

            int maxIndex = Array.IndexOf(numeros, numeros.Max());

            var raiz = new Node
            {
                Valor = numeros[maxIndex]
            };

            raiz.Esquerda = ConstruirGalhos(numeros[..maxIndex]);

            raiz.Direita = ConstruirGalhos(numeros[(maxIndex + 1)..]);

            return raiz;
        }

        private Node? ConstruirGalhos(int[] subArray)
        {
            if (subArray.Length == 0) return null;

            int maxIndex = Array.IndexOf(subArray, subArray.Max());

            var node = new Node
            {
                Valor = subArray[maxIndex]
            };

            node.Esquerda = ConstruirGalhos(subArray[..maxIndex]);
            node.Direita = ConstruirGalhos(subArray[(maxIndex + 1)..]);

            return node;
        }
    }
}

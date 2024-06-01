using System.Text;

namespace PassWordGenerate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int rdn = random.Next(2);
            int tamanhoSenha = (rdn == 0) ? 16 : 14;
            string caracteresBox = "ABCDEFGHIJKLNIOPQRSTUVWXYZ<>:?!@#$%*()_+^}{";
            StringBuilder senha = new StringBuilder();
            for (int cont = 0; cont < tamanhoSenha; cont++)
            {
                int indiceCaixa = random.Next(0, caracteresBox.Length -1);
                senha.Append(caracteresBox[indiceCaixa]);
            }
            Console.WriteLine(senha.ToString());
        }
    }
}

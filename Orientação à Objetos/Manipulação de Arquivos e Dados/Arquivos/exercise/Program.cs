using exercise.Entities;
using System.Globalization;

namespace exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o caminho completo do arquivo: ");
            string sourceFilePath = Console.ReadLine();

            try
            {
                // Lê todas as linhas do arquivo especificado pelo caminho fornecido.
                string[] lines = File.ReadAllLines(sourceFilePath);

                // Obtém o diretório do caminho do arquivo fornecido.
                string sourceFolderPath = Path.GetDirectoryName(sourceFilePath);

                // Define um novo diretório chamado 'out' dentro do diretório obtido anteriormente.
                string targetFolderPath = sourceFolderPath + @"\out";

                // Define o caminho completo para um novo arquivo chamado 'summary.csv' dentro do diretório 'out'.
                string targetFilePath = targetFolderPath + @"\summary.csv";

                // Cria o diretório 'out' se ele ainda não existir.
                Directory.CreateDirectory(targetFolderPath);

                // Utiliza um StreamWriter para adicionar texto ao arquivo 'summary.csv'.
                using (StreamWriter sw = File.AppendText(targetFilePath))
                {
                    // Para cada linha lida do arquivo original:
                    foreach (string line in lines)
                    {
                        // Divide a linha em partes usando a vírgula como delimitador e armazena essas partes em um array.
                        string[] fields = line.Split(',');

                        // Pega o primeiro campo (nome) da linha.
                        string name = fields[0];

                        // Pega o segundo campo (preço) e converte-o para um valor double).
                        double price = double.Parse(fields[1], CultureInfo.InvariantCulture);

                        // Pega o terceiro campo (quantidade) e converte-o para um valor inteiro.
                        int quantity = int.Parse(fields[2]);

                        // Cria um novo objeto Product com as informações obtidas.
                        Product prod = new Product(name, price, quantity);

                        // Escreve no arquivo 'summary.csv' o nome do produto e o total do produto formatado com duas casas decimais.
                        sw.WriteLine(prod.Name + "," + prod.Total().ToString("F2", CultureInfo.InvariantCulture));
                    }
                }

            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
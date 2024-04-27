namespace introCSharp{
    public class Program{

        static void Main(string[] args){
            int op;
            float resultado = 0;
            do{
                Console.WriteLine("Digite qual operação deseja realizar.");
                Console.WriteLine("\n [1] Soma");
                Console.WriteLine("\n [2] Subtração");
                Console.WriteLine("\n [3] Multiplicação");
                Console.WriteLine("\n [4] Divisão");
                Console.WriteLine("\n [5] Zerar valor");
                Console.WriteLine("\n [7] Encerrar");
                op = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\n Digite o valor da operação: ");
                float num1 = Convert.ToInt32(Console.ReadLine());
                switch (op){
                    case 1:{
                        Console.Write($"\n {resultado} + {num1} = ");
                        resultado = Operacoes.Somar(num1, resultado);
                        Console.Write($"{resultado} \n");
                        break;
                    }
                    case 2:{
                        Console.Write($"\n {resultado} - {num1} = ");
                        resultado = Operacoes.Subtrair(num1, resultado);
                        Console.Write($"{resultado} \n");
                        break;
                    }
                    case 3:{
                        Console.Write($"\n {resultado} X {num1} = ");
                        resultado = Operacoes.Multiplicar(num1, resultado);
                        Console.Write($"{resultado} \n");
                        break;
                    }
                    case 4:{
                        Console.Write($"\n {resultado} / {num1} = ");
                        resultado = Operacoes.Dividir(num1, resultado);
                        Console.Write($"{resultado} \n");
                        break;
                    }
                    case 5:{
                        resultado = 0;
                        Console.WriteLine($"Valor zerado");
                        break;
                    }
                }
            }while(op != 7);
        }
    }
}
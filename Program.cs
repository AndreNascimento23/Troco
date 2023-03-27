Console.Clear();
Console.WriteLine("--- Calcule o Troco ---\n");

Console.Write("Digite o Valor da Compra..: R$ ");
decimal valor1 = Convert.ToDecimal(Console.ReadLine());


Console.Write($"\nDigite o Valor Pago..: R$ ");
decimal valor2 = Convert.ToDecimal(Console.ReadLine());


decimal troco = valor2 - valor1;

Console.WriteLine($"\nDevolva o Troco de: {troco:c}");

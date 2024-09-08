const double ReceitaFarinha = 1;
const double ReceitaAgua = 0.7;
const double ReceitaFermento = 0.4;
const double ReceitaSal = 0.02;

double percentualPaoRelativoFarinha = ReceitaFarinha + ReceitaAgua + ReceitaFermento + ReceitaSal;

double pesoPao, farinha, agua, fermento, sal;

Console.WriteLine("--- Padaria ---\n");

Console.WriteLine("Peso desejado de pão italiano (em gramas)...: ");
pesoPao = Convert.ToDouble(Console.ReadLine());

farinha = pesoPao / percentualPaoRelativoFarinha;

agua = farinha * ReceitaAgua;
fermento = farinha * ReceitaFermento;
sal = farinha * ReceitaSal;

Console.WriteLine("\nIngredientes:");

Console.WriteLine($"Farinha....: {farinha:N0} g");
Console.WriteLine($"Água.......: {agua:N0} g");
Console.WriteLine($"Fermento...: {fermento:N0} g");
Console.WriteLine($"Sal........: {sal:N0} g");

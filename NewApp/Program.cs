Console.WriteLine("Enter the action to be performed");
Console.WriteLine("Press 1 for Addition");
Console.WriteLine("Press 2 for Substraction");
Console.WriteLine("Press 3 for Multiplication");
Console.WriteLine("Press 4 for Division");

Console.WriteLine();
int inputPengguna = int.Parse(Console.ReadLine());
Console.WriteLine("Enter 1st input: ");
int angka1 = int.Parse(Console.ReadLine());
Console.WriteLine("Enter 2st input: ");
int angka2 = int.Parse(Console.ReadLine());

switch (inputPengguna)
{
    case 1:
    int penjumlahan = angka1 + angka2;
    Console.WriteLine(penjumlahan);
    break;

    case 2:
    int pengurangan = angka1 - angka2;
    Console.WriteLine(pengurangan);
    break;

    case 3:
    int perkalian = angka1 * angka2;
    Console.WriteLine(perkalian);
    break;

    case 4:
    double pembagian = (double) angka1 / (double) angka2;
    Console.WriteLine(pembagian);
    break;
}

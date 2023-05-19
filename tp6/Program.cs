float convertedNumber;
Console.WriteLine("Ingresar un numero: ");
string? numberInput = Console.ReadLine();

while (!float.TryParse(numberInput, out convertedNumber)) {
    Console.WriteLine("\nNumero invalido\n");
    Console.WriteLine("Ingresar un numero: ");
    numberInput = Console.ReadLine();
}

string invertedNumber = string.Empty;

for (int i = numberInput.Length - 1; i >= 0; i--) {
    invertedNumber += numberInput[i];
}

Console.WriteLine("Numero invertido: " + invertedNumber);



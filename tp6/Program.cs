//EJERCICIO 1
// float convertedNumber;
// Console.WriteLine("Ingresar un numero: ");
// string? numberInput = Console.ReadLine();

// while (!float.TryParse(numberInput, out convertedNumber)) {
//     Console.WriteLine("\nNumero invalido\n");
//     Console.WriteLine("Ingresar un numero: ");
//     numberInput = Console.ReadLine();
// }

// string invertedNumber = string.Empty;

// for (int i = numberInput.Length - 1; i >= 0; i--) {
//     invertedNumber += numberInput[i];
// }

// Console.WriteLine("Numero invertido: " + invertedNumber);

//EJERCICIO 2 Y 3
void showNumberData(float number) {
    Console.WriteLine("\n---DATOS---");
    Console.WriteLine("Valor absoluto: " + Math.Abs(number));
    Console.WriteLine("Cuadrado: " + (number * number));
    Console.WriteLine("Raiz cuadrada: " + Math.Sqrt(number));
    Console.WriteLine("Seno: " + Math.Sin(number));
    Console.WriteLine("Coseno: " + Math.Cos(number));
    Console.WriteLine("Parte entera: " + Math.Truncate(number));
}

void calculatorInterface() {
    bool validOption = true, keepGoing = true, validExitOption = true;
    int correctOption, correctExitOption;
    float correctOperandA, correctOperandB, correctOperandC;
    while(keepGoing) {
        do {
            Console.WriteLine("----MENU----");
            Console.WriteLine("1-Sumar\n2-Restar\n3-Multiplicar\n4-Dividir\n5-Mostrar datos de un numero\n6-Maximo y minimo");
            string? option = Console.ReadLine();
            if(!int.TryParse(option, out correctOption)) {
                validOption = false;
            }
            else if (!(correctOption <= 6 && correctOption >= 1)) {
                validOption = false;
            }
            else {
                validOption = true;
            }
            if(!validOption) {
                Console.WriteLine("\nIngresar una opcion valida\n");
            }
        } while (!validOption);
        if(correctOption == 5) {
            Console.WriteLine("\nIngresar el numero a mostrar sus datos");
            string? operandC = Console.ReadLine();
            while(!float.TryParse(operandC, out correctOperandC)) {
                Console.WriteLine("\nIngresar un numero valido\n");
                Console.WriteLine("Ingresar el numero a mostrar sus datos");
                operandC = Console.ReadLine();
            }
            showNumberData(correctOperandC);
        }
        else {
            Console.WriteLine("\nIngresar 2 numeros para operar");
            string? operandA = Console.ReadLine();
            string? operandB = Console.ReadLine();
            while(!float.TryParse(operandA, out correctOperandA) || !float.TryParse(operandB, out correctOperandB)) {
                Console.WriteLine("\nIngresar operandos validos\n");
                Console.WriteLine("Ingresar 2 numeros para operar");
                operandA = Console.ReadLine();
                operandB = Console.ReadLine();
            }
            switch (correctOption) {
                case 1:
                    Console.WriteLine($"\nLa suma entre {operandA.ToString()} y {operandB.ToString()} es : {(correctOperandA + correctOperandB).ToString()}");
                    break;
                case 2:
                    Console.WriteLine($"\nLa resta entre {operandA.ToString()} y {operandB.ToString()} es : {(correctOperandA - correctOperandB).ToString()}");
                    break;
                case 3:
                    Console.WriteLine($"\nLa multiplicacion entre {operandA.ToString()} y {operandB.ToString()} es : {(correctOperandA * correctOperandB).ToString()}");
                    break;
                case 4:
                    Console.WriteLine($"\nLa division entre {operandA.ToString()} y {operandB.ToString()} es : {(correctOperandA / correctOperandB).ToString()}");
                    break;
                case 6:
                    Console.WriteLine($"\nEl maximo entre {operandA.ToString()} y {operandB.ToString()} es : {Math.MaxMagnitude(correctOperandA, correctOperandB).ToString()}");
                    Console.WriteLine($"La suma entre {operandA.ToString()} y {operandB.ToString()} es : {Math.MinMagnitude(correctOperandA, correctOperandB)}");
                    break;
            }
        }
        do {
            Console.WriteLine("\nSeguir operando?\n1-Si\n2-No");
            string? exitOption = Console.ReadLine();
            if(!int.TryParse(exitOption, out correctExitOption)) {
                validExitOption = false;
            }
            else if (!(correctExitOption == 1 || correctExitOption == 2)) {
                validExitOption = false;
            }
            else {
                validExitOption = true;
            }
            if(!validExitOption) {
                Console.WriteLine("\nIngresar una opcion valida\n");
            }
        } while (!validExitOption);
        switch(correctExitOption) {
            case 1:
                break;
            case 2:
                keepGoing = false;
                break;
        }
    }
}

//EJERCICIO 4
Console.WriteLine("Ingresar una cadena");
string? inputText = Console.ReadLine();
while (inputText == null) {
    Console.WriteLine("Ingresar una cadena valida");
    inputText = Console.ReadLine();
}
Console.WriteLine("Su longitud es: " + inputText.Length);
Console.WriteLine("Ingresar otra cadena");
string? secondInputText = Console.ReadLine();
while (secondInputText == null) {
    Console.WriteLine("Ingresar una cadena valida");
    secondInputText = Console.ReadLine();
}
Console.WriteLine("Cadenas concatenadas: " + inputText + secondInputText);
Console.WriteLine("Subcadena: " + inputText.Substring(3));

calculatorInterface();

int letterOcurrencies = 0;
foreach (char character in inputText) {
    Console.WriteLine(character);
    if(character == 'a') {
        letterOcurrencies++;
    }
}
Console.WriteLine("\nOcurrencias de la letra a: " + letterOcurrencies);

Console.WriteLine("Cadena en minusculas: " + inputText.ToLower());
Console.WriteLine("Cadena en mayusculas: " + inputText.ToUpper());

Console.WriteLine("Ingresar una cadena separada por espacios");
string? testString = Console.ReadLine();
while (testString == null) {
    Console.WriteLine("Ingresar una cadena valida");
    testString = Console.ReadLine();
}
string[] substrings = testString.Split(' ');
while (substrings.Length == 0) {
    Console.WriteLine("Ingresar espacios en la cadena");
    testString = Console.ReadLine();
}
foreach (string substring in substrings) {
    Console.WriteLine("Subcadena: " + substring);
}

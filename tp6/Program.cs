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

//EJERCICIO 2
void calculatorInterface() {
    bool validOption = true, keepGoing = true, validExitOption = true;
    int correctOption, correctExitOption;
    float correctOperandA, correctOperandB;
    while(keepGoing) {
        do {
            Console.WriteLine("----MENU----");
            Console.WriteLine("1-Sumar\n2-Restar\n3-Multiplicar\n4-Dividir");
            string? option = Console.ReadLine();
            if(!int.TryParse(option, out correctOption)) {
                validOption = false;
            }
            else if (!(correctOption <= 4 && correctOption >= 1)) {
                validOption = false;
            }
            else {
                validOption = true;
            }
            if(!validOption) {
                Console.WriteLine("\nIngresar una opcion valida\n");
            }
        } while (!validOption);
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
                Console.WriteLine("\nSuma: " + (correctOperandA + correctOperandB));
                break;
            case 2:
                Console.WriteLine("\nResta: " + (correctOperandA - correctOperandB));
                break;
            case 3:
                Console.WriteLine("\nMultiplicacion: " + (correctOperandA * correctOperandB));
                break;
            case 4:
                Console.WriteLine("\nDivision: " + (correctOperandA / correctOperandB));
                break;
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

calculatorInterface();
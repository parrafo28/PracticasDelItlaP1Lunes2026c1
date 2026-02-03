try
{
    //decimal[] typedNumbers = new decimal[1];
    List<decimal> typedNumbers = new List<decimal>();
    int typedOperation = 0;
    decimal result = 0;
    int continueTyping = 1;

    Console.WriteLine("This is a calculator application");
    Console.WriteLine("Please insert the first number");

    typedNumbers[0] = Convert.ToDecimal(Console.ReadLine());

    //var index = 0;

    while (continueTyping == 1)
    {
        //  index++;
        //++index;
        //index = index + 1;
        //index += 1;
        Console.WriteLine("Please insert a new number");

        //var typedNumbersOld = typedNumbers;

        //typedNumbers = new decimal[typedNumbersOld.Length + 1];

        //for (int i = 0; i < typedNumbersOld.Length; i++)
        //{
        //    typedNumbers[i] = typedNumbersOld[i];
        //}

        //Array.Resize(ref typedNumbers, typedNumbers.Length + 1);

        //typedNumbers[typedNumbers.Length - 1] = Convert.ToDecimal(Console.ReadLine());
        typedNumbers.Add(Convert.ToDecimal(Console.ReadLine()));

        Console.WriteLine("you want to continue typing numbers? 1.yes/2.no (pleasetype only the number");
        continueTyping = Convert.ToInt32(Console.ReadLine());

    }


    Console.WriteLine("Please select the operation to perform (type only the number): 1. for sum, 2. for rest, 3. for multiply, 4. for division 5. for exit");


    typedOperation = Convert.ToInt32(Console.ReadLine());







    switch (typedOperation)
    {
        case 1:
            {
                //for (int i = 0; i < typedNumbers.Count; i++)
                //{
                //    result += typedNumbers[i];
                //    // result = result + typedNumbers[i];
                //}

                foreach (var number in typedNumbers)
                {
                    result += number;
                }
                break;
            }
        case 2:
            {
                foreach (var number in typedNumbers)
                {
                    result -= number;
                } 
                break;
            }
        case 3:
            {
                foreach (var number in typedNumbers)
                {
                    result *= number;
                }
                break;
            }
        case 4:
            {
                foreach (var number in typedNumbers)
                {
                    result /= number;
                }
                break;
            }
        default:
            {
                Console.WriteLine("The selected operation is not valid");
                break;
            }
    }



    Console.WriteLine("The result of the operation is: " + result);

}

catch (Exception ex)
{
    Console.WriteLine(ex.Message);
    Console.WriteLine("An error occurred while processing your request. Please ensure that you enter valid numbers and try again.");
}

Console.ReadKey();
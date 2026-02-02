try
{

    decimal typedNumber1 = 0;
    decimal typedNumber2 = 0;
    decimal result = 0;
    int typedOperation = 0;

    Console.WriteLine("This is a calculator application");
    Console.WriteLine("Please insert the first number");

    //try
    //{
    typedNumber1 = Convert.ToDecimal(Console.ReadLine());
    //}
    //catch (Exception)
    //{
    //    throw;
    //}

    Console.WriteLine("Please insert the second number");

    //try
    //{
    typedNumber2 = Convert.ToDecimal(Console.ReadLine());
    //}
    //catch (Exception)
    //{
    //    throw;
    //}
    Console.WriteLine("Please select the operation to perform (type only the number): 1. for sum, 2. for rest, 3. for multiply, 4. for division 5. for exit");


    typedOperation = Convert.ToInt32(Console.ReadLine());

    // ==    (igual de comparacion = , ===
    //!=    (diferente de) <>
    //<     (menor que)
    //>     (mayor que)
    //<=    (menor o igual que)
    //>=    (mayor o igual que)

    switch (typedOperation)
    {
        case 1:
            {
                result = typedNumber1 + typedNumber2;
                break;
            }
        case 2:
            {
                result = typedNumber1 - typedNumber2;
                break;
            }
        case 3:
            {
                result = typedNumber1 * typedNumber2;
                break;
            }
        case 4:
            {
                if (typedNumber2 != 0)
                {
                    result = typedNumber1 / typedNumber2;
                }
                else
                {
                    Console.WriteLine("Error: Division by zero is not allowed.");
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
//catch (FormatException)
//{
//    Console.WriteLine("Input format is incorrect. Please enter numeric values only.");
//}
//catch (DivideByZeroException)
//{
//    Console.WriteLine("Error: Division by zero is not allowed.");
//}
//catch (InvalidOperationException ex)
//{
//    Console.WriteLine("Invalid operation: " + ex.Message);
//}
//catch (ArgumentNullException)
//{
//    Console.WriteLine("Input cannot be null. Please enter valid numbers.");
//}
//catch (ArgumentOutOfRangeException)
//{
//    Console.WriteLine("The operation selected is out of range. Please select a valid operation.");
//}
//catch (ArithmeticException)
//{
//    Console.WriteLine("An arithmetic error occurred during the calculation. Please check your inputs and try again.");
//}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
    Console.WriteLine("An error occurred while processing your request. Please ensure that you enter valid numbers and try again.");
}
//finally { 
//    Console.WriteLine("Thank you for using the calculator application.");
//}

Console.ReadKey();
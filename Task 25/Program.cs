Console.WriteLine("Введите число A: ");
  int numberA = Convert.ToInt32(Console.ReadLine());
  Console.WriteLine("Введите число B: ");
  int numberB = Convert.ToInt32(Console.ReadLine());
  int exp = Exp(numberA, numberB);
int Exp(int numberA, int numberB){
  int result = 1;
  for(int i=1; i <= numberB; i++)
  {
    result = result * numberA;
  }
    return result;
}
  Console.WriteLine(exp);
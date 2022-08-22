    Console.WriteLine("Введите количество элементов массива");
    int el = int.Parse(Console.ReadLine());
    int[] arr = new int[el];
    Console.WriteLine("Введите массив:");
    for(int i = 0; i < arr.Length; i++)
    {
       Console.Write($"Введите элемент массива под индексом {i}:\t ");
        arr[i] = int.Parse(Console.ReadLine());
    }  
    Console.WriteLine("Наш массив");
    for (int i = 0;  i < arr.Length; i++)
    {
    Console.WriteLine(arr[i]);
    }
int total = 0;

    for (int i = 1; i < 1000; i++)
    {
        int resultado3 = i % 3;
        int resultado5 = i % 5;
    if (resultado3 == 0)
    {
        total = total + i;
    }
    else if (resultado5 == 0)
    {
        total = total + i;
    }
    Console.WriteLine(total);
}


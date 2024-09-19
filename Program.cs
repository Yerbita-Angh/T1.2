int p = 0, cont = 1;
string c;
Console.WriteLine("Ingrese el color del vehiculo");

while (cont >= 0)
{
    c = Console.ReadLine();
    if (c == "VERDE")
    {
        cont += 1;
        for (p = +1; p <= 3 && p >= 0;) { p = +1; }
    }
    else if (c == "ROJO")
    {
        cont += 1;
        for (p = +1; p <= 6 && p >= 4;) { p = +1; }

    }
    else if (c == "AZUL")
    {
        cont += 1;
        for (p = +1; p <= 9 && p >= 7;) { p = +1; }

    }
    else if (c == "F")
    {
        cont -= 1;
        Console.WriteLine($"lOS DIGITOS SON: {p}" );
        break;
    }
}
Console.ReadKey();
Console.WriteLine("Ingrese el precio consumido:");
int cons = int.Parse(Console.ReadLine());

if (cons <= 100)
{
    double descuento = 0.10 * cons;
    Console.WriteLine("Descuento: " + descuento);

    double subtotal = cons - descuento;
    Console.WriteLine("Subtotal: " + subtotal);

    double impuesto = 0.18 * subtotal;
    Console.WriteLine("Impuesto: " + impuesto);

    double Preciototal = subtotal + impuesto;
    Console.WriteLine("Cantidad a pagar: " + Preciototal);
}
else if (cons >= 100)
{
    double descuento = 0.20 * cons;
    Console.WriteLine("Descuento: " + descuento);

    double subtotal = cons - descuento;
    Console.WriteLine("Subtotal: " + subtotal);

    double impuesto = 0.18 * subtotal;
    Console.WriteLine("Impuesto: " + impuesto);

    double Preciototal = subtotal + impuesto;
    Console.WriteLine("Cantidad a pagar: " + Preciototal);
}
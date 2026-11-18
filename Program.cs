namespace RegistroInfo;



public class Producto
{
    public int Codigo { get; set; }

    private string NombreInfo;

    public string Nombre
    {
        get
        {
            return NombreInfo;
        }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("ERROR: EL NOMBRE ESTA INCOMPLETO");
            }
            else
            {
                NombreInfo = value;
            }
        }
    }

    private double precioValue;

    public double Precio
    {
        get
        {
            return precioValue;
        }
        set
        {
            if (value > 0)
            {
                precioValue = value;
            }
            else
            {
                throw new ArgumentException("ERROR: EL PRECIO DEBE SER MAYOR QUE CERO");
            }
        }
    }

    private int cantidadValue;

    public int Cantidad
    {
        get
        {
            return cantidadValue;
        }
        set
        {
            if (value >= 0)
            {
                cantidadValue = value;
            }
            else
            {
                throw new ArgumentException("ERROR: LA CANTIDAD NO PUEDE SER NEGATIVA");
            }
        }
    }

    public double ValorTotal
    {
        get
        {
            return Cantidad * Precio;
        }
    }

    public Producto(int codigo, string nombre, double precio, int cantidad)
    {
        Codigo = codigo;
        Nombre = nombre;
        Precio = precio;
        Cantidad = cantidad;
    }

    public void MostrarInfo()
    {
        Console.WriteLine("NOMBRE: " + Nombre);
        Console.WriteLine("CODIGO: " + Codigo);
        Console.WriteLine("CANTIDAD: " + Cantidad);
        Console.WriteLine("PRECIO: " + Precio);
        Console.WriteLine("VALOR TOTAL: " + ValorTotal);
    }
}

//Formas de instaciar clases
var sale = new Sale(15);
Sale saleDos = new Sale();
Sale saleTres = new();

var saleWithTax = new SaleWithTax(18,0.15);
SaleWithTax saleTax = new SaleWithTax();

//Formas de extraer la información
var message = sale.getInfo();
string messageDos = sale.getInfo();

//Imprimir en pantalla (Como el System.out.println())
Console.WriteLine(messageDos);

Console.WriteLine(saleWithTax.GetInfoWithTax());
Console.WriteLine(saleTax.sobreescrito()); //texto del hijo
Console.WriteLine(sale.sobreescrito()); // texto del padre
//Herencia
class SaleWithTax: Sale //Para heredar damos dos puntos :
{
    public double Tax { get; set; }
    public SaleWithTax(decimal total,double tax):base(total){
        this.Tax = tax;
    }
    public SaleWithTax()
    {

    }
    
    public string GetInfoWithTax()
    {
        return "El total es " + Total + "\nEl impuesto es: " + ((double)Total*Tax);
    }

    //Metodo modificado
    public override string sobreescrito() //Se pone la palabra override para que pueda ser sobreescrito
    {
        return "Ahora este metodo en el hijo cambia con este texto.";
    }
}

class Sale
{
    //Creacion de variables
    public decimal Total { get; set; } // Ímplmementación de getters y setters
    private decimal _some;
    protected decimal _someProtected;

    //Constructores
    //Lleno
    public Sale(decimal total)
    {
        this.Total = total;
        this._some = 8;
        this._someProtected = total;
    }

    //Vacio
    public Sale()
    {

    }

    //Creacion de metodos
    public string getInfo()
    {
        return "El total es " + Total;
    }

    //Metodo que puede ser sobreescrito
    public virtual string sobreescrito() //Se pone la palabra virtual para que pueda ser sobreescrito
    {
        return "Este metodo se puede sobreescribir.";
    }

}

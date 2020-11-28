using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

public class ProdutoComum
{
    public string nome; //Nome do produto
    public double preco; //Nome do produto

    public ProdutoComum(string Nome, double Preco) //parametros que a classe vai receber
    {
        nome = Nome;
        preco = Preco; 
    }
    public virtual string etiqueta() //Etiqueta do produto comum
    {
        return nome + " - R$" + preco.ToString("F2", CultureInfo.InvariantCulture);
    }
}

using System;

public abstract class Conta
{

    private decimal saldo;
    private string titular;

	public Conta(string t)
	{
        this.titular = t;
	}

    public virtual void Depositar(decimal valor)
    {
        saldo += valor;
    }

    public virtual void Sacar(decimal valor)
    {
        if (valor <= saldo)
            saldo -= valor;
    }

    public decimal Saldo { get { return saldo;  } }
    public string Titular { get { return titular; } }

}

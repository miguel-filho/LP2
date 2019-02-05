﻿using System;

public class ContaPoupanca : Conta
{

    private decimal taxaJuros;
    private DateTime dataAniversario;

    public ContaPoupanca(decimal j, DateTime d, string t) : base(t)
	{
        taxaJuros = j;
        dataAniversario = d;
	}

    public decimal Juros { get { return taxaJuros; } set { taxaJuros = value; } }
    public DateTime DataAniversario { get { return dataAniversario; } }

    public void AdicionarRendimento()
    {
        if (DateTime.Now.Equals(dataAniversario))
        {
            decimal rendimento;
            rendimento = this.Saldo * this.taxaJuros;
            Depositar(rendimento);
        }
    }

    public override string Id
    {
        get { return Titular + "(CP)"; }
    }

}

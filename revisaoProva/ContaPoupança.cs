class ContaPoupanca : Conta
{
    public override void Sacar(double quantia)
    {
        if (this.saldo < quantia)
            throw new Exception("Saldo insuficiente.");

        this.saldo -= quantia;
    }
}
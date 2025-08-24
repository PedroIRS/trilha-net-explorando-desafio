namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() {}

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            
            if (Hospedes.Count <= Suite.Capacidade)
            {
                Hospedes = hospedes;
            }
            else
            {
                throw new Exeption("Numero de hospedes maior que a capacidade da suite");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            return Hopesdes.Count;
        }

        public decimal CalcularValorDiaria()
        {
            if (DiasReservados => 10)
            {
                decimal valor = (DiasReservados * Suite.ValorDiaria) - (DiasReservados * Suite.ValorDiaria / 100);
            }
            else
            {
                decimal valor = DiasReservados * Suite.ValorDiaria;
            }
            
            return valor;
        }
    }
}

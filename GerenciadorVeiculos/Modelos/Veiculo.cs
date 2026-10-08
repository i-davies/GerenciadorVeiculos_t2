using Org.BouncyCastle.Asn1.Mozilla;
using System;


namespace GerenciadorVeiculos.Modelos
{
    // A Classe Veiculo é abastrata porque ela serve de molde para Carro e Moto
    public abstract class Veiculo
    {
        // Propriedades: guardam as informações do veiculo
        public int Id { get; set; }
        public string Modelo { get; set; }
        public decimal ValorDiaria { get; set; }

        // Construtor: usado para preencher os dados ao criar o veiculo na memória
        protected Veiculo(string modelo, decimal valorDiaria) 
        { 
            Modelo = modelo;
            ValorDiaria = valorDiaria;
        }

        // Método abastrato: toda classe filha é obrigada a ter este cálculo
        public abstract decimal CalcularSeguro();
    }
}

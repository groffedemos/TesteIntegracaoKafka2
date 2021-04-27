using System;
using System.IO;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Xunit;
using System.Text.Json;
using Confluent.Kafka;
using WorkerAcoes.IntegrationTests.Models;

namespace WorkerAcoes.IntegrationTests
{
    public class TestesIntegracaoWorkerAcoes
    {
        private const string COD_CORRETORA = "00000";
        private const string NOME_CORRETORA = "Corretora Testes";
        private IConfiguration _configuration;

        public TestesIntegracaoWorkerAcoes()
        {
            _configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile($"appsettings.json")
                .AddEnvironmentVariables().Build();

        }

        [Theory]
        [InlineData("ABC", 100.98)]
        public void Test1(string codigo, double valor)
        {
            var acao = new Acao()
            {
                Codigo = codigo,
                Valor = valor,
                CodCorretora = COD_CORRETORA,
                NomeCorretora = NOME_CORRETORA
            };

        }
    }
}
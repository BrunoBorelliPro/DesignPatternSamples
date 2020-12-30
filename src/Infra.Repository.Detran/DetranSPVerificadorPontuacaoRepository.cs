using DesignPatternSamples.Application.Repository;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternSamples.Infra.Repository.Detran
{
    class DetranSPVerificadorPontuacaoRepository : IDetranVerificadorPontuacaoRepository
    {
        private readonly ILogger _Logger;

        public DetranSPVerificadorPontuacaoRepository(ILogger logger)
        {
            _Logger = logger;
        }

        public Task<int> ConsultarPontuacao(string cpf)
        {
            _Logger.LogDebug($"Consultando a pontuação para o cpf {cpf} para o estado de SP.");
            return Task.FromResult(0);
        }
    }
}

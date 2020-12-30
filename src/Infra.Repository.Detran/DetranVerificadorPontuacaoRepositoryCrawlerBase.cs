using DesignPatternSamples.Application.DTO;
using DesignPatternSamples.Application.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternSamples.Infra.Repository.Detran
{
    public abstract class DetranVerificadorPontuacaoRepositoryCrawlerBase : IDetranVerificadorPontuacaoRepository
    {
        public async Task<int> ConsultarPontuacao(string cpf)
        {
            var html = await RealizarAcesso(cpf);
            return await PadronizarResultado(html);
        }
        protected abstract Task<string> RealizarAcesso(string cpf);
        protected abstract Task<int> PadronizarResultado(string html);

    }
}

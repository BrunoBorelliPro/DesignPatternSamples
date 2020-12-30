using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternSamples.Application.Repository
{
    public interface IDetranVerificadorPontuacaoRepository
    {
        Task<int>ConsultarPontuacao(string cpf);
    }
}

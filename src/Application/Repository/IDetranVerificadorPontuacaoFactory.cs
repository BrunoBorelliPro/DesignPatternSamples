using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternSamples.Application.Repository
{
    public interface IDetranVerificadorPontuacaoFactory
    {
        public IDetranVerificadorPontuacaoFactory Register(string UF, Type repository);
        public IDetranVerificadorPontuacaoRepository Create(string UF);
    }
}

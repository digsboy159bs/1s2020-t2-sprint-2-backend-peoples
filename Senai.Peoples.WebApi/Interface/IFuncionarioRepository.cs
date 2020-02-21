using Senai.Peoples.WebApi.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Peoples.WebApi.Interface
{
    interface IFuncionarioRepository
    {
        List<FuncionarioDomain> Listar();

        void Cadastrar(FuncionarioDomain funcionario);

        void AtualizarIdUrl(int id, FuncionarioDomain funcionario);

        FuncionarioDomain BuscarPorId(int id);

        void Deletar(int id);

        void AtualizarIdCorpo(FuncionarioDomain funcionario);
    }
}

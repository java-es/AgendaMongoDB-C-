using MongoDB.Bson;
using System;
using System.Collections.Generic;

namespace AgendaMongoDB
{
    public interface IAgendaDAO
    {
        void Salvar(Agenda agenda);
        void Atualizar(Agenda agenda);
        void Deletar(ObjectId id);
        List<Agenda> BuscaAgendas();
        Agenda BuscaAgenda(String codigo);
    }
}

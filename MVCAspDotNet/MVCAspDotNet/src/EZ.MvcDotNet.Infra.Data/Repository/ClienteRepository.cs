using System;
using System.Linq;
using Dapper;
using EZ.MvcDotNet.Domain.Entities;
using EZ.MvcDotNet.Domain.Interfaces.Repository;

namespace EZ.MvcDotNet.Infra.Data.Repository
{
    public class ClienteRepository : Repository<Cliente>, IClienteRepository
    {
        public Cliente ObterPorCPF(string cpf)
        {
            return Buscar(c => c.CPF == cpf).FirstOrDefault();
        }

        public Cliente ObterPorEmail(string email)
        {
            return Buscar(c => c.Email == email).FirstOrDefault();
        }


        /// Reescrevendo filtro com Dapper 
        /// 
        /// O Dapper é indicado para otimizar as consultas a banco
        public override Cliente ObterPorId(Guid id)
        {
            var sql = @"SELECT * FROM Clientes c " +
                      "INNER JOIN Enderecos e ON c.ClienteId = e.ClienteId " +
                      "WHERE c.ClienteId = @sid ";

            using (var cn = Db.Database.Connection)
            {
                cn.Open();
                // Consulta Simples
                // var cliente = cn.Query<Cliente>(sql, new {sid = id});

                // Consulta Completa
                var cliente = cn.Query<Cliente, Endereco, Cliente>(sql,
                    (c, e) =>
                    {
                        c.Enderecos.Add(e);
                        return c;
                    }, new { sid = id}, splitOn: "ClienteId, EnderecoId");


                return cliente.FirstOrDefault();
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mime;
using SistemaDeVendas.DAL.Interfaces;
using SistemaDeVendas.Entity;
using SistemaDeVendas.BLL.Interfaces;

namespace SistemaDeVendas.BLL.Implementation
{
    public class EmailServico : IEmailServico
    {
        private readonly IGenericRepository<Configuracao> _configRepository;

        public EmailServico(IGenericRepository<Configuracao> confRepository)
        {
            _configRepository = confRepository;
        }

        public async Task<bool> EnviarEmail(string EmailDestino, string Assunto, string Mensagem)
        {
            try
            {
                //IQueryable<Configuracao> query = (IQueryable<Configuracao>)await _configRepository.Get(c => c.Recurso.Equals("Servico_Email"));
                IQueryable<Configuracao> query = await _configRepository.Get(c => c.Recurso.Equals("Servico_Email"));

                Dictionary<string, string> Conf = query.ToDictionary(keySelector: c => c.Propriedade, elementSelector: c => c.Valor);

            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}

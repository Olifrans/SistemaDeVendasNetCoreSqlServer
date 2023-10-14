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
using System.Reflection.PortableExecutable;
using System.Net.Mail;

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
				IQueryable<Configuracao> query = (IQueryable<Configuracao>)await _configRepository.Get(c => c.Recurso.Equals("Servico_Email"));
				//IQueryable<Configuracao> query = await _configRepository.Get(c => c.Recurso.Equals("Servico_Email"));

				Dictionary<string, string> Config = query.ToDictionary(keySelector: c => c.Propriedade, elementSelector: c => c.Valor);

				//Config email
				var credenciais = new NetworkCredential(Config["email"], Config["chave"]);

				var email = new MailMessage()
				{
					//Email de origem
					From = new MailAddress(Config["email"], Config["alias"]),
					Subject = Assunto,
					Body = Mensagem,
					IsBodyHtml = true
				};

				email.To.Add(new MailAddress(EmailDestino));


				var clienteServidor = new SmtpClient()
				{
					//Host
					Host = Config["host"],
					Port = int.Parse(Config["porta"]),
					DeliveryMethod = SmtpDeliveryMethod.Network,
					UseDefaultCredentials = false,
					EnableSsl = true
				};

				clienteServidor.Send(email);
				return true;
			}
			catch (Exception)
			{
				return false;
			}
		}
	}
}

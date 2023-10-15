using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;

using Firebase.Auth;
using Firebase.Storage;
using Firebase.Auth;
using Firebase.Auth;


using SistemaDeVendas.BLL.Interfaces;
using SistemaDeVendas.DAL.Interfaces;
using SistemaDeVendas.Entity;
using Firebase.Auth.Providers;

namespace SistemaDeVendas.BLL.Implementation
{
	public class FireBaseServico : IFireBaseServico
	{
		private readonly IGenericRepository<Configuracao> _configRepository;

		public FireBaseServico(IGenericRepository<Configuracao> configRepository)
		{
			_configRepository = configRepository;
		}

		public async Task<string> UploadStorage(Stream StreamArquivo, string PastaDestino, string NomeArquivo)
		{
			string UrlImagen = "";
			try
			{
				IQueryable<Configuracao> query = (IQueryable<Configuracao>)await _configRepository.Get(c => c.Recurso.Equals("FireBase_Storage"));
				//IQueryable<Configuracao> query = await _configRepository.Get(c => c.Recurso.Equals("Servico_Email"));

				Dictionary<string, string> Config = query.ToDictionary(keySelector: c => c.Propriedade, elementSelector: c => c.Valor);


				//Config autorização
				var auth = new FirebaseAuthProvider(new FirebaseConfig(Config["api_key"]));
				var authProvider = await auth.SignInWithEmailAndPasswordAsync(Config["email"], Config["chave"]);

				var cancelar = new CancellationTokenSource();

				var task = new FirebaseStorage(

					)
				


			}
			catch (Exception)
			{

				throw;
			}
		}

		public Task<string> DeletStorage(string PastaDestino, string NomeArquivo)
		{
			throw new NotImplementedException();
		}
	}
}

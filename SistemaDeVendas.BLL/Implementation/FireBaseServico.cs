using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Firebase.Auth;
using Firebase.Storage;
using SistemaDeVendas.BLL.Interfaces;
using SistemaDeVendas.DAL.Interfaces;
using SistemaDeVendas.Entity;
using Firebase.Auth.Providers;

using Firebase;
using System.Collections;
using FirebaseAdmin.Auth;

;
//using TMPro;
//using UnityEngine;


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




				var auth = new FirebaseAuthProvider(new FirebaseConfig(Config["api_key"]));
				var authProvider = await auth.SignInWithEmailAndPasswordAsync(Config["email"], Config["chave"]);




				var cancelar = new CancellationTokenSource();

				var task = new FirebaseStorage(
					Config["rota"],
						new FirebaseStorageOptions
						{
							AuthTokenAsyncFactory = () => Task.FromResult(authProvider.FirebaseToken),
							ThrowOnCancel = true
						})
					.Child(Config[PastaDestino])
					.Child(NomeArquivo)
					.PutAsync(StreamArquivo, cancelar.Token);

				UrlImagen = await task;
			}
			catch
			{
				UrlImagen="";
			}

			return UrlImagen;
		}

		public async Task<bool> DeletStorage(string PastaDestino, string NomeArquivo)
		{
			try
			{
				IQueryable<Configuracao> query = (IQueryable<Configuracao>)await _configRepository.Get(c => c.Recurso.Equals("FireBase_Storage"));
				//IQueryable<Configuracao> query = await _configRepository.Get(c => c.Recurso.Equals("Servico_Email"));

				Dictionary<string, string> Config = query.ToDictionary(keySelector: c => c.Propriedade, elementSelector: c => c.Valor);




				var auth = new FirebaseAuthProvider(new FirebaseConfig(Config["api_key"]));
				var authProvider = await auth.SignInWithEmailAndPasswordAsync(Config["email"], Config["chave"]);




				var cancelar = new CancellationTokenSource();

				var task = new FirebaseStorage(
					Config["rota"],
						new FirebaseStorageOptions
						{
							AuthTokenAsyncFactory = () => Task.FromResult(authProvider.FirebaseToken),
							ThrowOnCancel = true
						})
					.Child(Config[PastaDestino])
					.Child(NomeArquivo)
					.DeleteAsync();

				await task;

				return true;
			}
			catch
			{
				return false;
			}
		}
	}
}

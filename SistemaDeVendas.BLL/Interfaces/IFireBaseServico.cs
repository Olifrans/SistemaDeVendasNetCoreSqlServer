using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeVendas.BLL.Interfaces
{
	public interface IFireBaseServico
	{
		Task<string> UploadStorage(Stream StreamArquivo,string PastaDestino, string NomeArquivo);
		Task<string> DeletStorage(string PastaDestino, string NomeArquivo);
	}
}

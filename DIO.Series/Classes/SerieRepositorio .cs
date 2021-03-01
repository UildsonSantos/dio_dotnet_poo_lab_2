using System.Collections.Generic;
using DIO.Series.Interfaces;

namespace DIO.Series
{
  	public class SerieRepositorio : IRepositorio<Serie>
	{
        private List<Serie> listaSerie = new List<Serie>();
		public void atualiza(int id, Serie entidade)
		{
			listaSerie[id] = entidade;
		}

		public void exclui(int id)
		{
			listaSerie[id].excluir();
		}

		public void insere(Serie entidade)
		{
			listaSerie.Add(entidade);
		}

		public List<Serie> lista()
		{
			return listaSerie;
		}

		public int proximoId()
		{
			return listaSerie.Count;
		}

		public Serie retornaPorId(int id)
		{
			return listaSerie[id];
		}
	}
}
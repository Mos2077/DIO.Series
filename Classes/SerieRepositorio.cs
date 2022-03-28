using System;
using System.Collections.Generic;
using DIO.Series.interfaces;

namespace DIO.Series
{
  public class SerieRepositorio : IRepositorio<Serie>
  {
    private List<Serie> ListaSerie = new List<Serie>();
    public void Atualiza(int id, Serie objeto)
    {
      ListaSerie[id] = objeto;
    }

    public void Exclui(int id)
    {
      ListaSerie[id].Excluir();
    }

    public void Insere(Serie objeto)
    {
      ListaSerie.Add(objeto);
    }

    public List<Serie> Lista()
    {
      return ListaSerie;
    }

    public int ProximoId()
    {
      return ListaSerie.Count;
    }

    public Serie RetornaPorId(int id)
    {
      return ListaSerie[id];
    }
  }
}


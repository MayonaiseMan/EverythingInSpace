using System;
using System.Threading;


public class Animale
{
  public static enum razze { VaccaVecchiaPiemontese, VaccaVecchiaGaliziana, RubiaGaliega}
  private DateTime _nascita;
  private string _nome;
  private razze _razza;

  public Animale(string nomeCapo, razze razzaCapo, DateTime nascitaCapo)
  {
      try
      {
        if(string.isNullorEmpty(nomeCapo) == false)
        _nome = nomeCapo;
      else
        throw new Exception("nome non valido");

        _razza = razzaCapo;

        _nascita = nascitaCapo;

      }catch(Excepton ex)
      {
          throw ex;
      }
  }


  public int Mesi
  {
    get
    {
          return CalcolaMesi();
    }

  }

  public string Nome
  {
    get
    {
      return _nome;
    }

  }

  public razze Razza
  {
    get
    {
      return _razza;
    }
  }

  private int CalcolaMesi()
  {
    int anni = DateTime.Now.Year - _nascita.Year;
    int mesi = DateTime.Now.Month - _nascita.Moth;
    int totale = anni * 12 + mesi;
    return totale;
  }




} 
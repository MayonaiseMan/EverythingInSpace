using System;
using System.Collections.Generics;

public class Stalla
{
  List<Animale> Animali;
  
  public Stalla()
  {
    Animali = new  List<Animale>();

  }

  public void CompraCapo(string nomeCapo, int razzaCapo, DateTime nascitaCapo)
  {
      Animale.razze razza = (Animale.razze) razzaCapo;
      Animale capo = new Animale(nomeCapo, razza, nascitaCapo);
      Animali.Add(capo);
  }

  public void CompraCapo(Animale a)
  {
    Animali.Add(a);
  }

  public List<Animale> VendiAnimaliMesi(int mesi)
  {
    List<Animale> Venduti = new  List<Animale>();
    foreach(Animale a in Animali)
    {
      if(a.Mesi == mesi)
      {
        Animali.Remove(a);
        Venduti.Add(a);
      }
      
    }

    return Venduti;

  }

  public List<Animale> GetAnimaliRazza(Animale.razze razza)
  {
    foreach(Animale a in Animali)
    {
      if(a.Razza = razza) 
    }

  }

}
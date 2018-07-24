using System;
using System.Collections.Generic;

namespace logicalMatrix
{
	/// <summary>
	/// Description of RandomNoRep.
	/// </summary>
	public class RandomNoRep
	{
		List<int> listaWejsciowa; // lista do pobrania ilosci argumentów z wywołania.
		List<int> listaWyjsciowa; // wymiesznana lista zwracana.
		Random randomizer;
		int zmiennaPomocnicza;
		
		public RandomNoRep(int liczbaElementow)
		{
			listaWejsciowa = new List<int>();
			listaWyjsciowa = new List<int>();
			randomizer = new Random();
			
			for (int i = 0; i < liczbaElementow; i++)
			{
				listaWejsciowa.Add(i);
			}
			
			for (int i = 0; i < listaWejsciowa.Count; )
			{
				zmiennaPomocnicza = randomizer.Next(0, listaWejsciowa.Count);
				listaWyjsciowa.Add(listaWejsciowa[zmiennaPomocnicza]);
				
				listaWejsciowa.RemoveAt(zmiennaPomocnicza);
					                   
			}

			zmiennaPomocnicza = 0;
		}
		
		public int zwrocIndex(int wartosc)
		{
			return listaWyjsciowa[wartosc];
		}
		

	}
		
	
}

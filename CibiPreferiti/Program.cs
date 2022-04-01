//Creo un array con i miei Cibi preferiti 
string[] iMieiCibiPrefeiti = { "Pizza","Manfredi con la ricotta" , "Genovese", "cotolette", "patatine", "Tondini", "carne alla brace", "linguini allo scoglio", "Zeppola di San Giuseppe", "cadrega"};
Console.WriteLine("Ciao!");
/* mostro quanti cibi sono presenti nella mia lista*/
Console.WriteLine("la mia lista ha " + iMieiCibiPrefeiti.Length + " cibi");

/* creo un ciclo for dove stamp la mia classifica di cibi*/
for (int i = 0; i < iMieiCibiPrefeiti.Length; i++)
{  
    Console.WriteLine(i + 1 + "  "  + iMieiCibiPrefeiti[i]);
}
/*Stamo il mio cibo preferito e quello meno preferito*/
Console.WriteLine( "il mio cibo top è in assoluto è la: " + iMieiCibiPrefeiti[0]);
Console.WriteLine("il mio cibo meno preferito è: " + iMieiCibiPrefeiti[iMieiCibiPrefeiti.Length-1]);

/*------BONUS------*/
/* Creo una variabile che calcola al posizione mediana del mio array  */
int posizioneValoreMedio = iMieiCibiPrefeiti.Length / 2;
/* Creo un if e else per controllare se l'array sia pari o meno*/
if (iMieiCibiPrefeiti.Length % 2 == 0)
{ 
    Console.WriteLine("Cibo di media classifica: " + iMieiCibiPrefeiti [posizioneValoreMedio] + " e " + iMieiCibiPrefeiti[posizioneValoreMedio-1]);
}
else
{
    Console.WriteLine("Cibo di media classifica " + iMieiCibiPrefeiti[posizioneValoreMedio]);
}
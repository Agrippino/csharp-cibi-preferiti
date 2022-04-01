// See https://aka.ms/new-console-template for more information

//Creo un array con i miei Cibi preferiti 
string[] iMieiCibiPrefeiti = { "Pizza","Manfredi con la ricotta" , "Genovese", "cotolette", "patatine", "Tondini", "carne alla brace", "linguini allo scoglio", "Zeppola di San Giuseppe", "polipo"};
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
Console.WriteLine("il mio cibo meno preferito è: " + iMieiCibiPrefeiti[9]);


/*------BONUS------*/


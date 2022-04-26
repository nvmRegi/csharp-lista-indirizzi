using ListaIndirizzi;


Console.WriteLine("Hello, World!");

string path = "./addresses.csv";

List<Indirizzo> listaIndirizzi = new List<Indirizzo>();

StreamReader file = File.OpenText(path);

while (!file.EndOfStream)
{
    string line = file.ReadLine();
    string[] informazioni = line.Split(',');
    
    if(informazioni.Length == 6)
    {
        string nome = informazioni[0];
        string cognome = informazioni[1];
        string via = informazioni[2];
        string citta = informazioni[3];
        string provincia = informazioni[4];
        int ZIP = int.Parse(informazioni[5]);

        listaIndirizzi.Add(new Indirizzo(nome, cognome, via, citta, provincia, ZIP));
    }
    


}

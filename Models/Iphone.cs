namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }

        // TODO: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)
        {
            bool contem = false;
            foreach (var item in Aplicativos)
            {
                if (item.ToUpper() == nomeApp.ToUpper())
                {
                    contem = true;
                    break;
                }
            }
            if (contem)
            {
                System.Console.WriteLine($"O aplicativo {nomeApp} já está instalado na Apple Store!");
            }
            else{
                Aplicativos.Add(nomeApp);
                System.Console.WriteLine($"Aplicativo {nomeApp} instalado com sucesso na Apple Store!");
            }
        }
        public override void DesinstalarAplicativo(string nomeApp)
        {
            bool contem = false;
            for (int i = 0; i < Aplicativos.Count; i++)
            {
                if (nomeApp.ToUpper()==Aplicativos[i].ToUpper())
                {
                    contem = true;
                    break;
                }
            }
            if (contem)
            {
                Aplicativos.Remove(nomeApp);
                System.Console.WriteLine($"Aplicativo {nomeApp} desinstalado com sucesso da Apple Store!");
            }
            else{
                System.Console.WriteLine($"Não contém aplicativo {nomeApp} nos aplicativos instalados da Apple Store.");
            }
        }
    }
}
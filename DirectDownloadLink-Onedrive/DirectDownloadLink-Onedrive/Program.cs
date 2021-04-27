using System;

/*
 * Il seguente programma permette, partendo da un link di sharing OneDrive (NON DI UNA
 * CARTELLA!) di ottenere un link Direct-Download.
 * Differenza:
 * - Link di sharing OneDrive: apre una interfaccia web per visualizzare il file, scaricabile
 * attraverso l'uso di un bottone dell'interfaccia
 * - Link Direct-Download: scarica direttamente il file, utilizzando le API di Microsoft.
 * Perfetto per fornire link di download di tipo "mirror", utilizzati soprattutto da programmi
 * automatici che non sarebbero in grado di interagire con una interfaccia grafica!
 */

namespace DirectDownloadLink_Onedrive
{
    class Program
    {
        static void Main(string[] args)
        {
            string sharingUrl = "";
            string base64Value = System.Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(sharingUrl));
            string encodedUrl = "u!" + base64Value.TrimEnd('=').Replace('/', '_').Replace('+', '-');
            string resultUrl = string.Format("https://api.onedrive.com/v1.0/shares/{0}/root/content", encodedUrl);

            Console.WriteLine(resultUrl);
            Console.ReadLine();
        }
    }
}

using System;

public class Class1
{
	public Class1()
	{
		Console.WriteLine("========== PyReg ===========");
		Console.WriteLine("Welkom bij PyReg, het Python KassaSysteem voor en door DeveloperLand!");
		Console.WriteLine("Tel de kassa, en geef op hoeveel er nu in zit.");
		Console.WriteLine("Bedrag in kassa? ");
		float bedragInKassaBegin = Console.ReadLine();
		int keuze = 0;
		int dagTotaal = 0;
		int aantalBonnen = 0;
		int dagTotaalTerug = 0;

		while (true)
        {
			Console.WriteLine("======== HOOFDMENU =========");
			Console.WriteLine("1. Nieuwe bon\n" + "2. Retour\n" + "3. Toon kassatotaal\n" + "9. Afsluiten\n");
			Console.WriteLine("============================");

			Console.WriteLine("Maak uw keuze en druk op <ENTER>. ");

			keuze = Console.ReadLine();

			if (keuze == 1)
            {
				int bestelKeuze = 0;
				int bonTotaal = 0;
				string bonString = "";
				while (bestelKeuze != 9)
                {
					Console.WriteLine("========= BON MENU =========");
					Console.WriteLine("Bon " + aantalBonnen);
					Console.WriteLine("1. Volwassene                    € 19,-");
					Console.WriteLine("2. Kinderen tot 12jr             € 9,-");
					Console.WriteLine("3. Kinderen tot 12jr             € 49,-");
					Console.WriteLine("4. Kinderen tot 12jr             € 4,50");
					Console.WriteLine("5. Kinderen tot 12jr             € 6,-");
					Console.WriteLine("6. Kinderen tot 12jr             € 9,-");
					Console.WriteLine("9. Afronden bon");
					Console.WriteLine("Z. Bon annuleren");
					Console.WriteLine("============================");
					Console.WriteLine("Maak uw keuze en druk op <ENTER>. ");
					bestelKeuze = Console.ReadLine();

					if (bestelKeuze == 1)
                    {
						bonTotaal = bonTotaal + 19;
						bonString = bonString + "1x Volwassene                  € 19\r\n"
					} 
					else if(bestelKeuze == 2)
                    {
						bonTotaal = bonTotaal + 9;
						bonString = bonString + "1x kind (tot 12jr)             € 9\r\n";
					}
					else if(bestelKeuze == 3)
                    {
						bonTotaal = bonTotaal + 49;
						bonString = bonString + "1x Familiepas                  € 49\r\n"
					}
					else if (bestelKeuze == 4)
                    {
						bonTotaal = bonTotaal + 4.50;
						bonString = bonString + "1x Parkkaart                   € 4,50\r\n"
					}
					else if (bestelKeuze == 5)
					{
						bonTotaal = bonTotaal + 6;
						bonString = bonString + "1x kinderwagen/bolderkarhuur   € 6\r\n"
					}
				}
            }
        }
	}
}

# Read me

## 1 första felet jag hittade var att i items.txt så fanns det en rad för mycket/ en rad med blankspace? tror de heter så kanske iallafall så startar programet efter de. Dock så vissas inte mjölk eller bröd utan bara deras pris medans ost vissas.

## 2 Okej så jag fattade inte först va felet var som gjorde att ost syntes men inte bröd eller mjölk. Jag frågade Claude och han  förklarade att de berode på att de inte fanns windows slash r i en del av koden och de gjorde att den items.txt bara tog ost eftersom de va de sista i item så den körede typ mjölk windows slash r bröd windwos slash r och sen bara ost inget windows slash (windows slash referar jag till slash som är på andra hålet än detta slashet / ) claude och förslog att jag skulle lägga till "string[] lines = File.ReadAllLines(path);" Så om jag har fattat de här rätt så kommer den ta en string som en array och då ta och läsa alla linjer som en lista med rader då denna readalllines ( path ) betyder att de ska läsa allt i rad form. Man kan iställeet för path köra de som text men då fungerar inte de men kan va användbart till framtiden kanske. 

## 3 ser att något är fel med räknaren då den vissar fel summa. Den räknar bara brödet och osten vilket då blir 121 men de borde blir 136 istället. for (int i = 1; i < items.Count; i++) men arrayer och sånt börjar på 0, de kommer jag ihåg från våran text adventure. så de var bara att ändra int i = 0 istället.

## 4 testade precis att ta bort något som inte var med och då kraschade programet. Så jag la in en if sats men jag ville göra en bool för jag är relativt säker på att de borde fungera med en bool men jag känner inte mig tillräklgit säker på de men de borde gå tror jag, men med en if sats som gör att om de inte finns något i items så skriver den ut ett medelande och man får välja något annat.

## 5 Så man kan inte råka skriva en bokstav när man startar programet då kraschar det så jag la en in en trypasre istället för vanlig parse och körde några if saster. jag la in if saster på priset också.

## 6 Så i shoppinglist så fanns de en try and catch men catchen va tom så jag ändrade på det. Den ctachen gjorde också så att innan så stog de att listan sparrades även när den inte sparades så med den nya catchen som fixar de problemet.

## Del 2 så la jag till några såna här coola ArgumentException och ArgumentOutOfRangeException för att priset inte skulle vara negativ eller ha ett tomt namn. sen la jag till en budget limit på 670 för jag tyckte de lätt bra och så gjorde jag att add retunera false om de går över budgeten. 

## design val. jag körde att add retunerna en false i bool. jag körde en bool för att jag sa tidigare att jag va osäker på de så tänkte att jag skulle få med en sån. Jag tyckte de blev bra då den kör true om varan läggs till men false om den går över budgeten.

## Sen så kände jag mig klar men kontroll frågade med claude om jag har gjort allt och claude sa at man behöver ha något ifall man skriver negatitvt inut i txt filen jag tycker inte de är super nodvändigt kanske men jag la till det endån för att få mer flyt i fingrarna med att skriva kod men annars ja. Tyckte också del 2 va svårare än del 1

## förbättringar och reflektion. asså lite ascii art hade inte varit dålgit gjort de trevligare. En katalog med varor hade iheller inte skadadt någon. jag borde see mer youtube videos och sånt för jag känner inte mig super säker på detta asså. Liksom jag fattar för de mesta hur allt fungerar och vad man behöver, jag fattar att x gör så och y de. Men jag hade inte helt kunna komma på från scratch att jag ska köra just kanske argumentexception utan hjälp från claude. Jag fattar va argumentexception gör men jag känner inte med full säkerhet att jag skulle komma på att använda de från scratch. Finns de något tips på sånt här? Jag vill inte liksom hamla bakom eller att de blir så att jag tar för mycket ai stöd.  

## frågor, borde jag ha lagt till kommentarer i koden jag själv la in?  Borde jag skrivet på vilken rad linje felen var? borde jag ha förklarat felen mer? Borde jag skrivit mer profsionelt ? Borde jag ha förbättring och reflektion?










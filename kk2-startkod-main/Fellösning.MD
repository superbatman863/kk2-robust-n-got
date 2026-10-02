// 1 första felet jag hittade var att i items.txt så fanns det en rad för mycket/ en rad med blankspace? tror de heter så kanske iallafall så startar programet efter de. Dock så vissas inte mjölk eller bröd utan bara deras pris medans ost vissas.

// 2 Okej så jag fattade inte först va felet var som gjorde att ost syntes men inte bröd eller mjölk. Jag frågade Claude och han  förklarade att de berode på att de inte fanns windows slash r i en del av koden och de gjorde att den items.txt bara tog ost eftersom de va de sista i item så den körede typ mjölk windows slash r bröd windwos slash r och sen bara ost inget windows slash (windows slash referar jag till slash som är på andra hålet än detta slashet / ) claude och förslog att jag skulle lägga till "string[] lines = File.ReadAllLines(path);" Så om jag har fattat de här rätt så kommer den ta en string som en array och då ta och läsa alla linjer som en lista med rader då denna readalllines ( path ) betyder att de ska läsa allt i rad form. Man kan iställeet för path köra de som text men då fungerar inte de men kan va användbart till framtiden kanske. 

// 3 ser att något är fel med räknaren då den vissar fel summa. Den räknar bara brödet och osten vilket då blir 121 men de borde blir 136 istället. for (int i = 1; i < items.Count; i++) men arrayer och sånt börjar på 0, de kommer jag ihåg från våran text adventure. så de var bara att ändra int i = 0 istället.

// 4 testade precis att ta bort något som inte var med och då kraschade programet. Så jag la in en if sats men jag ville göra en bool för jag är relativt säker på att de borde fungera med en bool men jag känner inte mig tillräklgit säker på de men de borde gå tror jag, men med en if sats som gör att om de inte finns något i items så skriver den ut ett medelande och man får välja något annat.

// nu med 30 min kvar inser jag att jag borde nog följt markdown istället för att göra kommentarer här. 

// 5 Så man kan inte råka skriva en bokstav när man startar programet dp kraschar det s´å jag la en in en trypasre istället för vanlig parse och körde några if saster. jag la in if saster på priset också.

// 6 jag inser nu att jag kommer bli klar lite senare än va tiden säger och jag ber hemskt mycket om ursäkt för de.  Jag frågade claude om de här med catch och ingen catch. Så om jag har fattat de rätt så är try and catch typ lite som en if sats fast för om man gör fel tror jag ialalfall så la jag till de. 








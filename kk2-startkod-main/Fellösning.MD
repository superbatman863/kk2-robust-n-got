// 1 första felet jag hittade var att i items.txt så fanns det en rad för mycket/ en rad med blankspace? tror de heter så kanske iallafall så startar programet efter de. Dock så vissas inte mjölk eller bröd utan bara deras pris medans ost vissas.

// 2 Okej så jag fattade inte först va felet var som gjorde att ost syntes men inte bröd eller mjölk. Jag frågade Claude och han  förklarade att de berode på att de inte fanns windows slash r i en del av koden och de gjorde att den items.txt bara tog ost eftersom de va de sista i item så den körede typ mjölk windows slash r bröd windwos slash r och sen bara ost inget windows slash (windows slash referar jag till slash som är på andra hålet än detta slashet / ) claude och förslog att jag skulle lägga till "string[] lines = File.ReadAllLines(path);" Så om jag har fattat de här rätt så kommer den ta en string som en array och då ta och läsa alla linjer som en lista med rader då denna readalllines ( path ) betyder att de ska läsa allt i rad form. Man kan iställeet för path köra de som text men då fungerar inte de men kan va användbart till framtiden kanske. 







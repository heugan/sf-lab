#language: sv-SE
Egenskap: Kalkylator
	Som användare
	Vill jag kunna addera
	För att slippa räkna fel
	
Scenario: Addera två tal
	Givet Jag har skrivit in 50 i kalkylatorn
	Och Jag har också skrivit in 70 i kalkylatorn
	När Jag klickar på Addera
	Så Ska resultatet bli 120 på skärmen

Scenariomall: Addera två tal enligt tabell
	Givet Jag har skrivit in <term1> i kalkylatorn
	Och Jag har också skrivit in <term2> i kalkylatorn
	När Jag klickar på Addera
	Så Ska resultatet bli <summa>  på skärmen
	
	Exempel: 
	| test-id  | term1 | term2 | summa |
	| nollor   | 0     | 0     | 0     |
	| 0_1_1    | 0     | 1     | 1     |
	| 1_0_1    | 1     | 0     | 1     |
	| 1_1_2    | 1     | 1     | 2     |
	| negativa | -10   | -20   | -30   |
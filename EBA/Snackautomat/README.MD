# Snackautomat
## EBA 1 Lehrjahr 
### Version 1.0.0 	8-10-2018
#### Aufgabe 
Die Aufgabe war es, je nach dem Gewicht und des Hungergefühles einen Snack/ eine Mahlzeit auszugeben.
Der Gewichttyp und das Hungergefühl sollen über radiobuttons in Groupboxen ausgewählt werden.
Je größer der Wert von Gewichttyp + Hungergefühl desto mehr gibt es zu essen.



**Gewichittypen** :<br>
```untergewichtig  - value 2``` <br>
```normal 	- value 1``` <br>
```übergewichtig   - value 0```

**Hungergefühl**  :<br>
``` 	nicht wirklich  - value 0``` <br>
		   ```	etwas 		- value 1``` <br>
		   ```	sehr hungrig	- value 2```

**Output**: 
*Gewichttypen + Hungergefühl* <br>
value = <br>
```	0 : Salad``` <br>
		```1 : Salad with meat``` <br>
		```2 : French with bread rolls``` <br>
		```3 : Bratwurst with bread rolls``` <br>
		```4 : Extra large Döner with cheese```
		
		
## Was hab ich gelernt

Static Classes :
Ist eine Klasse Static, so können in ihk keine Objekte mehr erzeugt werden. <br>
Desweiteren müssen alle Methoden in ihr auch das Schlüsselwort Static enthalten. <br> 
Wenn euch das mehr interessiert könnt ihr es [hier](https://docs.microsoft.com/de-de/dotnet/csharp/programming-guide/classes-and-structs/static-classes-and-static-class-members) noch einmal genauer nachlesen.



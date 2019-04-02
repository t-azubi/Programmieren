# Variablen und Datentypen

## Was sind Variablen

### Definition

Variable sind Speicherzellen, die über einen Namen (den Bezeichner) angesprochen werden. In der Speicherzelle wird der Wert der Variablen abgelegt. Variable haben einen <br> zugeordneten Datentyp. Auf Variable kann sowohl lesend als auch schreibend zugegriffen werden. Variable können also ihren Wert ändern. <br>

Die Bezeichner können beliebig lang sein, das erste Zeichen muss aber ein Buchstabe sein. Leerzeichen sind nicht erlaubt. <br>

Anschauliche Erklärung:
Die Variable kann man sich als Schachtel vorstellen. Auf der Frontseite der Schachtel steht der Name (Bezeichner) der Variablen und in der Schachtel liegt ein Zettel, auf dem der Wert der Variablen steht. Je nach Datentyp ist die Größe der Schachtel unterschiedlich, d.h. werden verschieden viele Speicherzellen reservier <br>

### Beispiel

```
const int i = 3;         // Konstante; keine Variable
int j = 3;               // Wertevariable
object k = (object)3;    // referenzielle Variable auf einen Wert
object o = new object(); // referenzielle Variable auf ein Objekt
object n = null;         // referenzielle Variable auf das null-Objekt (Zeiger auf Speicheradresse 0)
```

## Was sind Datentypen 

### Definition 

Formal bezeichnet ein Datentyp in der Informatik die Zusammenfassung von Objektmengen mit den darauf definierten Operationen. Dabei werden durch den Datentyp des Datensatzes unter Verwendung einer sogenannten Signatur ausschließlich die Namen dieser Objekt- und Operationsmengen spezifiziert. Ein so spezifizierter Datentyp besitzt noch keine Semantik.

Die weitaus häufiger verwendete, aber speziellere Bedeutung des Begriffs Datentyp stammt aus dem Umfeld der Programmiersprachen und bezeichnet die Zusammenfassung konkreter Wertebereiche und darauf definierter Operationen zu einer Einheit. Beispiele können Ganz- oder Kommazahlen, Zeichenketten oder auch komplexere Typen wie Datum/Zeit oder Objekte sein. Zur Unterscheidung wird für diese Datentypen in der Literatur auch der Begriff Konkreter Datentyp verwendet.

Der gedankliche Übergang von der formalen Definition zu der im Umfeld von Programmiersprachen verwendeten Definition konkreter Datentypen geschieht dabei über die sukzessive Einführung einer Semantik zu den formal spezifizierten Namen der Objekt- und Operationsmengen. Die Konkretisierung der Operationsmenge führt zu Abstrakten Datentypen beziehungsweise Algebren. Mit der weiteren Konkretisierung der Objektmenge ergibt sich der Konkrete Datentyp.

### Elementare datentypen

Elementare Datentypen, auch einfache Datentypen oder primitive Datentypen genannt, können nur einen Wert des entsprechenden Wertebereichs aufnehmen. Sie besitzen eine festgelegte Anzahl von Werten (Diskretheit) sowie eine fest definierte Ober- und Untergrenze (Endlichkeit). Daher können reelle Zahlen als Gleitkommazahlen nur mit einer bestimmten Genauigkeit abgebildet werden. Für elementare Datentypen sind in einer Programmiersprache Grundoperationen definiert, bei den Zahlen sind das die Grundrechenarten. Datentypen haben je nach Programmiersprache und Wertebereich unterschiedliche Bezeichnungen, und werden groß oder klein geschrieben (hier zur Übersicht alle groß).

Ganze Zahlen

    Bezeichnung: BIGINT, BIN, BIN FIXED, BINARY, BYTE, COMP, INT, INTEGER, LONG, LONG INT, LONGINT, MEDIUMINT, SHORT, SHORTINT, SMALLINT
    Wertebereich: Meist 32 Bit (−231…231-1), 8 Bit, 16 Bit, 64 Bit
    Operationen: +, -, *, <, >, =, Ganzzahldivision, Modulo, bitweise Operatoren

Natürliche Zahlen

    Bezeichnung: BYTE, CARDINAL, DWORD, NATURAL, UINT, UNSIGNED, UNSIGNED CHAR, UNSIGNED INT, UNSIGNED LONG, UNSIGNED SHORT, WORD
    Wertebereich: Meist 32 Bit, (0…232-1), 8 Bit, 16 Bit, 64 Bit
    Operationen: +, -, *, <, >, =, Ganzzahldivision, Modulo, bitweise Operatoren

Festkommazahlen (Dezimalzahlen)

    Bezeichnung: COMP-3, CURRENCY, PACKED DECIMAL, DEC, DECIMAL, MONEY, NUMERIC
    Wertebereich: Wertebereich direkt abhängig von der maximalen Stellenanzahl, die meist vorzugeben ist; CURRENCY (64 Bit): -922337203685477,5808…922337203685477,5807
    Operationen: +, -, *, <, >, =, Ganzzahldivision, Modulo

Aufzählungstypen

    Bezeichnung: ENUM, SET oder implizit
    Wertebereich: Frei wählbar, beispielsweise (SCHWARZ, ROT, BLAU, GELB)
    Operationen: <, >, =

Boolean (logische Werte)

    Bezeichnung: BOOL, BOOLEAN, LOGICAL, oder (implizit ohne Bezeichner)
    Wertebereich: (TRUE, FALSE) oder (= 0, ≠ 0) oder (= -1, = 0)
    Operationen: NOT, AND, XOR, NOR, NAND, OR, =, ≠

Zeichen (einzelnes Zeichen)

    Bezeichnung: CHAR, CHARACTER
    Wertebereich: Alle Elemente des Zeichensatzes (zum Beispiel Buchstaben)
    Operationen: <, >, =, Konvertierung in INTEGER, …

Gleitkommazahlen

    Bezeichnung: DOUBLE, DOUBLE PRECISION, EXTENDED, FLOAT, HALF, LONGREAL, REAL, SINGLE, SHORTREAL
    Wertebereich: Verschiedene Definitionen (siehe unten)
    Operationen: +, -, *, /, <, >, =

### Zusammengesetzte Datentypen

Zusammengesetzte Datentypen sind ein Datenkonstrukt, welches aus einfacheren Datentypen besteht. Da sie theoretisch beliebig komplex werden können, werden sie auch häufig schon zu den Datenstrukturen gezählt. Den meisten Programmiersprachen gemeinsam sind:

    Reihung (Tupel), Tabelle; Feld (mehrdeutig!)
        Bezeichnung: ARRAY, (implizite Definition mit [n] oder (n) ohne Bezeichner)
        Wertebereich: Abbildung einer endlichen Menge (Indexmenge) auf den Wertebereich eines Basistyps (Elementtyp). Die Indexmenge muss dabei ordinal sein. Durch Anwenden mehrerer Indizes entsteht eine mehrdimensionale Reihung.
        Operationen: <, >, =, Zuweisung mit Zuweisungskompatibilität
        Beispiel: type 3D-Vektor is ARRAY(1..3) of INTEGER; 

    Zeichenkette fester Länge (Im Grunde sind Zeichenketten selbst nur eine Reihung des Typs Character (Zeichen). Da sie jedoch in vielen Programmiersprachen vordefiniert sind, werden sie hier gesondert aufgelistet.)

        Bezeichnung: Array of CHAR, CHAR(n), CHAR[n]
        Wertebereich: Alle möglichen Zeichenketten
        Operationen: Stringfunktionen (Teilstring, Konkatenation [Zusammensetzung]), <, >, =

    Zeichenkette variabler Länge. Die Länge ist feststellbar, implizit durch ein Metazeichen als String-Endezeichen (ASCII \0), explizit durch eine Variable, oder über eine Standardfunktion. Häufig als Abstrakter Datentyp in einer Standardbibliothek.

        Bezeichnung: String, Array of CHAR, VARCHAR, CLOB, Text
        Wertebereich: Zeichenketten variabler Länge
        Operationen: Stringfunktionen (Teilstring, Länge, Konkatenation [Zusammensetzung]), <, >, =

    Binäre Zeichenkette variabler Länge. Die Länge kann durch eine Variable oder über eine Standardfunktion ermittelt werden.

        Bezeichnung: BLOB
        Wertebereich: binäre Zeichenketten variabler Länge
        Operationen: Länge, Konkatenation [Zusammensetzung], =
    
        Verbund, Satz, Struktur, Bereich

        Bezeichnung: RECORD, STRUCT, CLASS (erweiterte Bedeutung), 
        (implizite Definition über Stufennummern)

        Wertebereich: Ein Verbund enthält eine Folge verschiedener Komponenten,welche 
        verschiedene Datentypen haben können. Als Komponententyp ist jeder Typ zulässig.

In einigen objektorientierten Programmiersprachen (zum Beispiel Oberon) können Verbunde zur Beschreibung des Verhaltens der Komponenten des Verbunds mittels Methoden auch typengebundene Prozeduren haben.

        Operationen: Vergleich (nur Gleichheit oder Verschiedenheit), Zuweisung mit oder ohne 
        Zuweisungskompatibilität (stark programmiersprachenabhängig)
        Beispiel: type Prüfung is RECORD (Fach: STRING, Schueler: STRING, Punkte: INTEGER, 
        Lehrer: STRING, Termin: DATUM
        In vielen Programmiersprachen existieren Möglichkeiten, den Speicherbereich eines 
        Verbunds mehrfach unterschiedlich zu interpretieren. Das wird Variantenrecord oder 
        UNION genannt. Dabei ist jedoch meist keine Typsicherheit mehr gegeben.

# Testen und der Grüne Haken

## Unit Test

In der Programmierung ist Unit-Testing ein Software-Testverfahren, bei dem einzelne Quellcodeeinheiten auf ihre Einsatzfähigkeit getestet werden. Um es besser zu verstehen, ist ein Komponententest die kleinstmögliche testbare Softwarekomponente. Normalerweise erfüllt es eine einzige kohäsive Funktion. Da die Einheit klein ist, ist es einfacher, Testergebnisse zu entwerfen, auszuführen, aufzuzeichnen und zu analysieren als bei größeren Codeblöcken. Die bei einem Komponententest festgestellten Mängel sind leicht zu lokalisieren und relativ einfach zu beheben.

Ziel des Unit-Tests ist es, jeden Teil des Programms zu trennen und zu testen, ob die einzelnen Teile korrekt funktionieren. Es isoliert das kleinste Stück prüfbarer Software vom Rest des Codes und bestimmt, ob es sich genau so verhält, wie du es erwarten. Die Unit-Tests haben sich bewährt, da ein großer Teil der Fehler während des Einsatzes identifiziert wird. Es ermöglicht die Automatisierung des Testprozesses, reduziert die Schwierigkeiten bei der Erkennung von Fehlern, die in komplexeren Teilen der Anwendung enthalten sind, und die Testabdeckung wird oft erhöht, da jeder Einheit Aufmerksamkeit geschenkt wird.

Nur um Ihnen ein Beispiel zu geben: Wenn du zwei Einheiten haben und sich entscheiden, dass es kostengünstiger wäre, sie zusammenzukleben und sie zunächst als integrierte Einheit zu testen, kann ein Fehler an einer Vielzahl von Stellen auftreten:

```
    Fehler in Einheit 1?
    Fehler in Einheit 2?
    Fehler in beiden Einheiten?
    Fehler in der Schnittstelle zwischen den Geräten?
    Fehler wegen eines Mangels im Test?
```

Wie du sehen kannst, ist das Auffinden des Fehlers im integrierten Modul viel komplizierter, als zuerst die Einheiten zu isolieren, jede einzelne zu testen, sie dann zu integrieren und das Ganze zu testen.

Unit Testing bietet wirklich zahlreiche Vorteile, darunter das frühzeitige Auffinden von Softwarefehlern, die Erleichterung von Änderungen, die Vereinfachung der Integration, die Bereitstellung einer Dokumentationsquelle und viele andere, die wir im Folgenden näher betrachten werden.

Wie du richtig UnitTest schreibst findest du [hier](https://www.c-sharpcorner.com/article/a-basic-introduction-of-unit-test-for-beginners/) oder [hier](https://docs.microsoft.com/en-us/visualstudio/test/unit-test-basics?view=vs-2019)

<details close>
<summary>Vorteile des UnitTesten </summary>

## 1. DEN PROZESS AGIL MACHEN

Einer der Hauptvorteile des Unit-Tests besteht darin, dass er den Codierungsprozess agiler macht. Wenn du einer Software immer mehr Funktionen hinzufügst, musst du manchmal das alte Design und den alten Code ändern. Aber das Ändern von bereits getestetem Code ist sowohl riskant als auch kostspielig. Wenn wir über Unit-Tests verfügen, können wir mit Zuversicht mit dem Refactoring fortfahren.
Unit-Testing geht wirklich Hand in Hand mit agiler Programmierung aller Varianten, denn es baut Tests ein, die es Ihnen ermöglichen, Änderungen einfacher vorzunehmen. Mit anderen Worten, Unit-Tests ermöglichen ein sicheres Refactoring.

## 2. CODEQUALITÄT

Der Unit-Test verbessert die Qualität des Codes; er identifiziert jeden Fehler, der aufgetreten sein könnte, bevor der Code zum Integrationstest weitergeschickt wird. Das Schreiben von Tests vor der eigentlichen Codierung lässt du härter an das Problem denken. Es deckt die Randgehäuse auf und lässt du besseren Code schreiben.

## 3. SOFTWAREFEHLER FRÜHZEITIG FINDEN

Probleme werden frühzeitig erkannt. Da Unit-Tests von Entwicklern durchgeführt werden, bei denen sie ihren individuellen Code vor der Integration testen, können Probleme sehr früh erkannt und dann und dort gelöst werden, ohne die anderen Codes zu beeinträchtigen. Dazu gehören sowohl Fehler in der Implementierung des Programmierers als auch Fehler oder fehlende Teile der Spezifikation für das Gerät.

## 4. ERLEICHTERT ÄNDERUNGEN UND VEREINFACHT DIE INTEGRATION

Der Unit-Test ermöglicht es dem Programmierer, Code zu refaktorisieren oder Systembibliotheken zu einem späteren Zeitpunkt zu aktualisieren und sicherzustellen, dass das Modul weiterhin korrekt funktioniert. Unit-Tests erkennen Änderungen, die einen Designvertrag verletzen können. du helfen bei der Pflege und Änderung des Codes.

Unit Testing reduziert wirklich Fehler in den neu entwickelten Features oder reduziert Fehler bei der Änderung der bestehenden Funktionalität.
Unit Testing überprüft die Genauigkeit der einzelnen Einheiten. Anschließend werden die Einheiten in eine Anwendung integriert, indem Teile der Anwendung durch Unit-Tests getestet werden, das spätere Testen der Anwendung während des Integrationsprozesses wird durch die Verifikation der einzelnen Einheiten erleichtert.

## 5. STELLT DIE DOKUMENTATION ZUR VERFÜGUNG

Die Unit-Tests liefern eine Dokumentation des Systems. Entwickler, die lernen möchten, welche Funktionalität ein Gerät bietet und wie man es verwendet, können sich die Unit-Tests ansehen, um ein grundlegendes Verständnis der Schnittstelle (API) des Geräts zu erlangen.

## 6. DEBUGGING-PROZESS

Unit-Tests helfen, den Debugging-Prozess zu vereinfachen. Wenn ein Test fehlschlägt, müssen nur die letzten Änderungen am Code debuggt werden.

## 7. DESIGN

Das Schreiben des Tests zwingt dich zunächst dazu, über Ihr Design nachzudenken und was es leisten muss, bevor du den Code schreiben. Dadurch bleibst du nicht nur konzentriert, sondern kannst auch bessere Designs erstellen.
Das Testen eines Teils des Codes zwingt dich, zu definieren, wofür dieser Code verantwortlich ist. Wenn du dies einfach tun könntest, bedeutet das, dass die Verantwortung des Kodex klar definiert ist und somit eine hohe Kohäsion aufweist.

## 8. DIE KOSTEN ZU REDUZIEREN

Da die Fehler frühzeitig im Unit-Test gefunden werden, hilft es, die Kosten für Bugfixes zu senken. Stellst du dir die Kosten für einen Fehler vor, der in den späteren Entwicklungsphasen wie beim Systemtest oder beim Abnahmetest auftritt. Und natürlich sind früher erkannte Fehler leichter zu beheben, denn später erkannte Fehler sind in der Regel das Ergebnis vieler Änderungen, und man weiß nicht genau, welcher den Fehler verursacht hat.

</details>
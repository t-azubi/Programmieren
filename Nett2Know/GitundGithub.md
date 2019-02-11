# Was ist Git und Github

## Git

Git ist ein System zur Versionsverwaltung in Entwicklungsprojekten (wie beispielsweise [TFVC](https://en.wikipedia.org/wiki/Team_Foundation_Server#Team_Foundation_Version_Control), [CVS](https://de.wikipedia.org/wiki/Concurrent_Versions_System) oder [SVN](https://de.wikipedia.org/wiki/Apache_Subversion)). <br>
Git kann man entweder auf einem eigenen Server selbst installieren oder alternativ bei einem Hoster anmieten.
GitHub ist ein solcher webbasierter Hosting-Dienst zum Hosting der Git-Repositories und hat mittlerweile einen hohen Bekanntheisgrad. 


## Github

Der Service GitHub ist mit den meisten Funktionen kostenfrei, wenn man seine Repositories öffentlich lesbar erstellt.  
Deswegen wird es gerne von Leuten und Open Source Projekten genutzt, die Teile oder komplette Projekte öffentlich verwalten möchten. 
Sobald man private Repositories erstellen will, muss man auf das kostenpflichtige Angebot von GitHub zurück greifen. 
Das macht vor allem dann Sinn, wenn man plant Kundendaten oder andere, sensible eigene Daten zu verwalten. <br>

# Wie benutze ich Git/Github

Als aller erstes um Git benutzten zu können, musst du [hier](https://github.com/git-for-windows/git/releases/download/v2.20.1.windows.1/Git-2.20.1-64-bit.exe) dir GitBash installieren. <br>
Ich empfehle Git aus der Powershell zu benutzen, da diese dir auch die möglichkeit gibt das [dotNet SDK](https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.103-windows-x64-installer) zu benutzen. <br>
Hast du nun GitBash installiert, hast du zwei Möglichkeiten dir ein Repo zu erstellen. <br>

Nummer eins : Du navigierst deine Powershell zu dem Ordner, in welchem du das Projekt starten möchtest und verwendest folgenden Befehl ```git init```  vgl. [hier](https://git-scm.com/book/en/v2/Git-Basics-Getting-a-Git-Repository) <br>

Nummer zwei : Du erstellst in Github ein neues Repository, so fern du bereits ein Github Account hast. Nun Clonst du dir das Repository an den Ort, wo dein Projektordner sein soll. ```git clone <url>``` vgl. [hier](https://git-scm.com/book/en/v2/Git-Basics-Getting-a-Git-Repository) <br>

Habt ihr nun etwas in eurem Projekt getan, solltet ihr ein ```git commit -am "<commitnachricht>"``` durchführen, gefolgt von einem ```git push``` damit eure Daten nicht verloren gehen können.
<br>
Hast du in Github etwas bearbeitet, wirds du schnell feststellen, das dein Push nicht funktioniert. Entweder du führst nun einen ```git pull``` oder einen ```git fetch``` aus. <br>
```git pull``` zieht sich, wie eben der Befehl auch heißt die aktuelle Version des Branches von Github. <br>
```git fetch``` läd sich alle(! Daten aus Deinem Repository herunter, jeden Branch und jeden Verweis. <br> 
Habt ihr eine Idee, seid euch aber nicht sicher das dies Funktioniert, könnt ihr ein ```git checkout -b <newbranchname>``` machen und erzeugt eine exakte Kopie von dem Branch auf dem ihr euch gerade befunden habt. <br>
Auf dieser Kopie könnt ihr nun eure Idee ausprobieren, ohne das der eigentliche Code "gefährdet" wird. <br>
Wollt ihr nun die beiden Versionen zusammen bringen, könnt ihr das via Powershell oder Github machen. <br>

# Branching

Die Branching-Funktion ist eine Funktion, die in den meisten modernen Versionskontrollsystemen verfügbar ist. Die Verzweigung in andere VCS kann sowohl in zeitlicher als auch in räumlicher Hinsicht eine teure Angelegenheit sein. In Git sind Niederlassungen Teil Ihres täglichen Entwicklungsprozesses. Git-Zweige sind effektiv ein Zeiger auf eine Momentaufnahme Ihrer Änderungen. Wenn du eine neue Funktion hinzufügen oder einen Fehler beheben möchtest - egal wie groß oder klein -, erstellst du einen neuen Zweig, um deine Änderungen zu kapseln. Dies erschwert die Zusammenführung von instabilem Code in die Hauptcodebasis und gibt Ihnen die Möglichkeit, die Historie Ihrer Zukunft zu bereinigen, bevor der Code in den Hauptzweig zusammengeführt wird.

 Durch die Entwicklung in Branches ist es nicht nur möglich, an beiden parallel zu arbeiten, sondern auch den Haupt-master-branch frei von fragwürdigem Code zu halten.

Die Implementierung hinter den Branchen von Git ist wesentlich leichter als bei anderen Modellen von Versionskontrollsystemen. Anstatt Dateien von Verzeichnis zu Verzeichnis zu kopieren, speichert Git einen Zweig als Referenz auf eine Übertragung. In diesem Sinne stellt ein Zweig die Spitze einer Reihe von Commits dar - er ist kein Container für Commits. Die Historie für einen Zweig wird über die Commit-Beziehungen hochgerechnet.

![Branching](https://i.imgur.com/YG8In8X.png "Branching")

Wie du siehst, denk daran, dass Git-Zweige nicht wie SVN-Zweige sind. Während SVN-Zweige nur zur Erfassung des gelegentlichen großen Entwicklungsaufwands verwendet werden, sind Git-Zweige ein integraler Bestandteil Ihres täglichen Workflows.

## Arbeiten mit Branches

Ein Branch stellt eine eigenständige Entwicklungslinie dar. Branches dienen als Abstraktion für den Bearbeitungs-, Stufen- und Commit-Prozess. Du kannst dir diese als eine Möglichkeit vorstellen, ein brandneues Arbeitsverzeichnis, einen Staging-Bereich und eine Projekthistorie anzufordern. Neue Commits werden in der Historie für den aktuellen Branch aufgezeichnet, was zu einem Fork in der Historie des Projekts führt.

Mit dem Befehl git branch können Sie Zweige erstellen, auflisten, umbenennen und löschen. Sie können nicht zwischen den Zweigen wechseln oder eine gespaltene Historie wieder zusammensetzen. Aus diesem Grund ist ```git branch``` eng mit den Befehlen ```git checkout``` und ```git merge``` verknüpft.

## Workflows

Workflow bedeutet Arbeitsablauf. Er legt unter anderem fest, wer was bis wann erledigen muss, damit der Prozess abgeschlossen werden kann. Zudem wird festgelegt, wo wer was ablegen muss, damit alle am Workflow Beteiligten Zugriff auf die benötigten Dokumente haben. Wie zuvor schon beschrieben bedeutet Workflow auch festzulegen, welche Arbeitsschritte überhaupt durchgeführt werden müssen und in welcher Reihenfolge. Er definiert auch Abhängigkeiten, um Fehler und Engstellen zu erkennen und optimieren zu können.
Ein solcher Arbeitsablauf beschreibt also, wann, wie und wer mit welchen technischen Hilfsmitteln den entsprechenden Geschäftsprozess ausführt.

Was heißt Workflow auf Deutsch?
Der Begriff Workflow ist im Duden eingetragen. Das englische Wort setzt sich aus work = Arbeit und flow = Fluss; das Fließen zusammen. Es kann demnach als Arbeitsablauf/Arbeitsfluss ins Deutsche übersetzt werden. Laut Duden existieren für den Begriff Workflow im Deutschen zwei Bedeutungen:

In der Fachsprache beschreibt Workflow die Abwicklung arbeitsteiliger Vorgänge bzw. Geschäftsprozesse in Unternehmen und Behörden mit dem Ziel größtmöglicher Effizienz
Im Bereich EDV beschreibt Workflow den Arbeitsablauf von Computerprogrammen

<details>
  <summary>Der Featurebranch Flow</summary>

Die Grundidee hinter dem Feature Branch Workflow ist, dass die gesamte Feature-Entwicklung in einem eigenen Branch und nicht im Master Branch stattfinden sollte. Diese Kapselung macht es für mehrere Entwickler einfach, an einem bestimmten Feature zu arbeiten, ohne die Hauptcodebasis zu stören. Es bedeutet auch, dass der Master-Branch niemals beschädigten Code enthält, was ein großer Vorteil für kontinuierliche Integrationsumgebungen ist.

Die Kapselung der Feature-Entwicklung ermöglicht es auch, Pull-Requests zu nutzen, die eine Möglichkeit darstellen, Diskussionen in einem Branche einzuleiten. Sie geben anderen Entwicklern die Möglichkeit, ein Feature zu signieren, bevor es in das offizielle Projekt integriert wird. Oder, wenn du mitten in einer Komponente festgefahren bist, kannst du eine Pull-Anfrage öffnen und nach Vorschlägen von deinen Kollegen fragen. Der Punkt ist, dass Pull-Requests es Ihrem Team unglaublich einfach machen, die Arbeit des anderen zu kommentieren.

Der Git Feature Branch Workflow ist ein komponierbarer Workflow, der von anderen hochrangigen Git-Workflows genutzt werden kann. Der Git Feature Branch Workflow ist modellorientiert, d.h. er ist ein Orientierungsrahmen für die Verwaltung und Erstellung von Branches . Andere Workflows sind stärker auf Repositories ausgerichtet. Der Git Feature Branch Workflow kann in andere Workflows integriert werden.

Der Feature Branch Workflow geht von einem zentralen Repository aus, und der Master repräsentiert die offizielle Projekthistorie. Anstatt sich direkt auf ihren lokalen Master-Branch festzulegen, erstellen Entwickler jedes Mal, wenn man mit der Arbeit an einem neuen Feature beginnt, einen neuen Branch. Feature-Branchen sollten beschreibende Namen haben, wie z.B. animierte Menüpunkte oder Issue-#1061. Die Idee ist es, jedem Branch einen klaren, stark fokussierten Zweck zu geben. Git unterscheidet technisch nicht zwischen dem Master-Branch und dem Feature-Branch, so dass Entwickler Änderungen an einem Feature-Branch bearbeiten, inszenieren und übertragen können.

Darüber hinaus können (und sollten) Feature-Branches in das zentrale Repository verschoben werden. Dies ermöglicht es, ein Feature mit anderen Entwicklern zu teilen, ohne einen offiziellen Code zu berühren. Da Master der einzige "spezielle" Branch ist, ist das Speichern mehrerer Feature-Branches auf dem zentralen Repository kein Problem. Natürlich ist dies auch eine bequeme Möglichkeit, die lokalen Verpflichtungen aller Beteiligten zu sichern.
</details>

<details>
  <summary>Der Gitflow</summary>

Gitflow Workflow ist ein Git-Workflow-Design, das erstmals veröffentlicht und von Vincent Driessen auf der nvie bekannt gemacht wurde. Der Gitflow Workflow definiert ein strenges Verzweigungsmodell, das auf die Projektfreigabe ausgerichtet ist. Dies bietet einen robusten Rahmen für die Verwaltung größerer Projekte.  

Gitflow eignet sich ideal für Projekte, die einen geplanten Release-Zyklus haben. Dieser Workflow fügt keine neuen Konzepte oder Befehle hinzu, die über das hinausgehen, was für den Feature Branch Workflow erforderlich ist. Stattdessen weist es sehr spezifische Rollen verschiedenen Branchen zu und definiert, wie und wann sie interagieren sollen. Neben den Feature-Branchen verwendet es einzelne Branches zur Vorbereitung, Pflege und Aufzeichnung von Releases. Natürlich können Sie auch alle Vorteile des Feature Branch Workflow nutzen: Pull-Requests, isolierte Experimente und eine effizientere Zusammenarbeit.

Anstelle eines einzigen Masterzweiges verwendet dieser Workflow zwei Zweige, um die Historie des Projekts aufzuzeichnen. Der Master-Branch speichert die offizielle Release-Historie, und der Development-Branch dient als Integrationsbranch für Features. Es ist auch bequem, alle Commits im Master-Zweig mit einer Versionsnummer zu versehen.

Der erste Schritt besteht darin, den Standard-Master durch einen Entwicklungszweig zu ergänzen. Eine einfache Möglichkeit, dies zu tun, besteht darin, dass ein Entwickler einen leeren Entwicklungszweig lokal erstellt und auf den Server verschiebt:

Dieser Zweig enthält die komplette Historie des Projekts, während der Master eine gekürzte Version enthält. Andere Entwickler sollten nun das zentrale Repository klonen und einen Tracking-Zweig für die Entwicklung erstellen.

Wenn Sie die [git-flow Erweiterungsbibliothek](https://git-scm.com/download/win) verwenden, wird durch die Ausführung von git flow init auf einem bestehenden Repo der Entwicklungszweig erstellt.
</details>

# Mergen vs. Rebasen

## Was ist Git Merge?

Git Merge kombiniert mehrere Sequenzen von Commits zu einer einheitlichen Historie. In den häufigsten Anwendungsfällen wird ```git merge``` verwendet, um zwei Zweige zu kombinieren. In diesen Szenarien nimmt ```git merge``` zwei Commit-Pointer, normalerweise die Branch-Tipps, und findet einen gemeinsamen Basis-Commit zwischen ihnen. Sobald Git einen Common Base Commit (der letzte Commit den beide branches gemeinsam haben) findet, erstellt es einen neuen "Merge Commit", der die Änderungen jeder in der Warteschlange stehenden Merge Commit-Sequenz kombiniert.

Angenommen, wir haben eine neue Branch-Funktion, die auf dem Master-Branch basiert. Wir wollen nun diesen Feature-Branch in den Master einbinden.

Der Aufruf dieses Befehls führt die angegebene Verzweigungsfunktion mit dem aktuellen Zweig zusammen, wir gehen davon aus, dass es sich um einen Master handelt. Git bestimmt den Zusammenführungsalgorithmus automatisch.

Merge Commits sind einzigartig gegenüber anderen Commits, da sie zwei übergeordnete Commits haben. Beim Erstellen eines Merge-Commits versucht Git, die einzelnen Historien für duautomatisch magisch zusammenzuführen. Wenn Git auf ein Datenstück trifft, das in beiden Historien geändert wird, kann es diese nicht automatisch kombinieren. Dieses Szenario ist ein Versionskontrollkonflikt und Git benötigt Benutzereingriffe, um fortzufahren. Mehr dazu findest du hier [hier](https://www.atlassian.com/git/tutorials/using-branches/git-merge).

## Was ist Rebasen?

Rebasing ist der Prozess des Verschiebens oder Kombinierens einer Sequenz von Commits auf einen neuen Basis-Commit. Das Rebasing ist am nützlichsten und lässt sich im Rahmen eines Feature Branching Workflows leicht visualisieren.

Aus inhaltlicher Sicht verändert Rebasing die Basis Ihres Zweiges von einem Commit zum anderen und lässt ihn so aussehen, als hätten duIhren Zweig aus einem anderen Commit erstellt. Intern erreicht Git dies, indem es neue Commits erstellt und diese auf die angegebene Basis anwendet. Es ist sehr wichtig zu verstehen, dass der Zweig zwar gleich aussieht, aber aus völlig neuen Commits besteht.
Mehr dazu findest du hier [hier](https://www.atlassian.com/git/tutorials/rewriting-history/git-rebase).

## Merge vs Rebase
Rebasing und Merging sind beide darauf ausgerichtet, Änderungen von einer Branch in eine andere Branch zu integrieren, allerdings auf unterschiedliche Weise.

Nehmen wir an, wir haben Commits wie unten beschrieben, der Merge ergibt sich als eine Kombination von Commits, während Rebase alle Änderungen im Feature-Zweig ab dem letzten Commit des Master-Zweigs hinzufügt:

![alt text](https://cdn-images-1.medium.com/max/800/1*pzT4KMiZDOFsMOKH-cJjfQ.png "Merge vs. Rebase")

Wenn der Feature-Branch, von dem du Änderungen erhälst, mit anderen Entwicklern geteilt wird, wird ein Rebase nicht empfohlen, da der Rebaseprozess inkonsistente Repositories erzeugt. Das heißt, dass im Ende im dümmsten Fall jeder Entwickler eine andere Historie hat und somit das zusammenarbeit nahe zu unmöglich wird. Für den Einzelnen macht das Rebasieren viel Sinn, da diesem somit die Möglichkeit gegeben wird seine eigene Historie zu ordnen.

Wenn du die Historie vollständig wie bisher sehen möchten, solltest du einen Merge verwenden. Merge bewahrt die Historie, während Rebase sie neu schreibt.

Rebasing ist besser, um eine komplexe Historie zu rationalisieren, du kannst die Commit-Historie durch interaktive Rebase ändern. Damit kannst du unerwünschte Commits entfernen, zwei oder mehr Commits in einen zusammenfassen oder die Commit-Nachricht bearbeiten.

Rebase präsentiert Konflikte, die einzeln übertragen werden, während Merge sie alle auf einmal präsentiert. Es ist besser und viel einfacher, die Konflikte zu handhaben, aber du solltest nicht vergessen, dass die Wiederherstellung einer Datenbank viel schwieriger ist als die Wiederherstellung einer Zusammenführung, wenn es viele Konflikte gibt.

## Mergen mit Powershell

Dazu wechseltst du mit ```git checkout <branch>```zu dem Branch, in welchen ein anderer hinein gemerged werden soll. <br>
Hast du das gemacht, kannst du  ```git merge <branch>``` deinen anderen Branch in den Branch auf welchem du dich befindest hinein mergen. <br>
War der Merge erfolgreich kannst du nun den "Fixbranch" löschen. Das geht über ```git branch -d <Fixbranch>```   vgl. [hier](https://git-scm.com/book/en/v2/Git-Branching-Basic-Branching-and-Merging) <br>

## Rebasing

Mit der rebase-Anweisung kannst Du alle Änderungen, die an einem Branch vorgenommen wurden, auf einen anderen Branch erneut anwenden. <br>

Dazu wechseltst du mit ```git checkout <branch>```zu dem Branch, auf welchem du dein Fix oder dein Experiment durchgeführt hast. <br>
Hast du das gemacht, kannst du nun ```git rebase <branch>``` machen. Denk daran die Änderung die du auf deinem Fixbranch gemacht hast, werden nun in den letzen Commit deines Zielbranches übernommen, ohne einen Neuen Commit zu machen vgl. [hier](https://git-scm.com/book/de/v1/Git-Branching-Rebasing)


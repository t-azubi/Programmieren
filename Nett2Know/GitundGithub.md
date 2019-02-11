# Was ist Git und Github

## Git

Git ist ein System zur Versionsverwaltung in Entwicklungsprojekten (wie beispielsweise CVS oder SVN). <br>
Git kann man entweder auf einem eigenen Server selbst installieren oder alternativ bei einem Hoster anmieten.
GitHub ist ein solcher webbasierter Hosting-Dienst zum Hosting der Git-Repositories und hat mittlerweile einen hohen Bekanntheisgrad. 


## Github

Das Open-Source-Projekt GitHub ist mit den meisten Funktionen kostenfrei, wenn man seine Repositories öffentlich lesbar erstellt.  
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

## Mergen vs. Rebasen

### Was ist Git Merge?

Git Merge kombiniert mehrere Sequenzen von Commits zu einer einheitlichen Historie. In den häufigsten Anwendungsfällen wird ```git merge``` verwendet, um zwei Zweige zu kombinieren. In diesen Szenarien nimmt ```git merge``` zwei Commit-Pointer, normalerweise die Branch-Tipps, und findet einen gemeinsamen Basis-Commit zwischen ihnen. Sobald Git einen Common Base Commit (der letzte Commit den beide branches gemeinsam haben) findet, erstellt es einen neuen "Merge Commit", der die Änderungen jeder in der Warteschlange stehenden Merge Commit-Sequenz kombiniert.

Angenommen, wir haben eine neue Branch-Funktion, die auf dem Master-Branch basiert. Wir wollen nun diesen Feature-Branch in den Master einbinden.

Der Aufruf dieses Befehls führt die angegebene Verzweigungsfunktion mit dem aktuellen Zweig zusammen, wir gehen davon aus, dass es sich um einen Master handelt. Git bestimmt den Zusammenführungsalgorithmus automatisch.

Merge Commits sind einzigartig gegenüber anderen Commits, da sie zwei übergeordnete Commits haben. Beim Erstellen eines Merge-Commits versucht Git, die einzelnen Historien für Sie automatisch magisch zusammenzuführen. Wenn Git auf ein Datenstück trifft, das in beiden Historien geändert wird, kann es diese nicht automatisch kombinieren. Dieses Szenario ist ein Versionskontrollkonflikt und Git benötigt Benutzereingriffe, um fortzufahren. Mehr dazu findest du hier [hier](https://www.atlassian.com/git/tutorials/using-branches/git-merge).

### Was ist Rebasen?

Rebasing ist der Prozess des Verschiebens oder Kombinierens einer Sequenz von Commits auf einen neuen Basis-Commit. Das Rebasing ist am nützlichsten und lässt sich im Rahmen eines Feature Branching Workflows leicht visualisieren.

Aus inhaltlicher Sicht verändert Rebasing die Basis Ihres Zweiges von einem Commit zum anderen und lässt ihn so aussehen, als hätten Sie Ihren Zweig aus einem anderen Commit erstellt. Intern erreicht Git dies, indem es neue Commits erstellt und diese auf die angegebene Basis anwendet. Es ist sehr wichtig zu verstehen, dass der Zweig zwar gleich aussieht, aber aus völlig neuen Commits besteht.
Mehr dazu findest du hier [hier](https://www.atlassian.com/git/tutorials/rewriting-history/git-rebase).

## Merge vs Rebase



## Mergen mit Powershell

Dazu wechseltst du mit ```git checkout <branch>```zu dem Branch, in welchen ein anderer hinein gemerged werden soll. <br>
Hast du das gemacht, kannst du  ```git merge <branch>``` deinen anderen Branch in den Branch auf welchem du dich befindest hinein mergen. <br>
War der Merge erfolgreich kannst du nun den "Fixbranch" löschen. Das geht über ```git branch -d <Fixbranch>```   vgl. [hier](https://git-scm.com/book/en/v2/Git-Branching-Basic-Branching-and-Merging) <br>

## Rebasing

Mit der rebase-Anweisung kannst Du alle Änderungen, die an einem Branch vorgenommen wurden, auf einen anderen Branch erneut anwenden. <br>

Dazu wechseltst du mit ```git checkout <branch>```zu dem Branch, auf welchem du dein Fix oder dein Experiment durchgeführt hast. <br>
Hast du das gemacht, kannst du nun ```git rebase <branch>``` machen. Denk daran die Änderung die du auf deinem Fixbranch gemacht hast, werden nun in den letzen Commit deines Zielbranches übernommen, ohne einen Neuen Commit zu machen vgl. [hier](https://git-scm.com/book/de/v1/Git-Branching-Rebasing)
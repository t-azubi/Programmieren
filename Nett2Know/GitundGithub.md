# Was ist Git und Github

## Git

Git ist ein System zur Versionsverwaltung in Entwicklungsprojekten (wie beispielsweise CVS oder SVN). <br>
Git kann man entweder auf einem eigenen Server selbst installieren oder alternativ bei einem Hoster anmieten. <br>
GitHub ist ein solcher webbasierter Hosting-Dienst zum Hosting der Git-Repositories und hat mittlerweile einen hohen Bekanntheisgrad. <br>

## Github

Das Open-Source-Projekt GitHub ist mit den meisten Funktionen kostenfrei, wenn man seine Repositories öffentlich lesbar erstellt. <br> 
Deswegen wird es gerne von Leuten und Open Source Projekten genutzt, die Teile oder komplette Projekte öffentlich verwalten möchten. <br>
Sobald man private Repositories erstellen will, muss man auf das kostenpflichtige Angebot von GitHub zurück greifen. <br> 
Das macht vor allem dann Sinn, wenn man plant Kundendaten oder andere, sensible eigene Daten zu verwalten. <br>

# Wie benutze ich Git/Github

Als aller erstes um Git benutzten zu können musst du [hier](https://github.com/git-for-windows/git/releases/download/v2.20.1.windows.1/Git-2.20.1-64-bit.exe) dir GitBash installieren. <br>
Ich empfehle Git aus der Powershell zu benutzen, da diese dir auch die möglichkeit gibt das [dotNet SDK](https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.103-windows-x64-installer) zu benutzen. <br>
Hast du nun GitBash installiert, hast du zwei Möglichkeiten dir ein Repo zu erstellen. <br>
Nummer eins : Du navigierst deine Powershell zu dem Ordner, in welchem du das Projekt starten möchtest und verwendest folgenden Befehl ```git init```  vgl. [hier](https://git-scm.com/book/en/v2/Git-Basics-Getting-a-Git-Repository) <br>
Nummer zwei : Du erstellst in Github ein neues Repository, so fern du bereits ein Github Account hast. Nun Clonst du dir das Repository an den Ort, wo dein Projektordner sein soll. ```git clone <url>``` vgl. [hier](https://git-scm.com/book/en/v2/Git-Basics-Getting-a-Git-Repository) <br>
<br>
<br>
Habt ihr nun etwas in eurem Projekt getan, solltet ihr ein ```git commit -am "<commitnachricht>"``` durchführen, gefolgt von einem ```git push``` damit eure Daten nicht verloren gehen können.
<br>
Hast du in Github etwas bearbeitet, wirds du schnell feststellen, das dein Push nicht funktioniert. Entweder du führst nun einen ```git pull```oder einen ```git fetch```aus. <br>
```git pull``` zieht sich, wie eben der Befehl auch heißt die aktuelle Version des Branches von Github. <br>
```git fetch``` läd sich alle(! Daten aus Deinem Repository herunter, jeden Branch und jeden Verweis. <br> 
Habt ihr eine Idee, seid euch aber nicht sicher das dies Funktioniert, könnt ihr ein ```git checkout -b <newbranchname>```machen und erzeugt eine exakte Kopie von dem Branch auf dem ihr euch gerade befunden habt. <br>
Auf dieser Kopie könnt ihr nun eure Idee ausprobieren, ohne das der eigentliche Code "gefährdet" wird. <br>
Wollt ihr nun die beiden Versionen zusammen bringen, könnt ihr das via Powershell oder Github machen. <br>

## Mergen mit Powershell

Dazu wechseltst du mit ```git checkout <branch>```zu dem Branch, in welchen ein anderer hinein gemerged werden soll. <br>
Hast du das gemacht, kannst du  ```git merge <branch>``` deinen anderen Branch in den Branch auf welchem du dich befindest hinein mergen. <br>
War der Merge erfolgreich kannst du nun den "Fixbranch" löschen. Das geht über ```git branch -d <Fixbranch>```   vgl. [hier](https://git-scm.com/book/en/v2/Git-Branching-Basic-Branching-and-Merging) <br>

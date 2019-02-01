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
Nummer eins : Du navigierst deine Powershell zu dem Ordner, in welchem du das Projekt starten möchtest und verwendest folgenden Befehl ```git init``  vgl. [hier](https://git-scm.com/book/en/v2/Git-Basics-Getting-a-Git-Repository) <br>
Nummer zwei : Du erstellst in Github ein neues Repository, so fern du bereits ein Github Account hast. Nun Clonst du dir das Repository an den Ort, wo dein Projektordner sein soll. ```git clone <url>``` vgl. [hier](https://git-scm.com/book/en/v2/Git-Basics-Getting-a-Git-Repository) <br>
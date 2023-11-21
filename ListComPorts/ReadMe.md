# ListComPorts

## Sinn und Unsinn

Schlie�t man ein neues USB-Ger�t, das sich als COM-Port zu erkennen gibt, an einen Windows-Rechner an, so ordnet Windows diesem Ger�t die erste noch freie COM-Port-Nummer zu. Windows reserviert die COM-Port-Nummer auf ewig f�r dieses eine Ger�t, sie steht somit anderen Ger�ten nicht mehr zur Verf�gung. Die Resevierung bleibt auch erhalten, wenn das Ger�t l�ngst wieder entfernt wurde. Schlie�t man gar ein Ger�t ohne USB-Seriennummer an, wird bei jedem Anstecken an einen anderen USB-Port eine weitere COM-Port-Nummer belegt.

Welche COM-Port-Nummer ein neu angestecktes Ger�t erhalten hat, sieht man nicht ohne Weiteres. Man muss im Ger�te-Manager m�hsam danach suchen. Mit **ListComPorts** spart man hier viele Mausklicks (und Nerven).


## Benutzung

Nach dem Start listet **ListComPorts** alle aktuell am Rechner sichtbaren COM-Ports in einer ListBox auf (der Name lie� das vermuten). Das zuletzt angesteckte Ger�t ist in der Regel der unterste Eintrag. Mit einem Doppelklick auf einen Eintrag wird PuTTY mit den gew�hlten Parametern gestartet und lauscht an diesem COM-Port.


## Installation

**ListComPorts** ist portabel. Einfach entpacken, z.B. nach C:\\Programme\\... bzw. unter Windows 7 besser nach C:\\Tools\\..., um Probleme mit dem _Windows Virtual Store_ zu vermeiden. Wer will, kann sich eine Verkn�pfung zur EXE-Datei anlegen.

Das Programm wird ohne Parameter gestartet und braucht keine Admin-Rechte.

Ach ja, mindestens die .NET 3.5 Laufzeitumgebung wird ben�tigt.


## Konfiguration

Um PuTTY starten zu k�nnen, muss **ListComPorts** wissen, wo die PuTTY.exe liegt. Es sucht nicht selber, der Pfad wird in der Konfigurationsdatei hinterlegt.

Dort befinden sich auch die Port-Parameter, mit denen PuTTY aufgerufen wird. Komfortabel l�sst sich das alles per Konfigurationsdialog einstellen.


## Lizenz

ListComPorts ist Freeware.

## Links

PuTTY gibt es [hier](http://www.chiark.greenend.org.uk/~sgtatham/putty/ "PuTTY: a free SSH and Telnet client") und eine portable Version davon [hier](http://jakub.kotrla.net/putty "Portable PuTTY with file config").

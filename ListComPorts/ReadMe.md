# ListComPorts

## Sinn und Unsinn

Schließt man ein neues USB-Gerät, das sich als COM-Port zu erkennen gibt, an einen Windows-Rechner an, so ordnet Windows diesem Gerät die erste noch freie COM-Port-Nummer zu. Windows reserviert die COM-Port-Nummer auf ewig für dieses eine Gerät, sie steht somit anderen Geräten nicht mehr zur Verfügung. Die Resevierung bleibt auch erhalten, wenn das Gerät längst wieder entfernt wurde. Schließt man gar ein Gerät ohne USB-Seriennummer an, wird bei jedem Anstecken an einen anderen USB-Port eine weitere COM-Port-Nummer belegt.

Welche COM-Port-Nummer ein neu angestecktes Gerät erhalten hat, sieht man nicht ohne Weiteres. Man muss im Geräte-Manager mühsam danach suchen. Mit **ListComPorts** spart man hier viele Mausklicks (und Nerven).


## Benutzung

Nach dem Start listet **ListComPorts** alle aktuell am Rechner sichtbaren COM-Ports in einer ListBox auf (der Name ließ das vermuten). Das zuletzt angesteckte Gerät ist in der Regel der unterste Eintrag. Mit einem Doppelklick auf einen Eintrag wird PuTTY mit den gewählten Parametern gestartet und lauscht an diesem COM-Port.


## Installation

**ListComPorts** ist portabel. Einfach entpacken, z.B. nach C:\\Programme\\... bzw. unter Windows 7 besser nach C:\\Tools\\..., um Probleme mit dem _Windows Virtual Store_ zu vermeiden. Wer will, kann sich eine Verknüpfung zur EXE-Datei anlegen.

Das Programm wird ohne Parameter gestartet und braucht keine Admin-Rechte.

Ach ja, mindestens die .NET 3.5 Laufzeitumgebung wird benötigt.


## Konfiguration

Um PuTTY starten zu können, muss **ListComPorts** wissen, wo die PuTTY.exe liegt. Es sucht nicht selber, der Pfad wird in der Konfigurationsdatei hinterlegt.

Dort befinden sich auch die Port-Parameter, mit denen PuTTY aufgerufen wird. Komfortabel lässt sich das alles per Konfigurationsdialog einstellen.


## Lizenz

ListComPorts ist Freeware.

## Links

PuTTY gibt es [hier](http://www.chiark.greenend.org.uk/~sgtatham/putty/ "PuTTY: a free SSH and Telnet client") und eine portable Version davon [hier](http://jakub.kotrla.net/putty "Portable PuTTY with file config").

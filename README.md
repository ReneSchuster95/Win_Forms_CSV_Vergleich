# Win Forms CSV Vergleich

Ein einfaches Windows Forms-Werkzeug zum Vergleichen zweier CSV-Dateien. Entwickelt in C# (.NET Framework), hilft es dabei, neue und geänderte Datensätze zwischen zwei CSV-Dateien zu identifizieren und zu exportieren.

# ⚙️ Features

- Einfache grafische Benutzeroberfläche (WinForms).
- Datei-Auswahl über Dialog (CSV1, CSV2).
- Vergleich der CSV-Daten anhand einer ID und Bezeichnung.
  - Geänderte Einträge: gleiche ID, unterschiedliche Bezeichnung
  - Neue Einträge: ID in CSV1, aber nicht in CSV2
- Anzeige:
  - Neue Datensätze
  - Geänderte Datensätze
- Export-Funktion:
  - "Neu" CSV
  - "Geändert" CSV

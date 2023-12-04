**Projektanalyse Online**

Die Auswirkungen eines Projekts auf Umwelt, Wirtschaft und Gesellschaft mithilfe der vorhanden Excel Sheets zu erfassen ist ein langwieriger und unübersichtlicher Prozess. Mit der Projektanalyse Online versuche ich Abhilfe zu schaffen.

**Die Lösung**

Die Nutzer\*innen werden schrittweise durch den Projektanalyse Prozess gelotst. Ein intuitives und ansprechendes UI soll dies so angenehm wie möglich machen. Im ersten Schritt werden den Nutzer\*innen Handlungsgrundsätze präsentiert. Die Idee ist, dass sie diese auf den nächsten Schritten im Hinterkopf behalten. Anhand von je 6 Fragen werden nun die Auswirkungen des Projekts auf die Wirtschaft, Umwelt und Gesellschaft erfasst. Ein Balkendiagramm zeigt die Auswirkungen. Wird eine Analyse vorerst abgeschlossen, erscheint sie im Suchfenster. Durch ein Anklicken öffnet sich das Kanban Board. Die Idee dabei ist, dass Themenpunkte auch zu einem späteren Zeitpunkt im Projekt nochmals neu beurteilt werden können. Um diese Änderungen nachvollziehbar zu machen, ist aber eine Begründung nötig. Der Verlauf von Neubeurteilungen per Themenschwerpunkt kann durch anklicken auf das Kanban Board eingesehen werden.

**Learnings**

Während dem Hack habe mich intensiv mit UI Design und Entwicklung auseinandergesetzt. Ich nutzte Tailwind.css und lernte viele neue Utility Classes kennen.

**Technologie**

Das Frontend ist mit Blazor und Tailwind programmiert, das Backend mit ASP.NET Core. Es wird auf Azure gehosted.

**Video**
[Link](https://youtu.be/sQxEIZh0DPU)

**Link**
https://projektanalyseonline.azurewebsites.net/

**Bilder**

Landing Screen mit Suchfenster zum browsen von bestehenden Analysen
<img src="https://raw.githubusercontent.com/DavidEggenberger/ProjektAnalyseOnline/master/Pic1.png"/>

Ausschnitt aus Analyse Prozess: Die Balken am oberen Ende der Seite zeigen die Position im Analyse Prozess. Die Beantwortung der Fragen funktioniert durch die Slider.
<img src="https://raw.githubusercontent.com/DavidEggenberger/ProjektAnalyseOnline/master/Pic2.png"/>

Kanban Board mit Übersicht über die Einteilung der jeweiligen Themenschwerpunkte. Die Einteilung der Themenschwerpunkte basiert auf der Beantwortung der Fragen bei der Projektanalyse. Per Drag&Drop können Updates vorgenommen werden. Die Eingabe eines Grundes für die Beurteilung hilft späteren Besuchern beim besseren Verständnis.
<img src="https://raw.githubusercontent.com/DavidEggenberger/ProjektAnalyseOnline/master/Pic3.png"/>

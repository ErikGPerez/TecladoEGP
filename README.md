# TecladoEGP - WPF - Pt4a - M07

EJERICICO 1 - APARTADO A
------------------------
Fes que funcioni aquest teclat en WPF amb el codi més eficient que puguis fer.
El que hi ha al costat dret de la tecla “ESC” seria un control de texte. Segons que cliquem a les tecles de
lletres/números/… veurem escrit el que fiquem aquí dins. És de només lectura.
La tecla “.?123” té doble funcionalitat: ampliar/no ampliar el teclat amb signes de puntuació i números. Si la
cliquem estén, si li tornem a clicar ens retorna a l’estat anterior.
Les tecles de “Ctrl” i “Alt” no fan res.

EJERICICO 1 - APARTADO B
------------------------
El control gran que veus a mà esquerra i que està desplegat es diu treeView.
Heu de carregar-lo amb alguns ítems des del codi.
NO CAL PROGRAMAR RES

EJERICICO 2 - APARTADO A
------------------------
Fes que el joc fet a WF sigui de WPF.

EJERICICO 2 - APARTADO B
------------------------
Al joc de les parelles afegeix-li els següents canvis:
i.(1.5 punts) Afegeix un temporitzador de joc que mesuri el temps que necessita el jugador per a guanyar.
Fes que si excedeix un temps establert per tu (per exemple, 5 minuts), s’aturi el joc i surti un missatge
conforme ha perdut.
ii. (1.5 punts) Per dificultar encara més el joc, oculta la primera icona si el jugador és massa lent en
reaccionar i no escull una segona icona abans que passi una quantitat de temps correcte (establert també
per tu)

EJERICICO 3 - APARTADO A
------------------------
Fes que el joc fet a WF sigui de WPF.

EJERICICO 3 - APARTADO B
------------------------
i. (0.5 punts) Juga amb els temps dels temporitzadors (timers) que venen per defecte. Fes que l’aplicació
vagi més ràpida o més lenta.
ii. (0.5 punts) Deixa que l’usuari pugui escollir en iniciar el joc entre les dues marmotes a clicar i no només
una com fins ara. Fes-ho de diferents maneres: amb un control de tipus RadioButton, amb un control de
tipus ListBox i amb un control de tipus ComboBox.
iii. (1 punt) Fes un menú que em deixi Sortir, Seleccionar Marmota i Temps.
→ Si escullo Sortir, tanca l’aplicació
→ Si escullo Seleccionar Marmota, ens desplega dos submenús: un submenú dirà «Jugar amb una
marmota», un altre submenú «Jugar amb 2 marmotes». En aquest darrer cas apareixerà els controls
creats a l’apartat anterior (el ii) i que estaran ocults en iniciar el joc o si cliquem a «Jugar amb una
marmota»
→ Si escullo Temps, ens obre una segona finestra que té un control numèric per pujar o baixar el temps de
30 en 30 segons. Quan el fem servir i cliquem a un botó de nom «Tancar», es tancarà aquesta finestra i es
veurà com afecta aquesta manipulació del temps en el meu joc.
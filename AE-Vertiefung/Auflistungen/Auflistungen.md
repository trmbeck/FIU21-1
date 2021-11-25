# Auflistungen (Collections)

+ Elemente k�nnen flexibler hinzugef�gt und entfernt werden als bei Arrays
+ Es muss nicht die Gr��e (Anzahl Elemente) vorher festlegen
+ F�r viele Operationen wird kein Index ben�tigt

Beispiele: ListBox, ComboBox, ListView, TreeView

## ArrayList

Auflistung welche Elemente vom Typ object aufnimmt

### Eigenschaften und Methoden von ArrayList
+ `Count`: Anzahl der Listenelemente
+ `Capacity`: Kapazit�t der Liste
+ `Add()`: F�gt der Liste ein neues Element hinzu (am Ende)
+ `Remove()`: Entfernt ein Element aus der Liste
+ `RemoveAt()`Entfernt ein Element aus der Liste mit angegebenem Index

## Warteschlange (Queue)
+ Arbeitet nach dem FIFO-Prinzip (**F**irst **I**n **F**irst **O**ut)
+ Neue Elemente k�nnen nur am Ende hinzugef�gt werden
+ Entfernen von Elementen erfolgt immer am Anfang der Warteschlange

![Queue](../Bilder/Queue.png)

### Eigenschaften und Methoden von Queue
+ `Count`: Anzahl der Listenelemente
+ `Enqueue()`: Hinzuf�gen eines Elements
+ `Dequeue()`: Entfernen eines Elements

## Stapel (Stack)
+ Arbeitet nach dem LIFO-Prinzip (**L**ast **I**n **F**irst **O**ut)
+ Neue Elemente werden immer oben auf dem Stapel abgelegt und auf wieder entnommen
+ Elemente werden dadurch in der Reihenfolge umgekehrt

![Stack](../Bilder/Stack.png)

### Eigenschaften und Methoden von Stack
+ `Count`: Anzahl der Listenelemente
+ `Push()`: Legt ein Element auf den Stapel
+ `Pop()`: Entfernt das oberste Element des Stapels

## Hash-Tabelle (Hashtable)
+ Elemente werden mit Hilfe eines Schl�ssel gespeichert und abgerufen
+  Der Schl�ssel kann von beliebigem Datentyp sein ("Hallo", 123)
+  Hashcode selbst ist ein Integerwert
+  Es k�nnen Kollisionen auftreten
+  
![Hashtable](../Bilder/Hashtable.png)

### Eigenschaften und Methoden von Hashtable
+ `Count`: Anzahl der Listenelemente
+ `Add`: F�gt Element mit Hilfe eines Schl�ssels hinzu
+ `GetHashCode`: ermittelt Hashcode
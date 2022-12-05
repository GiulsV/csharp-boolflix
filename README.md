# csharp-boolflix


05/12/22

Obbiettivi principali dell’esercitazione finale:
realizzare tutte le funzionalità presenti in home page riguardante lo scenario di “sfoglia catalogo” identificato nei nostri casi d’uso. 

In particolare:

	- visualizzazione del catalogo
	- menu di navigazione (fate attenzione, analizzate bene!!) tutto tranne le ultime 3 funzioni:
		bambini
		notifiche
		profilo
	- dettaglio del contenuto video (cercando di riportare tutti i dati che servono)
	- riproduzione (fake) del contenuto video (questo ci servirà dopo!)

Algoritmo di presentazione playlist

Abbiamo visto che le playlist in home page vengono generate con diverse strategie, 
implementate almeno 2 strategie utilizzando il pattern Strategy:

	- Playlist “continua a guardare”
	- Playlist “per categoria contenuto” o un alternativa a vostro piacere


Avete libertà totale, a meno dei seguenti “vincoli” / indicazioni su come procedere:

	- Non siamo troppo interessati alla grafica, fatela uguale oppure diversa ma non perdeteci troppo tempo. 
		Tenetela quindi per ultima. (per esempio nel dettaglio della serie non c’è bisogno che avvenga tramite popup o tramite api)
	- La home page e tutte le interazioni riguardanti i contenuti video (film, serie tv, documentari ..etc) sono tutte azioni pubbliche.
	- Identificate quindi le entità, le relazioni e gli algoritmi aiutandovi con gli schemi a supporto che abbiamo visto che dovranno quindi essere aggiornati o creati in base alle scelte che farete: per esempio il diagramma delle classi o lo schema dei casi d’uso.
	- Create una parte amministrativa protetta da autenticazione per tutte le operazioni CRUD sui controller delle entità che identificate negli step precedenti.
	- Non è necessario usare le API
	- Create almeno un repository per gestire l’accesso al DB.
	- Ricordate di inserire l’injection

Aggiungiamo che, in una situazione reale, durante queste fasi potremmo scegliere di scrivere i casi di test per alcune funzionalità, 
in questa esercitazione è un’attività falcoltativa che potreste eventualmente inserire, se ve la sentite.

-------------------------------------------------------------------------------------------------------

02/12/22

Abbiamo visto UML e un pò di gestione di progetto AGILE. 
Quindi proviamo a “simulare” una fase di analisi prima di iniziare gli sviluppi.

Andate su netflix e analizzate tutto il sito. 
Cercate le interazioni più significative e producete:

	- Il diagramma complessivo dei casi d’uso (almeno 5 o 6 usecase ma potete farne quanti volete): 
	per fare questo dovete navigare in tutto il sito, anche nella sezione di account e scegliere cosa vale la pena rappresentare nel diagramma

	- Dei casi d’uso identificati scegliete quelli che ritenete interessante analizzare per produrre:***
			° un diagramma delle classi (class diagram)
			° un diagramma delle attività (activity diagram)
			° un diagramma di sequenza (sequence diagram)

	***producete 3 diagrammi: uno per ogni funzionalità o anche 3 per una sola funzionalità purchè sia abbastanza corposa.

La consegna: 
	create un nuovo progetto MVC e salvate in una cartella a parte chiamata “analisi” tutti i file prodotti:
		- le immagini dei diagrammi
		- i documenti di testo (è sufficiente un semplice .txt)
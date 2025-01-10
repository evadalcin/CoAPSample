# Applicazione Client-Server CoAP

Questa applicazione implementa un semplice sistema client-server utilizzando il protocollo CoAP (Constrained Application Protocol), ideale per dispositivi con risorse limitate e comunicazioni IoT.

## Descrizione

L'applicazione è composta da due componenti principali:
- Un server CoAP che gestisce richieste GET e POST
- Un client CoAP che può inviare richieste GET e POST al server

## Funzionalità

### Server
- Avvio su porta predefinita 5683
- Gestione di richieste GET con risposta "Hello from CoAP Server"
- Gestione di richieste POST con eco del messaggio ricevuto
- Possibilità di arresto controllato

### Client
- Connessione al server locale o remoto
- Invio di richieste GET
- Invio di richieste POST con payload personalizzato
- Gestione delle risposte del server

## Requisiti di Sistema
- .NET Core Runtime
- Libreria CoAP per .NET

## Utilizzo

1. Avviare l'applicazione:
   ```
   dotnet run
   ```

2. Selezionare la modalità:
   - Digitare `1` per avviare il server
   - Digitare `2` per avviare il client

# Geleerd dag 1

Wat oh wat hebben we geleerd van gister?!

- Delegates
  - Wijst een stukje methode toe aan iets - minimethode inline methode
  - 3 soorten delegates:
    - Action<T> - geen returnwaarde
    - Func<T, bool> - returnwaarde instelbaar
    - Predicates  Predicate<Product>
      - geeft altijd een boolean terug
        public bool Bla(Product x) { }
         if(pred.Invoke(iets))

- Events
  - observer/observable	
  - gooien en distributen/beschikbaar maken voor andere classes
  - kernreactor
  - errorhandling
  - performance-indicatoren
  - diagnostische zaken
  - functionele zaken - filesystemwatcher
  - security - als je merkt dat iemand 5000 keer verkeerd inlogt binnen 2 seconden
  - button click
  - eventhandler:     public delegate void MijnEventHandler(JouwObject sender, JouwEventArgs args);
  - het event zelf:   public event MijnEventHandler MijnEvent;

- Generics
  - class MijnGenericClass<T> {
        doe(T item) { }
    }
  - type-onafhankelijkheid
  - collections vooral
  - dependency injection
  - serializatie  serializer.Doe<MijnDing>(obj);
  - unittesten - mocken  new Mock<ISomeService>();

- Collections
  - IEnumerable<T> wordt 't meest gebruikt
    - lazy evaluation - dat een functie niet altijd van begin tot eind wordt doorlopen
      - yield return
  - rest van minder, maar bevatten steeds meer functionaliteit:
    - ICollection<T>
    - IList<T>
  - datastructuren:
    - array
    - linked list
    - tree
    - dictionary
    - keuze gebaseerd op: sequentieel doorlopen, inserten, inserten op bepaalde plek, zoeken, sorteren => O-notatie
      - O(n)  O(log n) O(n log n)

- Events worden gemarkeerd met een bliksemschichtje
- Delegate == lambda
- Korter == VAAK leesbaarder

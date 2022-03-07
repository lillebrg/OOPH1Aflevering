//1. Hvilket af de 3 kode linjer foroven returnerer en List<Bil>?
// - De alle returnerer en List<Bil> bare på forskellige måder og med forskellige betingelser.

//2. Hvilket af de 3 kode linjer foroven returner en enkelt Bil objekt?
// - Det ville Biler.First da den altid vil tage det første stykke data i listen.

//3. Hvilket af de 3 kode linjer foroven returner nullværdi hvis søge kondition ikke matcher med noget af data i listen?
// - Det ville være Biler.FirstOrDefault da den vil prøve at finde det som brugeren spicifikt leder efter, hvis den ikke finder noget går den til default som er null.

//4. Hvilket af de 3 kode linjer foroven vil CRASH applikationen hvis ingen match funket i søge kondition?
// - Det ville være Biler.Where da vi giver koden nogle ting den skal indeholde, men hvis den ikke finder noget at matche på, vil den crashe.
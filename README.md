# EmitMiniResults
Scoreboard to results read from emit tags

### Emit leimausrata tulospalvelu | Emit chekpoint course results
* Windowspohjainen uwp, c#, Windows 10 | Windows based, written with uwp / C#
* Tietokanta/csv-tiedosto tallennus tuloksille | results saved to csv file (or database like SQLite)
* Emit lukija 250 (USB/Serial) | Emit reader 250 (USB/Serial)
* mtr-dll sarjaporttikäsittelyyn | mtr-dll for communication
* Platform x86 or x64 (ei ARM)

### Ohjelman käynnistys | Startup
* Ohjelma aukeaa päänäkymään, johon myös tulokset tulee. | Main page is the results page
* Ei tallennusnappeja vaan jokainen muutos tallentuu | No saving. All changes are saved immediately

### Päänäkymä | Main page
* Luo uusi | Create a new course
* Hae vanha | Load existing course
* Tuloslistaus (top 5?, top10?, kaikki?) | Result list (top5, top10 all)
* Rastiväliajan mukaan paremmuusjärjestykseen? | Ordered by checkpoint time
* Fullscreen + adaptiivisuus | Fulscreen / scalable to all resolutions

### Valinnat | Menu
* Napilla on mahdollista hakea vanhat tulokset? (Tulevaisuudessa) | Load old results
* Napilla uusi rata. Se luo uuden kisatiedoston (csv tai DB) | Create a new course
* Uuden radan luomisessa pitää syöttää leimasimien numerot järjestyksessä. (csv/DB) | New course: input stamplers id numbers
* Edellisiä pitää voida muuttaa johonkin pisteeseen asti? Entä jos radasta jo tuloksia? | possibility to chage course 

### Kortin lukeminen | Reading an emit card
* Lopputulos/suoritusaika näkyviin | show the result time
* Hyväksytty/Hylätty tieto + värikoodaus ja miksi hylky (tallentuu mutta ei näy tuloksissa) | admitted/abandoned
* Väliajat? | checkpoint times
* Mahdollisuus syöttää kilpailijan nimi | possibility to attach competitors name to the result

### Reread | Reread
* Jos korttia ei voi lukea pitää olla reread nappi, jolla saman kortin voi lukea uudelleen | if reading failed, possibility to reread
* Normaalisti samaa korttia ei voi lukea kahta kertaa peräkkäin | normally there need to be another card to read after failed read

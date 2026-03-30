Zadanie 5: 
ponieważ powstało rozgałęzienie (dwa branche mające różne commity)
fast-forward dzieje się, gdy nowy branch ma wszystko to co 'starszy' i więcej - wystarczy wtedy przekopiować rzeczy z 'nowszego' branchu, w innym wypadku trzeba je ze sobą złączyć z uwzględnieniem zmian w obu
^ jest to tez odpowiedz do punktu pierwszego rzeczy ktore maja sie znalezc w readme

2. Czym w praktyce różni się merge od rebase?
merge łączy dwie gałęzie zachowując całą historię zmian, a rebase ingeruje w historię przenosząc commity na konieć nowej gałęzi. Merge jest bezpieczniejsze za to rebase łatwiejsze w debugowaniu.
3. W moim repozytorium kongflikt dotyczył wprowadzenia nowych reguł w metodzie sprawdzenia poprawności imienia: na gałęzi main metoda miała dopuścić tylko imiona dłuższe lub równe 3 i nie dopuiszczać żadnych znaków specjalnych, 
na gałęzi feature-conflict metoda dopuszczała imiona dłuższe od 5 znaków i dopuszczała znaki specjalne - i \. Konflikt rozwiązałam poprzez połączenie dwóch elementów: metoda ostatecznie dopuszcza imiona dłuższe lub równe 3 ze znakami specjalnymi - i \

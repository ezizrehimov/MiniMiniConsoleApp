# MiniMiniConsoleApp
Tapşırıq: Mini mini mini bir console app
Human class : Name,Surname,Age,ShowInfo()-konsola Ad,Soyad ve yasi yazdirir.
Name ve Surname deyerleri teyin olunmamis insan yaradila bilmesin
Name ve Surname yalniz herflerden ibaret olmalidir
Student class : Humandan miras alir elave olaraq Grade,GroupNo xususiyyetleri var;
Employee class : Humandan miras alir elave olaraq Position deyeri var

eger student insani uzerinden ShowInfo() metodu cagirilsa elave olaraq konsola Grade ve GroupNo yazdirsin.
eger employe insani uzerinden ShowInfo() metodu cagirilsa elave olaraq konsola Position yazdirsin.


City interface
 - Humans
 - AddHuman() - parametr oaraq gelen human deyerini siyahiya elave edir
 - SearchHumans() - string deyer qebul ve fullname-inde hemin deyer olan butun humanlardan ibaret bir array qaytarir geriye.

Baku class City-ni implement edir
 - Humans - human arrayi
 - AddHuman() - parametr oaraq gelen human deyerini siyahiya elave edir
 - GetStudents() - humans siyahisindaki studentlerden ibaret bir array qaytarir
 - GetEmployees() - human siayhisindaki employeelerden ibaret bir array qaytarir
 - SearchHumans() - string deyer qebul ve fullname-inde hemin deyer olan butun humanlardan ibaret bir array qaytarir geriye.

Proqram ise dusende asagidaki menu gorsenir
1. Employee elave et
2. Student elave et
3. Employeelerin sayini goster
4. Studentlerin sayini goster
5. Employeelere bax
6. Studentlere bax
7. Insanlar uzere axtaris et
0. Menudan cix

1 secilse Employee obyektinin yaranmasi ucun lazim olan butun datalar console-dan goturulur ve city-e elave edilir (AddHuman metodu ile)
2 secilse Student obyektinin yaranmasi ucun lazim olan butun datalar console-dan goturulur ve city-e elave edilir (AddHuman metodu ile)
3 secilse citydeki employeelerin sayini gosterir
4 secilse citydeki studentlerin sayini gosterir
5 secilse citydeki employeelerin hamisi uzerinden showinfo edilir
6 secilse citydeki butun studentlerin hamisi uzerinden showinfo edilir
7 secilse consoledan axtaris qebul edilir ve city uzerinde SearchHumans ile search edilir ve tapilan butun humanlar uzerinden showinfo edilir

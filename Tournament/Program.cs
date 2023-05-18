Player michael = new Player("Michael, The Goat","Jordan",23);
michael.UpdateJersey(45);
michael.UpdateJersey(23);

//michael.Display();

Player axa = new Player("Axa","Uribe",10);
Player alexis = new Player("Alexis","Sanchez",25);
Player guy = new Player("Guy","Spelunky",1);

Team fireballs = new Team("Fireballs");

Team sp2 = new Team("Spelunky2");

sp2.AddPlayer(guy);
sp2.AddPlayer(alexis);

fireballs.AddPlayer(axa);
fireballs.AddPlayer(michael);

//fireballs.AddWin();
//fireballs.AddLoss();
//fireballs.AddWin();

//fireballs.Display();
Match num1 = new Match(fireballs, sp2);
num1.DecideWin();

fireballs.Display();
sp2.Display();
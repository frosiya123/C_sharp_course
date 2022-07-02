// Напишите программу, которая выводит третью цифру заданного числа 
//или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6
string b;
	int Number;
	while(true)
    {
	    b = System.Console.ReadLine();
	    if( b == "N" || b == "n" )    // || - или
        {
		break; //выход
	    }
	    if (!int.TryParse(b, out Number))
        {
    		System.Console.WriteLine(b + " Не является числом!");
		continue;
	    }
	    
	    // проверка, что число трехзначное
	    if( Number < 100 )
        {
		System.Console.WriteLine(b + " меньше чем трехзначное число!");
                continue;
	    }

	    // Нахождение третьего символа
	    System.Console.Write("Третье число: ");
	    System.Console.WriteLine(b.Substring(2,1));
	}
    

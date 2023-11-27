using Week_4;

{
    Console.WriteLine(" Week4");

    #region OBJECT_CLASS_BOXING_UNBOXING
    
    //Object Class Sample
    Sample x = new Sample();
    //Console.WriteLine(x.ToString());
    //Console.ReadLine();


    //BOXING UNBOXING
    int y = 42;
    object z = y; //boxing
    int q = (int) z; //unboxing
    // cast operator -> ()

    bool a = true;
    object b = a;
    int c = (int)b;

    #endregion

    #region IS_AS_KEYWORDS_PATTERN_MATCHING
    //AS KEYWORD   
    Player myPlayer = new Player("Sueda", 123);
    Color myColor = new Color();



    Console.WriteLine($"myPlayer is Color: {myPlayer is Color}");
    Console.WriteLine($"myPlayer is Player: {myPlayer is Player}");
    Console.WriteLine($"myPlayer is object: {myPlayer is object}");
    if (myPlayer is Player copyOfMyPlayer) //patern
    {
        copyOfMyPlayer.Report();
    }


    object objCopy = myColor;

    switch (objCopy)
    {
        case Player playerCopy:
            Console.WriteLine("It's type is player");
            playerCopy.Report();
            break;
        case Color colorCopy:
            Console.WriteLine("It's type is color");
            break;
        case Sample sampleCopy:
            Console.WriteLine("It's sample");
            break;
        default:
            Console.WriteLine("Not a player or color");
            break;
    }

    //As Keyword
    Player xPlayer = new Player("Neo", 1234);
    Color xColor = new Color();

    object xObject = xPlayer;
    Console.WriteLine($"xObject is Player: {xObject is Player}");
    Console.WriteLine($"xObject is Color: {xObject is Color}");
    Console.WriteLine("--------");

    Player xPlayerCopy = xObject as Player;
    Color xColorCopy = xObject as Color;

    Console.WriteLine($"myPlayerCopy is not null: {xPlayerCopy is not null}");
    Console.WriteLine($"myColorCopy is not null: {xColorCopy is not null}");

    Player xPlayerCopy2;
    Color xColorCopy2;

    if (xObject is Player)
    {
        xPlayerCopy2 = xObject as Player;
    }
    #endregion
    Console.ReadLine();

    #region ENUM
    Player player1 = new Player("Pars", 1234, Level.Level2);
    player1.Report();
    player1.level = Level.Level3;

    Console.WriteLine($"{Level.Level1} : {(ushort)Level.Level1}");
    Console.WriteLine($"{Level.Level2} : {(ushort)Level.Level2}");
    Console.WriteLine($"{Level.Level3} : {(ushort)Level.Level3}");
    Console.WriteLine($"{Level.Level4} : {(ushort)Level.Level4}");
    Console.WriteLine($"{Level.Level5} : {(ushort)Level.Level5}");
    #endregion

    #region STRUCT
    //Struct
    Coordinate myCoordinate = new Coordinate();
    myCoordinate.Report();

    Coordinate myCoordinate2 = myCoordinate;
    myCoordinate2.x = 77;
    myCoordinate2.y = 77;
    myCoordinate2.z = 77;

    Console.WriteLine("My coordinate 1");
    myCoordinate.Report();


    Console.WriteLine("My coordinate 2");
    myCoordinate2.Report();

    int i = 0;

    RecursiveMethod();
    #endregion

    #region TUPLE
    //Tuple

    (int x, int y, int z) myTuple = (1, 2, 3);
    Console.WriteLine($"X:" + myTuple.x);
    Console.WriteLine($"Y:" + myTuple.y);
    Console.WriteLine($"Z:" + myTuple.z);

    (int, int, int) mySecondTuple = TupleSim();

    Console.WriteLine($"mySecondTuple : {mySecondTuple}");

    #endregion
}

static (int, int, int) TupleSim()
{
    return (1, 2, 3);
}

static void RecursiveMethod()
{
    Coordinate newCoordinate = new Coordinate();
    RecursiveMethod();
}


//as is gibi kullanılır asde kontrol yok.

/*object class <- mama class
boxing unboxing
is opperator pattern matching
as operator
switch statement
virtual - override - base keyword
protected keyword
extension methods*/
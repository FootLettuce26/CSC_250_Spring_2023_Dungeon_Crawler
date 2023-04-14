public class MasterData //unity only knows about monobehaviors, this is not one so it won't show up in unity
{
    public static int count = 0; //not an instance, so there is not "this" or "super" keyword
    public static string sourceRoom = "?";
    public static bool setupDone = false;
    public static bool keysActive = true;
    public static bool enteringCenter = false;
    private static bool isDungeonSetup = false;
    public static Dungeon cs = null;
    public static Player p = null;
    public static bool isExiting = true;

    public static bool keysActiveEast = false;
    public static bool keysActiveNorth = false;
    public static bool keysActiveSouth = false;
    public static bool keysActiveWest = false;

    public static bool northOn;
    public static bool southOn;
    public static bool eastOn;
    public static bool westOn;

    public static void setupDungeon()
    {
        if (MasterData.isDungeonSetup == false)
        {
            MasterData.cs = new Dungeon(100);
            //creating player using constructor in Player class
            MasterData.p = new Player("Timothyyyy");

            //calling the methods that belong to the dungeon class using the instance of Dungeon 
            MasterData.cs.populateCSDepartment();
            MasterData.cs.addPlayer(p);

            MasterData.isDungeonSetup = true;
        }



    }
}

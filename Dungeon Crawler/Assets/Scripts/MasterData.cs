public class MasterData //unity only knows about monobehaviors, this is not one so it won't show up in unity
{
    public static int count = 0; //not an instance, so there is not "this" or "super" keyword
    public static string sourceRoom = "?";
    public static bool setupDone = false;
    public static bool keysActive = true;
    //public static bool enteringExit = true;
}


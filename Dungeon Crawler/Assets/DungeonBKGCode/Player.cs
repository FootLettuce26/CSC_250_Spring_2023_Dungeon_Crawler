public class Player
{

    protected string name; //protected allows the parent(this) and it's children access
    protected Room currentRoom;

    public Player(string name)
    {
        this.name = name;
    }
    //read only access and private name; if in Player they get write and protected
    public string getName()
    {
        return this.name;
    }
    public void setCurrentRoom(Room r)
    {
        if (r != null)
        {
            this.currentRoom = r;
        }
    }
    public Room getCurrentRoom()
    {
        return this.currentRoom;
    }
}
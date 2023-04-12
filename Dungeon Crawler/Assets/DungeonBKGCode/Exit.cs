public class Exit
{
    private string direction;
    protected Room destinationRoom;
    
    public Exit(string direction, Room destinationRoom)
    {
        this.direction = direction;
        this.destinationRoom = destinationRoom;
    }
    public Room getDestinationRoom()
    {
        return destinationRoom;
    }
    public string getDirection()
    {
        return this.direction;
    }
}
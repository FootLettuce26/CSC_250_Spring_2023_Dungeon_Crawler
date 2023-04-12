public class Room
{
    //prototyping variables up here
    private string name;
    protected Exit[] theExits;
    public int numberOfExits;
    protected Player[] thePlayers; //creating an array of type Player
    private int currentNumberOfPlayers;
    private int currentNumberOfMonsters;
    
    public Room(string name)
    {
        //defining variables down here
        this.name = name;
        this.theExits = new Exit[4];
        this.numberOfExits = 0;
        this.thePlayers = new Player[25];
        this.currentNumberOfPlayers = 0;
        
    }
    
    public void addExit(Exit e)
    {
        if(this.numberOfExits < 4)
        {
            this.theExits[this.numberOfExits] = e;
            this.numberOfExits++;
        }
        else
        {
            //Console.WriteLine("Too Many Exits!!!!");
        }
    }

    public void addPlayer(Player p)
    {
        this.thePlayers[this.currentNumberOfPlayers] = p;
        this.currentNumberOfPlayers++;
        p.setCurrentRoom(this);
    }

    public void removePlayer(Player thePlayer)
    {
        for(int i = 0; i < currentNumberOfPlayers; i++)
        {
            if(thePlayer == thePlayers[i])
            {
                for(int j = i+1; j <currentNumberOfPlayers; j++)
                {
                    this.thePlayers[j-1] = this.thePlayers[j];
                }
                this.currentNumberOfPlayers--;
                return;
            }
        }
    }
    
    
}
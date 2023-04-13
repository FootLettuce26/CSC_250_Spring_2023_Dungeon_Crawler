using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DungeonSetup : MonoBehaviour
{
    public GameObject northExit, southExit, eastExit, westExit;


    public bool northOn;
    public bool southOn;
    public bool eastOn;
    public bool westOn;

    

    // Start is called before the first frame update
    void Start()
    {
        MasterData.setupDungeon();
        this.northOn = false;
        this.southOn = false;
        this.eastOn = false;
        this.westOn = false;

        this.northExit.SetActive(northOn);
        this.eastExit.SetActive(eastOn);
        this.westExit.SetActive(westOn);
        this.southExit.SetActive(southOn);

        if (MasterData.p.getCurrentRoom().hasExit("north"))
        {
            this.northOn = true;
            this.northExit.SetActive(northOn);

            print("this room has north exit");
        }
        if (MasterData.p.getCurrentRoom().hasExit("east"))
        {
            this.eastOn = true;
            this.eastExit.SetActive(eastOn);

            print("this room has east exit");

        }
        if (MasterData.p.getCurrentRoom().hasExit("south"))
        {
            this.southOn = true;
            this.southExit.SetActive(southOn);

            print("this room has south exit");
        }
        if (MasterData.p.getCurrentRoom().hasExit("west"))
        {
            this.westOn = true;
            this.westExit.SetActive(westOn);

            print("this room has west exit");
        }

    }

}

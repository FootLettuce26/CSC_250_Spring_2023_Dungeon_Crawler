using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DungeonSetup : MonoBehaviour
{
    public GameObject northExit, southExit, eastExit, westExit;
    public GameObject eastFight, southFight, westFight, northFight;

    // Start is called before the first frame update
    void Start()
    {
        MasterData.setupDungeon();
        MasterData.northOn = false;
        MasterData.eastOn = false;
        MasterData.southOn = false;
        MasterData.westOn = false;


        this.northExit.SetActive(MasterData.northOn);
        this.eastExit.SetActive(MasterData.eastOn);
        this.westExit.SetActive(MasterData.westOn);
        this.southExit.SetActive(MasterData.southOn);

        this.northFight.SetActive(MasterData.northOn);
        this.eastFight.SetActive(MasterData.eastOn);
        this.southFight.SetActive(MasterData.southOn);
        this.westFight.SetActive(MasterData.westOn);

        MasterData.keysActiveEast = false;
        MasterData.keysActiveNorth = false;
        MasterData.keysActiveSouth = false;
        MasterData.keysActiveWest = false;



        if (MasterData.p.getCurrentRoom().hasExit("north"))
        {
            MasterData.northOn = true;
            this.northExit.SetActive(MasterData.northOn);
            this.northFight.SetActive(MasterData.northOn);
            MasterData.keysActiveNorth = true;

            print("this room has north exit");
        }
        if (MasterData.p.getCurrentRoom().hasExit("east"))
        {
            MasterData.eastOn = true;
            this.eastExit.SetActive(MasterData.eastOn);
            this.eastFight.SetActive(MasterData.eastOn);
            MasterData.keysActiveEast = true;

            print("this room has east exit");

        }
        if (MasterData.p.getCurrentRoom().hasExit("south"))
        {
            MasterData.southOn = true;
            this.southExit.SetActive(MasterData.southOn);
            this.southFight.SetActive(MasterData.southOn);
            MasterData.keysActiveSouth = true;

            print("this room has south exit");
        }
        if (MasterData.p.getCurrentRoom().hasExit("west"))
        {
            MasterData.westOn = true;
            this.westExit.SetActive(MasterData.westOn);
            this.westFight.SetActive(MasterData.westOn);
            MasterData.keysActiveWest = true;

            print("this room has west exit");
        }

    }

}
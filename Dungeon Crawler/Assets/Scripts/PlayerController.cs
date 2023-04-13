using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rb;
    public GameObject northExit, southExit, eastExit, westExit;
    //public GameObject westStart, eastStart, northStart, southStart;
    public float movementSpeed = 40.0f;
    

    // Start is called before the first frame update
    void Start()
    {
        this.rb = this.GetComponent<Rigidbody>();
        

        if (!MasterData.sourceRoom.Equals("?"))
        {
            if (MasterData.sourceRoom.Equals("north"))
            {
                this.gameObject.transform.position = this.southExit.transform.position;
                this.rb.AddForce(this.northExit.transform.position * movementSpeed);

            }
            else if (MasterData.sourceRoom.Equals("south"))
            {
                this.gameObject.transform.position = this.northExit.transform.position;
                this.rb.AddForce(this.southExit.transform.position * movementSpeed);
            }
            else if (MasterData.sourceRoom.Equals("west"))
            {
                this.gameObject.transform.position = this.eastExit.transform.position;
                this.rb.AddForce(this.westExit.transform.position * movementSpeed);
            }
            else if (MasterData.sourceRoom.Equals("east"))
            {
                this.gameObject.transform.position = this.westExit.transform.position;
                this.rb.AddForce(this.eastExit.transform.position * movementSpeed);
            }
        }


    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Origin"))
        {
            if(MasterData.enteringCenter == true)
            {
                this.rb.Sleep();
            }
            MasterData.keysActive = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {

        print("i hit something");

        if (other.gameObject.CompareTag("Exits") && MasterData.isExiting)
        {
            if (other.gameObject == this.northExit)
            {
                MasterData.sourceRoom = "north";
                MasterData.enteringCenter = true;
            }
            else if (other.gameObject == this.southExit)
            {
                MasterData.sourceRoom = "south";
                MasterData.enteringCenter = true;
            }
            else if (other.gameObject == this.eastExit)
            {
                MasterData.sourceRoom = "east";
                MasterData.enteringCenter = true;
            }
            else if (other.gameObject == this.westExit)
            {
                MasterData.sourceRoom = "west";
                MasterData.enteringCenter = true;
            }
            MasterData.isExiting = false;
            

            print(MasterData.p.getCurrentRoom().name);
            MasterData.p.getCurrentRoom().takeExit(MasterData.p, MasterData.sourceRoom);
            print(MasterData.sourceRoom);
            SceneManager.LoadScene("DungeonRoom");
            print(MasterData.p.getCurrentRoom().name);
        }
        else if (other.gameObject.CompareTag("Exits") && !MasterData.isExiting)
        {
            MasterData.isExiting = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow) && (MasterData.keysActive == true) && (MasterData.keysActiveNorth == true))
        {
            this.rb.AddForce(Vector3.forward * movementSpeed * 5); //accessing the position vector in transform
            MasterData.keysActive = false;
            MasterData.isExiting = true;
            MasterData.keysActiveNorth = false;
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow) && (MasterData.keysActive == true) && (MasterData.keysActiveWest == true))
        {
            this.rb.AddForce(Vector3.left * movementSpeed * 5); //accessing the position vector in transform
            MasterData.keysActive = false;
            MasterData.isExiting = true;
            MasterData.keysActiveWest = false;
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow) && (MasterData.keysActive == true) && (MasterData.keysActiveEast == true))
        {
            this.rb.AddForce(Vector3.right * movementSpeed * 5); //accessing the position vector in transform
            MasterData.keysActive = false;
            MasterData.isExiting = true;
            MasterData.keysActiveEast = false;
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow) && (MasterData.keysActive == true) && (MasterData.keysActiveSouth == true))
        {
            this.rb.AddForce(Vector3.back * movementSpeed * 5); //accessing the position vector in transform
            MasterData.keysActive = false;
            MasterData.isExiting = true;
            MasterData.keysActiveSouth = false;
        }

    }
}
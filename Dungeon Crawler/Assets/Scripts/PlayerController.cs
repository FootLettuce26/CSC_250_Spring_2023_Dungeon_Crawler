using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rb;
    public GameObject northExit, westExit, southExit, eastExit;
    public float movementSpeed = 40.0f;
   
    private bool timothyEntering;
    private bool enteringCenter;
    private Vector3 center = new Vector3(0, 0.5f, 0);
    private bool enteringExit;


    // Start is called before the first frame update
    void Start()
    {
        //this.timothyEntering = false; //if timothy is entering, then this is true
        this.rb = this.GetComponent<Rigidbody>();
        //print(MasterData.sourceRoom);
        enteringCenter = false;

        if(MasterData.sourceRoom.Equals("north"))
        {
            this.rb.transform.position = this.southExit.transform.position; //put at new position based on exit
            this.rb.AddForce(this.northExit.transform.position * movementSpeed); //shove player Timothy
            MasterData.setupDone = true;
            enteringCenter = true;
            print("shove given");
        }
        if (MasterData.sourceRoom.Equals("south"))
        {
            this.rb.transform.position = this.northExit.transform.position; //put at new position based on exit
            this.rb.AddForce(this.southExit.transform.position * movementSpeed); //shove player Timothy
            MasterData.setupDone = true;
            enteringCenter = true;
            print("shove given");
        }
        if (MasterData.sourceRoom.Equals("east"))
        {
            this.rb.transform.position = this.westExit.transform.position; //put at new position based on exit
            this.rb.AddForce(this.eastExit.transform.position * movementSpeed); //shove player Timothy
            MasterData.setupDone = true;
            enteringCenter = true;
            print("shove given");
        }
        if (MasterData.sourceRoom.Equals("west"))
        {
            this.rb.transform.position = this.eastExit.transform.position; //put at new position based on exit
            this.rb.AddForce(this.westExit.transform.position * movementSpeed); //shove player Timothy
            MasterData.setupDone = true;
            enteringCenter = true;
            print("shove given");
        }


    }

    // Update is called once per frame
    void Update()
    {
        


        if (Input.GetKeyDown(KeyCode.UpArrow) && (MasterData.keysActive == true))
        {
            this.rb.AddForce(this.northExit.transform.position * movementSpeed); //accessing the position vector in transform
            MasterData.keysActive = false;
            enteringExit = true;
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow) && (MasterData.keysActive == true))
        {
            this.rb.AddForce(this.westExit.transform.position * movementSpeed); //accessing the position vector in transform
            MasterData.keysActive = false;
            enteringExit = true;
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow) && (MasterData.keysActive == true))
        {
            this.rb.AddForce(this.eastExit.transform.position * movementSpeed); //accessing the position vector in transform
            MasterData.keysActive = false;
            enteringExit = true;
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow) && (MasterData.keysActive == true))
        {
            this.rb.AddForce(this.southExit.transform.position * movementSpeed); //accessing the position vector in transform
            MasterData.keysActive = false;
            enteringExit = true;
        }
        //enteringCenter = true;
    }
    private void OnTriggerExit(Collider other)
    {
        print("i hit something");

        /*if(other.gameObject.CompareTag("Origin"))
        {
            this.rb.maxAngularVelocity = 70f;
            
        }*/

        if (other.gameObject.CompareTag("Exits") /*&& MasterData.setupDone.Equals(true)*/)
        {
            print("i hit an exit");
            if ((other.gameObject == this.northExit) && enteringExit == true)
            {
                MasterData.sourceRoom = "north";
                SceneManager.LoadScene("DungeonRoom0"); //asks it to load a scene
                enteringExit = false;

            }
            if ((other.gameObject == this.southExit) && enteringExit == true)
            {
                MasterData.sourceRoom = "south";
                SceneManager.LoadScene("DungeonRoom0");
                enteringExit = false; 
            }
            if ((other.gameObject == this.eastExit) && enteringExit == true)
            {
                MasterData.sourceRoom = "east";
                SceneManager.LoadScene("DungeonRoom0");
                enteringExit = false;

            }
            if ((other.gameObject == this.westExit) && enteringExit == true)
            {
                MasterData.sourceRoom = "west";
                SceneManager.LoadScene("DungeonRoom0");
                enteringExit = false;
            }


        }

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Origin"))
        {
            if (enteringCenter == true)
            {
                this.rb.velocity = Vector3.zero;
                this.rb.angularVelocity = Vector3.zero;
            }

            MasterData.keysActive = true;


        }
    }

}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rb;
    public GameObject northExit, westExit, southExit, eastExit;
    public float movementSpeed = 40.0f;
    private bool keysActive = true;
    private bool timothyEntering;
    private Vector3 center = new Vector3(0, 0.5f, 0);
 

    // Start is called before the first frame update
    void Start()
    {
        this.timothyEntering = false; //if timothy is entering, then this is true
        this.rb = this.GetComponent<Rigidbody>();
        //print(MasterData.sourceRoom);
        if(MasterData.sourceRoom.Equals("north"))
        {
            this.rb.transform.position = this.southExit.transform.position; //put at new position based on exit
            //this.rb.AddForce(this.northExit.transform.position * movementSpeed); //shove player Timothy
            print("shove given");
        }

    }

    // Update is called once per frame
    void Update()
    {
        //keysActive = true;
        //this.timothyEntering = false;
            
        

        if(Input.GetKeyDown(KeyCode.UpArrow) && (keysActive == true))
        {
            this.rb.AddForce(this.northExit.transform.position * movementSpeed); //accessing the position vector in transform
            keysActive = false;
            
        }
        else if(Input.GetKeyDown(KeyCode.LeftArrow) && (keysActive == true))
        {
            this.rb.AddForce(this.westExit.transform.position * movementSpeed); //accessing the position vector in transform
            keysActive = false;
            
        }
        else if(Input.GetKeyDown(KeyCode.RightArrow) && (keysActive == true))
        {
            this.rb.AddForce(this.eastExit.transform.position * movementSpeed); //accessing the position vector in transform
            keysActive = false;
            
        }
        else if(Input.GetKeyDown(KeyCode.DownArrow) && (keysActive == true))
        {
            this.rb.AddForce(this.southExit.transform.position * movementSpeed); //accessing the position vector in transform
            keysActive = false;
            
        }
    }
    private void OnTriggerExit(Collider other)
    {
        print("i hit something");
        if(other.gameObject.CompareTag("Exits") && this.timothyEntering.Equals(false))
        {
            print("i hit an exit");
            if(other.gameObject == this.northExit)
            {
                MasterData.sourceRoom = "north";
              
            }
            if (other.gameObject == this.southExit)
            {
                MasterData.sourceRoom = "south";
                
               
            }
            if (other.gameObject == this.eastExit)
            {
                MasterData.sourceRoom = "east";
                
               
            }
            if (other.gameObject == this.westExit)
            {
                MasterData.sourceRoom = "west";
       
            }
            
            SceneManager.LoadScene("DungeonRoom0"); //asks it to load a scene
        }
    }
   
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Origin"))
        {
            this.rb.transform.position = new Vector3(0, 0.5f, 0);
     
            //keysActive = true;
            //timothyEntering = false;

        }
    }

}
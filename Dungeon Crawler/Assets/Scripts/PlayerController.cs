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

    // Start is called before the first frame update
    void Start()
    {
        this.rb = this.GetComponent<Rigidbody>();
        print(MasterData.count);
    }

    // Update is called once per frame
    void Update()
    {
       
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
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Exits"))
        {
            MasterData.count++;
            SceneManager.LoadScene("DungeonRoom"); //asks it to load a scene 
        }
    }
}





//MasterData.count++;
//SceneManager.LoadScene("DungeonRoom"); //asks it to load a scene 
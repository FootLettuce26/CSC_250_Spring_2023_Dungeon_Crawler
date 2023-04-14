using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OriginController : MonoBehaviour
{
    //public GameObject thePlayer;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag.Equals("Player"))
        {
            //Rigidbody rb = thePlayer.GetComponent<Rigidbody>();
            MasterData.setupDone = true;
            MasterData.keysActive = false;
        }
    }

}
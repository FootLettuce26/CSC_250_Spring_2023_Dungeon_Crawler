using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterRotate : MonoBehaviour
{
    private Vector3 rotationVector = new Vector3(15, 30, 45);
    // Update is called once per frame
    void Update()
    {
        this.transform.Rotate(rotationVector * Time.deltaTime * 3);
    }
}

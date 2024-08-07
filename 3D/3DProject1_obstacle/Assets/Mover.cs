using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    float movespeed = 10f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        movePlayer();
    }

    void movePlayer()
    {
        float xvalue = Input.GetAxis("Horizontal") * movespeed * Time.deltaTime;
        float zvalue = Input.GetAxis("Vertical") * movespeed * Time.deltaTime;
        transform.Translate(xvalue, 0, zvalue);
    }

}

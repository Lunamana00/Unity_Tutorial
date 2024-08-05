using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float xvalue = Input.GetAxis("Horizontal")*0.1f;
        float zvalue = Input.GetAxis("Vertical")*0.1f;
        transform.Translate(xvalue,0,zvalue);
    }
}

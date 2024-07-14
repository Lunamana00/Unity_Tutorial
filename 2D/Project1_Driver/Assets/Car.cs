using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    [SerializeField] float move_speed = 10f;
    [SerializeField] float rotate_speed = 1f;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float Horizontal_input = (Input.GetAxis("Horizontal"))* move_speed * Time.deltaTime;
        float Vertical_input = (Input.GetAxis("Vertical")) * move_speed * Time.deltaTime;
        //float D_input = (Input.GetAxis("A")) * rotate_speed * Time.deltaTime;
       // float A_input = (Input.GetAxis("D")) * rotate_speed * Time.deltaTime;
        //transform.Rotate(0, D_input, 0);
        //transform.Rotate(0, -A_input, 0);
        transform.Translate(Horizontal_input, Vertical_input, 0);
    }
}

using UnityEngine;

public class CharacterMovement2D : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float rotationSpeed = 5000f;
    public float boostSpeed = 10f;
    void Update()
    {
        // Get the input for movement and rotation
        float moveInput = Input.GetAxis("Vertical");
        float rotationInput = Input.GetAxis("Horizontal");

        transform.Translate(0, moveInput * moveSpeed * Time.deltaTime, 0);
 
        transform.Rotate(0, 0, -rotationInput * rotationSpeed * Time.deltaTime);

    }

    private void OnTriggerEnter2D(Collider2D others)
    {
        if(others.tag == "Boost")
        {
            moveSpeed = boostSpeed;
        }
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    [SerializeField] Color32 hasPackageColor = new Color32(255, 1, 1, 255);
    [SerializeField] Color32 noPackageColor = new Color32(1, 1, 255, 255);
    bool hasPackage = false;

    SpriteRenderer spriteRenderer;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.color = noPackageColor;
    }

    void OnTriggerEnter2D(Collider2D others)
    {
        if(others.tag == "Package"&& !(hasPackage))
        {
            hasPackage = true;
            Debug.Log("get package");
            spriteRenderer.color = hasPackageColor;
            Destroy(others.gameObject,0.5f);
        }

        if (others.tag == "Customer" && hasPackage ==true)
        {
            Debug.Log("success");
            hasPackage = false;
            spriteRenderer.color = noPackageColor;
            Destroy(others.gameObject, 0.5f);
        }
        else if(hasPackage == false)
        {
            Debug.Log("no package");
            
        }
    }
}

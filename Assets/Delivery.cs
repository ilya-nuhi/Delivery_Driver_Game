using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{   
    bool hasPackage = false;
    [SerializeField] float delay = 0.5f;
    [SerializeField] Color32 noPackageColor = new Color32(1,1,1,1);

    SpriteRenderer spriteRendererCar;
    SpriteRenderer spriteRendererPackage;
    void Start() {
        spriteRendererCar = GetComponent<SpriteRenderer>();
    }
    void OnCollisionEnter2D(Collision2D other) {
        Debug.Log("AHHHHH!!");
    }

    void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Package" && !hasPackage){
            Debug.Log("Package picked up.");
            hasPackage = true;
            spriteRendererPackage = other.GetComponent<SpriteRenderer>();
            spriteRendererCar.color = spriteRendererPackage.color;
            Destroy(other.gameObject,delay);
        }
        else if(other.tag=="Customer" && hasPackage){
            Debug.Log("Package delivered.");
            hasPackage = false;
            spriteRendererCar.color = noPackageColor;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{

    [SerializeField] float steerSpeed = 200f;
    [SerializeField] float moveSpeed = 20f;
    [SerializeField] float slowSpeed = 15f;
    [SerializeField] float boostSpeed = 30f;
    // Start is called before the first frame update
    void OnTriggerEnter2D(Collider2D other) {
        if(other.tag=="booster"){
            moveSpeed = boostSpeed;
        }
    }

    void OnCollisionEnter2D(Collision2D other) {
        moveSpeed = slowSpeed;    
    }

    // Update is called once per frame
    void Update()
    {
        float steerAmounth = Input.GetAxis("Horizontal")*steerSpeed*Time.deltaTime;
        float moveAmounth = Input.GetAxis("Vertical")*moveSpeed*Time.deltaTime;
        transform.Rotate(0,0,-steerAmounth);
        transform.Translate(0,moveAmounth,0);
    }
}

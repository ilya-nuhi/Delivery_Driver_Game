using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{   
    // this things position(camera) should be the same as car's position.
    [SerializeField] GameObject thingToFollow;
    // Update is called once per frame

    Vector3 distanceZ = new Vector3(0,0,-10);
    void LateUpdate()
    {
        transform.position = thingToFollow.transform.position + distanceZ;      ;
    }
}

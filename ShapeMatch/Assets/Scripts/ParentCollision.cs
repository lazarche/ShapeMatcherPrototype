using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParentCollision : MonoBehaviour
{
    public void LimbCollision(GameObject limb, Collision collision) {
        if(collision.gameObject.tag == "Cuttout")
            Debug.Log(limb.name + " | " + collision.gameObject.name);
    }
}

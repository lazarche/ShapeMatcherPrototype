using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckCollisionLimbs : MonoBehaviour
{
    void OnCollisionEnter(Collision collision) {
        transform.root.GetComponent<ParentCollision>().LimbCollision(this.gameObject, collision);
    }
}

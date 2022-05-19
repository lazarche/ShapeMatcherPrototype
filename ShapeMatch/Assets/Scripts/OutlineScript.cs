using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutlineScript : MonoBehaviour
{
    bool contact = false;
    MeshRenderer r;
    // Start is called before the first frame update
    void Start()
    {
        r = this.GetComponent<MeshRenderer>();
    }

    void OnCollisionStay(Collision collisionInfo)
    {
        contact = true;
        foreach (ContactPoint contact in collisionInfo.contacts)
        {
            Debug.Log(contact.thisCollider.gameObject.name);
        }
    }

    void OnCollisionLeave(Collision collisionInfo) {
        contact = false;
    }


    // Update is called once per frame
    void FixedUpdate()
    {
        // if(contact)
        //     r.material.SetColor("_Color", Color.red);
        //     else
        //     r.material.SetColor("_Color", Color.green);

        // contact = false;
    }
}

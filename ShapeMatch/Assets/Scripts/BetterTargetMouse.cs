using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BetterTargetMouse : MonoBehaviour
{
    private Transform sphere;
    public float distanceFromCamera;
    Rigidbody r;

    void Start()
    {
        sphere = this.transform;
        distanceFromCamera = 9.5f; //Vector3.Distance(sphere.position, Camera.main.transform.position);
        r = this.GetComponent<Rigidbody>();
    }

    Vector3 lastPos;

    void OnMouseDrag()
    {
        Vector3 pos = Input.mousePosition;
        pos.z = distanceFromCamera;
        pos = Camera.main.ScreenToWorldPoint(pos);
        r.velocity = (pos - sphere.position) * 10;
    }
    
    void OnMouseUp()
    {
        r.velocity = Vector3.zero;
    }
}

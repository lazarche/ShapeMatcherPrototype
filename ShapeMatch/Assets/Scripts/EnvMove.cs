using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnvMove : MonoBehaviour
{
    public float speed = -1.5f;
    // Start is called before the first frame update
    void Start()
    {
        this.GetComponent<Rigidbody>().velocity = new Vector3(0 ,0 , speed);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

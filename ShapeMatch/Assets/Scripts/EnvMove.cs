using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnvMove : MonoBehaviour
{
    public float speed = -2f;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(0,0,speed) * Time.deltaTime); 
        if(this.transform.position.z < -20) {
            Destroy(this.gameObject, 0);
        }
    }
}

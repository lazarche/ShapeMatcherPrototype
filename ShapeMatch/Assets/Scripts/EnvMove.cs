using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnvMove : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(0,0,GlobalVariables.gameSpeed) * Time.deltaTime); 
        if(this.transform.position.z < -60) {
            Destroy(this.gameObject, 0);
        }
    }
}

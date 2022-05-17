using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetTarget : MonoBehaviour
{
    public Transform target, shoulder;

    public float lenght = 1, zFix = 2f;

    // Update is called once per frame
    void Update()
    {
        float distToShoulder = Vector3.Distance(target.position, shoulder.position);
        Debug.Log(distToShoulder);
        
        float offset = (lenght - (distToShoulder/lenght)) * zFix;

        if(distToShoulder < lenght)
            this.transform.position = target.position - new Vector3(0,0, offset);
            else
            this.transform.position = target.position;

        
    }
}

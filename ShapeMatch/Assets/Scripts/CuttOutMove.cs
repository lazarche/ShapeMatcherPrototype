using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuttOutMove : MonoBehaviour
{
    bool touch, spawned = false;
    GameObject controller;
    public GameObject outline;
    // Start is called before the first frame update
    void Start()
    {     
        controller = GameObject.Find("GameController");
        touch = false;
    }

    void OnCollisionEnter(Collision collision) {
        touch = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(!spawned && transform.position.z < 19) {
            spawned = true;
            outline = Instantiate(outline, new Vector3(0,0,0), Quaternion.Euler(0,180,0));
        }

        transform.Translate(new Vector3(0,0,2f) * Time.deltaTime); 
        if(transform.position.z < -1) {
            Destroy(this.gameObject);
            Destroy(outline, 0);
            if(!touch) {
                controller.GetComponent<GameM>().score += 10;
            }


        }
            
    }
}
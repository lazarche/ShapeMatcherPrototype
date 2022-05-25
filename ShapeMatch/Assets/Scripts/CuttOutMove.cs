using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class CuttOutMove : MonoBehaviour
{
    bool spawned = false;
    GameObject controller;
    public GameObject outline;
    public AudioSource sound;
    // Start is called before the first frame update
    void Start()
    {     
        controller = GameObject.Find("GameController");
    }

    void OnCollisionEnter(Collision collision) {
        controller.GetComponent<GameM>().GameLose();
    }

    // Update is called once per frame
    void Update()
    {
        if(!spawned && transform.position.z < 19) {
            spawned = true;
            outline = Instantiate(outline, new Vector3(0,0,0), Quaternion.Euler(0,180,0));
        }

        // transform.Translate(new Vector3(0,0,2f) * Time.deltaTime); 

        if(transform.position.z < -1) {
           // Destroy(this.gameObject);
           this.gameObject.GetComponent<MeshCollider>().enabled = false;
           this.gameObject.GetComponent<MeshRenderer>().enabled = false;
            DestroyImmediate(outline);
        }
        if (transform.position.z <= -0.2)
        {
            sound.Play();
        }
    }
}
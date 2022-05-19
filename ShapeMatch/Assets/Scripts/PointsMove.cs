using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointsMove : MonoBehaviour
{
    GameObject controller;
    // Start is called before the first frame update
    void Start()
    {
        controller = GameObject.Find("GameController");
    }

    void OnCollisionEnter(Collision collision) {
        Destroy(this.gameObject);
        controller.GetComponent<GameM>().score += 5;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndObjScript : MonoBehaviour
{
    GameObject controller;
    // Start is called before the first frame update
    void Start()
    {
        controller = GameObject.Find("GameController");
    }

    void OnCollisionEnter(Collision collision) {
        Debug.Log("Pobeda jee");
        controller.GetComponent<GameM>().GameWin();
    }
}

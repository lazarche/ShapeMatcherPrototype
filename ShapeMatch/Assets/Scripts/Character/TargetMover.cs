using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetMover : MonoBehaviour
{
    public float minX = -5, maxX = 5;
    public float minY = -5, maxY = 5;
    private bool focus = false;
    public float zOffset = 0.5f;
    float distanceFromCamera;

    GameObject controller;
    [SerializeField] GameObject basePosition;
    // Update is called once per frame

    void Start() {
        controller = GameObject.Find("GameController");
        distanceFromCamera = 7; //Vector3.Distance(this.transform.position, Camera.main.transform.position);
    }

    void Update()
    {
        if(Input.GetMouseButton(0)) {
            controller.GetComponent<GameM>().GameStart();
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            // Casts the ray and get the first game object hit
            Physics.Raycast(ray, out hit);
            if(hit.transform == this.transform) {
                focus = true;
                HideOther();
            }
        } else {
            if(focus) {
                Vector3 temp = basePosition.transform.position;
                    temp.Set(temp.x, temp.y, zOffset);
                this.gameObject.transform.position = temp;//basePosition.transform.position;
                ShowOther();
            }
            focus = false;
        } 
            
        

        if(focus) 
            WriteMouseClick();
            
    }

    void WriteMouseClick() {
        Vector3 worldPosition;
        Vector3 mousePos = Input.mousePosition;
        mousePos.z = distanceFromCamera;
        worldPosition = Camera.main.ScreenToWorldPoint(mousePos);
        worldPosition.z = this.gameObject.transform.position.z;

        if(worldPosition.x < minX) worldPosition.x = minX;
        if(worldPosition.x > maxX) worldPosition.x = maxX;

        if(worldPosition.y < minY) worldPosition.y = minY;
        if(worldPosition.y > maxY) worldPosition.y = maxY;

        this.gameObject.transform.position = worldPosition;
    }

    void HideOther() {
        GameObject[] toHide = GameObject.FindGameObjectsWithTag("TouchControl");

        foreach (GameObject go in toHide)
        {
            if(go != this.gameObject)
                go.GetComponent<MeshCollider>().enabled = false;

            go.GetComponent<MeshRenderer>().enabled = false;
        }
    }

    void ShowOther() {
        GameObject[] toHide = GameObject.FindGameObjectsWithTag("TouchControl");

        foreach (GameObject go in toHide)
        {
            go.GetComponent<MeshCollider>().enabled = true;
            //go.GetComponent<MeshRenderer>().enabled = true;
        }
    }
}

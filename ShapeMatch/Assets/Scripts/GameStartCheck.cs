using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class GameStartCheck : MonoBehaviour
{
    private bool isGameStarted = false;
    
    public GameObject Panel;
    public GameObject text;
    public GameObject hand;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) 
        {
            isGameStarted = true;

           Panel.SetActive(false);
            text.SetActive(false);
            hand.SetActive(false);
        }
    }
}

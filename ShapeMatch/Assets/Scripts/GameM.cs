using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameM : MonoBehaviour
{
    public int score = 0;
    public GameObject textScore;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        SetScore();
    }

    void SetScore() {
        textScore.GetComponent<TMPro.TextMeshProUGUI>().text = "SCORE: " + score;
    }
}

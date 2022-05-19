using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GlobalVariables {
    public static float gameSpeed = -0;
}
public class GameM : MonoBehaviour
{
    
    public int score = 0;
    public GameObject textScore;
    public GameObject youLost, tryButton;
    bool started = false;
    // Start is called before the first frame update
    void Start()
    {
        Random.InitState(7);
        Application.targetFrameRate = 60;
    }

    // Update is called once per frame
    void Update()
    {
        SetScore();
    }

    void SetScore() {
        textScore.GetComponent<TMPro.TextMeshProUGUI>().text = "SCORE: " + score;
    }

    public void GameLose() {
        youLost.SetActive(true);
        tryButton.SetActive(true);
        GlobalVariables.gameSpeed = 0;
    }

    public void GameStart() {
        if(!started) {
            started = true;
            GlobalVariables.gameSpeed = -5;
        }
            
    }

    public void Restart() {
        Application.LoadLevel(Application.loadedLevel);
        GlobalVariables.gameSpeed = -5;
    }
}

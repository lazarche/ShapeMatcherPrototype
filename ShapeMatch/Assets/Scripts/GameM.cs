using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public static class GlobalVariables {
    public static float gameSpeed = -0;
}
public class GameM : MonoBehaviour
{
    
    public int score = 0;
    public GameObject textScore;
    public GameObject youLost, tryButton, theFinga, winButton, endObj;
    public Image bar;

    bool started = false;

    public float startDist;
    // Start is called before the first frame update
    void Start()
    {
        Screen.autorotateToPortrait = true;
        Screen.autorotateToLandscapeLeft = false;
        Screen.autorotateToLandscapeRight = false;
        Screen.autorotateToPortraitUpsideDown = false;
        Random.InitState(7);
        Application.targetFrameRate = 60;
    }

    // Update is called once per frame
    void Update()
    {
        UpdateUi();
    }

    void UpdateUi() {
        if(startDist == 0) {
            startDist = endObj.transform.position.z;
        }
        textScore.GetComponent<TMPro.TextMeshProUGUI>().text = "SCORE: " + score;
        float curDist = endObj.transform.position.z;
        bar.GetComponent<Image>().fillAmount = Mathf.Min((startDist-curDist)/startDist, 1);
        Debug.Log(startDist + " " + curDist + " " + bar.GetComponent<Image>().fillAmount);
    }

    public void GameWin() {
        GlobalVariables.gameSpeed = 0;
        winButton.SetActive(true);
    }

    public void GameLose() {
        youLost.SetActive(true);
        tryButton.SetActive(true);
        GlobalVariables.gameSpeed = 0;
    }

    public void GameStart() {
        theFinga.SetActive(false);
        if(!started) {
            started = true;
            GlobalVariables.gameSpeed = -3.5f;
        }
            
    }

    public void Restart() {
        Application.LoadLevel(Application.loadedLevel);
        GlobalVariables.gameSpeed = 0;
    }
}

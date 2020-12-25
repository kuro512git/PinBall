using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameControllerScript : MonoBehaviour
{
    //スコアカウント
    private int score;

    //スコアを表示するテキスト
    private GameObject scoreText;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;

        scoreText = GameObject.Find("ScoreText");
        scoreText.GetComponent<Text>().text = "Score:" + score;
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void AddPoint(int point)
    {
        score = score + point;
        UpdateScoreText();
    }

    void UpdateScoreText()
    {
        this.scoreText.GetComponent<Text>().text = "Score:" + score;
    }


}

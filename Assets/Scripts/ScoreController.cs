using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//スクリプトでUIを操作する場合は、「using UnityEngine.UI;」を記述
using UnityEngine.UI;


public class ScoreController : MonoBehaviour
{

    private int score;
    private int point;

    //スコアを表示するテキスト
    private GameObject scoreText;

    // Start is called before the first frame update
    void Start()
    {
        Initialize();
        //シーン中のGameOverTextオブジェクトを取得
        this.scoreText = GameObject.Find("ScoreText");
    }

    private void Initialize()
    {
        score = 0;
        point = 0;
    }

    void Update()
    {
       
    }

    public void AddPoint(int point)
    {
        score = score + point;
        UpdateScoreText();
    }

    void UpdateScoreText() {
        this.scoreText.GetComponent<Text>().text = "Score:" + score;
    }
    //衝突時に呼ばれる関数
    void OnCollisionEnter(Collision collision)
    {

        switch (tag)
        {
            case "SmallStarTag":
                score += 1;
                break;
            case "LargeStarTag":
                score += 3;
                break;
            case "SmallCloudTag":
                score += 2;
                break;
            case "LargeCloudTag":
                score += 5;
                break;
            default:
                score += 0;
                break;
        }
        if(score > 0)
        {
            AddPoint(score);
            Debug.Log(score + "_" + tag);
        }

    }

}

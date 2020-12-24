using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//スクリプトでUIを操作する場合は、「using UnityEngine.UI;」を記述
using UnityEngine.UI;


public class ScoreController : MonoBehaviour
{

    private GameControllerScript gameController;


    // Start is called before the first frame update
    void Start()
    {
        gameController = GameObject
            .FindWithTag("GameController")
            .GetComponent<GameControllerScript>();
    }


    void Update()
    {
       
    }


    //衝突時に呼ばれる関数
    void OnCollisionEnter(Collision collision)
    {

        switch (tag)
        {
            case "SmallStarTag":
                gameController.AddPoint(1);
                break;
            case "LargeStarTag":
                gameController.AddPoint(3);
                break;
            case "SmallCloudTag":
                gameController.AddPoint(2);
                break;
            case "LargeCloudTag":
                gameController.AddPoint(5);
                break;
            default:
                gameController.AddPoint(0);
                break;
        }
        Debug.Log( tag );

    }

}

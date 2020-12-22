using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarController: MonoBehaviour
{

    //回転速度
    private float rotSpeed = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        //回転を開始する角度を設定 x y z?
        this.transform.Rotate(0, Random.Range(0, 360), 0);
    }

    // Update is called once per frame
    void Update()
    {
        //回転  (* Time.deltaTime　は不要？) 
        //Transformクラスの「Rotate」関数は、現在の角度から引数に与えた角度のぶんだけ回転する関数です。引数には、第一引数から順番に、X軸、Y軸、Z軸を中心とした回転量を渡します。
        this.transform.Rotate(0, this.rotSpeed, 0);
    }
}
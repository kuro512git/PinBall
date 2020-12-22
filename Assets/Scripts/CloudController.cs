using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudController : MonoBehaviour
{

    //最小サイズ
    private float minimum = 1.0f;

    //拡大縮小スピード
    private float magSpeed = 10.0f;

    //拡大率
    private float magnification = 0.07f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //雲を拡大縮小 x y z ここではx横　z縦方向だけ拡大縮小
        //「Vector」は、オブジェクトの座標やオブジェクトに加わる力の方向などを扱う型です。Vector2はfloat型のx, yの要素を持っており、Vector3はfloat型のx, y, zの要素を持っています。
        this.transform.localScale = new Vector3(this.minimum + Mathf.Sin(Time.time * this.magSpeed) * this.magnification, this.transform.localScale.y, this.minimum + Mathf.Sin(Time.time * this.magSpeed) * this.magnification);
        
        //Time.time  ゲーム開始から何秒経ったかを取得できます
        //ここのよくわからない関数に入っている値を確認する方法を質問する
    }
}

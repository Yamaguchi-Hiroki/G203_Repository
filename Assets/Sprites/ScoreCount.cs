using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCount : MonoBehaviour
{
    //テキストオブジェクト
    public GameObject score_object = null;

    //スコア変数
    public int score_num = 0;

    // 初期化
    void Start()
    {
        
    }

    // 更新
    void Update()
    {
        //オブジェクトからTextコンポーネントを取得
        Text score_text = score_object.GetComponent<Text>();

        //テキストの表示を入れ替える
        score_text.text = "Score:" + score_num;

        //1ずつ加算する
        score_num += 1;
    }
}

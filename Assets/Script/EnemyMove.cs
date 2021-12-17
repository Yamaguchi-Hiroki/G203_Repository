using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    public float moveSpeed;          //移動速度

    public  float frequency;        //周波

    public float magnitude;         //震度

    bool facingRight = true;        //反転フラグ

    public float waitTime;

    Vector3 pos, localScale;
    // Start is called before the first frame update
    void Start()
    {
        pos = transform.position;
        /* transfrom.localScale オブジェクトの拡大縮小などに使う。
         * 今回は反転させるために使っている。（ちょっとわかりにくいけど）
         */
        localScale = transform.localScale;
    }

    // Update is called once per frame
    void Update()
    {
        if ( Time.frameCount > waitTime)
        {
            CheckWhereToFace();
            if (facingRight)
                MoveRight();
            else
                MoveLeft();
        }
    }

    /*
     * ここで画面端に到達したらオブジェクトを反転させる処理を書いている
     * 今回の場合、画面端は大体5.7fくらい
     * fracingRightフラグによって反転の操作の管理をしている
     */
    void CheckWhereToFace()
    {
        if (pos.x < -3.74f)
            facingRight = true;
        else if (pos.x > 3.57f)
            facingRight = false;
        if (((facingRight) && (localScale.x < 0)) || ((!facingRight) && (localScale.x > 0)))
            localScale.x *= -1;
        transform.localScale = localScale;
    }

    //右に動く際の処理
    void MoveRight()
    {
        pos += transform.right * Time.deltaTime * moveSpeed;
        transform.position = pos + transform.up * Mathf.Sin(Time.time * frequency) * magnitude;
    }

    //左に動く際の処理
    void MoveLeft()
    {
        pos -= transform.right * Time.deltaTime * moveSpeed;
        transform.position = pos + transform.up * Mathf.Sin(Time.time * frequency) * magnitude;
    }
}

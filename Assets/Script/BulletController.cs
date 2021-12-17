using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BulletController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*transform.Translate()オブジェクトを移動させるときに使う関数。
         * それぞれの引数（x,y,z）になっているのでこの場合y座標を動かしている。
         */
        transform.Translate(0, 0.05f, 0);

        if(transform.position.y > 5)        
        {
            //Dstroy()引数に入れられたオブジェクトを消滅させる。
            Destroy(gameObject);
        }
            
    }
    /* void OnTriggerEnter2D()オブジェクト動詞の当たり判定の処理をする、
     * 引数に書いてあるCollider2D collisionはVisual Studioがなんか勝手に宣言してくる。
     */
}

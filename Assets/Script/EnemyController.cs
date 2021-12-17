using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    //public GameObject player;
    public GameObject EbulletPrefab;
    public float targetTime = 3f;
    private float currentTime = 0f;
    public int enehp = 10;

    // Start is called before the first frame update
    void Start()
    {
 
    }

    // Update is called once per frame
    void Update()
    {

        //transform.position = new Vector2(
        //Mathf.Clamp(transform.position.x, -5.76f, 5.83f),
        //Mathf.Clamp(transform.position.y, -4.15f, 4.16f)
        //);

        /*currentTime += Time.deltaTime n秒ごとに処理を実行する、上記の public float targetTime = 3f;
         * でn秒のnの部分をいじれるよう設定(public ～で宣言するとプログラムをいじらなくてもインスペクタビューで値の変更ができる)
         *逆にprivate～で宣言したらプログラムからしか値の変更ができないので注意。
         */
        currentTime += Time.deltaTime;
        if (targetTime < currentTime)
        {
         　/*弾のPrefabからインスタンスを作るために、Instantiate関数を使っている。
            Instantiate関数は、第一引数にPrefab、第二引数にインスタンスを生成する位置、
            第三引数にはインスタンスの回転角を指定。*/
            currentTime = 0;
            Instantiate(EbulletPrefab, transform.position, Quaternion.identity);
        }
    }
}

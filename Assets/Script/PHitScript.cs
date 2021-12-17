using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PHitScript : MonoBehaviour
{
    GameObject enemy;
    EnemyController escript;
    // Start is called before the first frame update
    void Start()
    {
        enemy = GameObject.Find("EnemyPrefab");
        escript = enemy.GetComponent<EnemyController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }  
    void OnTriggerEnter2D(Collider2D collision)
    {
        /*
         * ここでTag機能を使っている、フラグ的なもの、まあおいおい話す。
         */
        if(collision.gameObject.tag != "Ebullet")
        {
            if(collision.gameObject.tag != "Player")
            {
                Destroy(gameObject);
                //Destroy(collision.gameObject);
            }
 
        }           
        if (collision.gameObject.tag == "Enemy")
        {
            escript.enehp--;
            if(escript.enehp == 0)
            {
                SceneManager.LoadScene("GameCrear");
            }
        }
    }
}

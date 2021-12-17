using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitScript : MonoBehaviour
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
        if (collision.gameObject.tag != "Bullet")
        {
            if (collision.gameObject.tag != "Enemy")
            {
                if (collision.gameObject.tag != "Ebullet")
                {
                    Destroy(gameObject);
                    GameObject manager = GameObject.Find("GameManager");
                    manager.GetComponent<GameManeger>().DecreaseHp();
                }
            }
        }
    }
}

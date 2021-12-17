using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerContoroller : MonoBehaviour
{
    public GameObject bulletPrefab;
    public bool hit = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //InputGetKey関数により、押されるキーを検知
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-0.03f, 0, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(0.03f, 0, 0);
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0, 0.03f, 0);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, -0.03f, 0);
        }

        //Mathf.Clamp関数(引数に指定した座標以上を検知した場合、それ以上値を更新しない)
        transform.position = new Vector2(
        Mathf.Clamp(transform.position.x, -4.01f, 4.10f),
        Mathf.Clamp(transform.position.y, -4.15f, 4.11f)
        );

        //GetKeyDown関数はGetKey関数と違って、キーが押下された時に一度だけtrueになる関数
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(bulletPrefab, transform.position, Quaternion.identity);
        }
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        hit = true;
    }
}

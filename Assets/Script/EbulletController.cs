using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EbulletController : MonoBehaviour
{
    GameObject player;
    //PlayerContoroller pscript;

   [SerializeField] private Transform playertrans;                        //追いかける対象のtransfrom
   [SerializeField] private float bullretspeed;        //弾の速度
   [SerializeField] private float limitspeed;          //弾のTransfrom

    private Rigidbody2D rb;
    private Transform bullettrans;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        //pscript = player.GetComponent<PlayerContoroller>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -5)
        {
          Destroy(gameObject);
        }
        //else if (transform.position.x < 4.4)
        //{
        //    Destroy(gameObject);
        //}
        //else if (transform.position.x < -4.6)
        //{
        //    Destroy(gameObject);
        //}
    }

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        bullettrans = GetComponent<Transform>();
    }

    private void FixedUpdate()
    {
        Vector3 vector3 = player.transform.position - bullettrans.position;
        rb.AddForce(vector3.normalized * bullretspeed);

        float speedxtemp = Mathf.Clamp(rb.velocity.x, -limitspeed, limitspeed);
        float speedytemp = Mathf.Clamp(rb.velocity.y, -limitspeed, limitspeed);
        rb.velocity = new Vector3(speedxtemp, speedytemp);
     
    }
}

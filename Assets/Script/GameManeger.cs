using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameManeger : MonoBehaviour
{
    GameObject hitpoint;
    GameObject hitpoint2;
    GameObject hitpoint3;

    public int hpflag = 3;
    // Start is called before the first frame update
    void Start()
    {
        this.hitpoint = GameObject.Find("HitPoint");
        this.hitpoint2 = GameObject.Find("HitPoint (1)");
        this.hitpoint3 = GameObject.Find("HitPoint (2)");
    }

    
    public void DecreaseHp()
    {
        // Destroy(this.hitpoint.GetComponent<Image>());
        if (hitpoint.activeSelf)
        {
            this.hitpoint.SetActive(false);
            hpflag -= 1;
        }
        else if (hitpoint2.activeSelf)
        {
            this.hitpoint2.SetActive(false);
            hpflag -= 1;
        }
        else
        {
            this.hitpoint3.SetActive(false);
            hpflag -= 1;
        }
    }
    // Update is called once per frame
    void Update()
    {
       if(hpflag == 0)
        {
            SceneManager.LoadScene("GameOver");
        }
    }
}

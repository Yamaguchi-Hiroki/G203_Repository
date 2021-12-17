using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HitPointController : MonoBehaviour
{
 
    // Start is called before the first frame update
    void Start()
        
    {

    }

    // Update is called once per frame
   public  void Update()
    {
        
    }
    public void DecreaseHp()
    {
        Destroy(this.gameObject);
    }
}

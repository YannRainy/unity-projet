using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemymove : MonoBehaviour
{
   
    void Start()
    {
        
    }

    
    void Update()
    {
       








    }


    void OnCollisionEnter2D(Collision2D col)
    {

        var vu = GetComponent<Rigidbody2D>();
        var decor = col.gameObject.GetComponent<jeandecor>();
        if (decor != null)
        {
            if (decor.plancher)
            {
                vu.velocity = new Vector2(0, 20f);
            }

        }


    }



}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flyenemy : MonoBehaviour
{
    private Vector2 avance = new Vector2(10, 0f);
    private Vector2 recule = new Vector2(-10, 0f);
    private bool direction = true;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var vu = GetComponent<Rigidbody2D>();
        if (direction == true)
        {
            vu.velocity = avance;

        }
        if (direction == false)
        {
            vu.velocity = recule;

        }



    }



    void OnCollisionEnter2D(Collision2D col)
    {

        var vu = GetComponent<Rigidbody2D>();
        vu.velocity = new Vector2(-100, 0f);
        var decor = col.gameObject.GetComponent<jeandecor>();
        if (decor != null)
        {
            if (decor.plancher)
            {
                if (direction == true)
                {
                    direction = false;


                }
                if (direction == false)
                    {
                    direction = true;
    

                }
                vu.velocity = new Vector2(-20, 0f);


            }

        }


    }

}

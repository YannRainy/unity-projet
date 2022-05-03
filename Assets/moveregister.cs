using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveregister : MonoBehaviour
{
    
    private Vector3 x = new Vector3(1,1,1);
    public List<Vector3> liste = new List<Vector3>();
    void Start()
    {

        liste.Clear();
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        var actif = gameObject.GetComponent<Jeanmove>;
        if (activated == true)
        {
            x = gameObject.transform.position;
            liste.Add(x);

        }
    }
}

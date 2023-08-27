using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class check : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if(transform.position.z<=10)
        {
            //Debug.Log(transform.position.z);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

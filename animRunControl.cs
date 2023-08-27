using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animRunControl : MonoBehaviour
{
    // Start is called before the first frame update
    Animator anim1;
    public GameObject way;
    void Start()
    {
        anim1 = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (way.transform.position.z >= 120.0)
        {
            anim1.SetBool("isRunning", true);
        }
    }
}

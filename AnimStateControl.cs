using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimStateControl : MonoBehaviour
{
    // Start is called before the first frame update
    Animator anim;
    public GameObject way;
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (way.transform.position.z >= 125.0)
        {
            anim.SetBool("isWalking", true);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using OculusSampleFramework;
using UnityEngine.SceneManagement;

public class newControl : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject way;
    public string Loadlevel;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (way.transform.position.z >= 122.0)
        {
            Invoke("LoadSceneNow", 15);

        }
    }

    public void LoadSceneNow()
    {
        SceneManager.LoadScene(Loadlevel);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using OculusSampleFramework;
using UnityEngine.SceneManagement;

public class NewSceneControl : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject way;
    public GameObject savier;
    public string Loadlevel;
    void Start()
    {
        savier.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (way.transform.position.z >= 2.5)
        {
            Invoke("savierStart", 30);
            Invoke("LoadSceneNow", 40);

        }
    }

    public void LoadSceneNow()
    {
        SceneManager.LoadScene(Loadlevel);
    }
    public void savierStart()
    {
        savier.SetActive(true);
    }
}

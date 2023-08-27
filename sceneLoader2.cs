using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using OculusSampleFramework;
using UnityEngine.SceneManagement;

public class sceneLoader2 : MonoBehaviour
{
    // Start is called before the first frame update
    public string Loadlevel;
    public UnityEvent proximityEvent;
    GameObject startButtonProximityObject;

    public Renderer rend;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<ButtonController>().InteractableStateChanged.AddListener(InitiateEvent);

        //Get start button refrence
        startButtonProximityObject = GameObject.FindGameObjectWithTag("StartButtonProximity");

        rend = GetComponent<Renderer>();

    }

    void InitiateEvent(InteractableStateArgs state)
    {
        if (state.NewInteractableState == InteractableState.ProximityState)
        {
            proximityEvent.Invoke();

            Invoke("sceneStart", 2);
            rend.enabled = false;
            startButtonProximityObject.SetActive(false);
        }
    }

    public void sceneStart()
    {
        SceneManager.LoadScene(Loadlevel);
    }


}

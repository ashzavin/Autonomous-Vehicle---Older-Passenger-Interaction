using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using OculusSampleFramework;
using UnityEngine.Events;
using UnityStandardAssets.Vehicles.Car;

public class buttonlist : MonoBehaviour
{
    public UnityEvent proximityEvent;
    public UnityEvent contactEvent;
    public UnityEvent actionEvent;
    public UnityEvent defaultEvent;
    public GameObject ahare;
    public GameObject ahare2;

    // Start is called before the first frame update
    void Start()
    {

        //q.SetActive(false);

        GetComponent<ButtonController>().InteractableStateChanged.AddListener(InitiateEvent);
    }

    void InitiateEvent(InteractableStateArgs state)
    {

        if (state.NewInteractableState == InteractableState.ProximityState)
        {
            proximityEvent.Invoke();
            Invoke("playMusicNow", 4);
        }

        else if (state.NewInteractableState == InteractableState.ContactState)
        {


        }
        else if (state.NewInteractableState == InteractableState.ActionState)
        {
            actionEvent.Invoke();
        }

    }
    
    public void playMusicNow()
    {
        ahare.SetActive(true);
        Invoke("playMusicNow1", 3);
    }

    public void playMusicNow1()
    {
        ahare2.SetActive(true);

    }
}

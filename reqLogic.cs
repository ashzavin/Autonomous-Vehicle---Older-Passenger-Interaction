using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using OculusSampleFramework;
using UnityEngine.Events;
using UnityStandardAssets.Vehicles.Car;

public class reqLogic : MonoBehaviour
{
    public UnityEvent proximityEvent;
    public UnityEvent contactEvent;
    public UnityEvent actionEvent;
    public UnityEvent defaultEvent;

    float simResetTime = 33.0f;

    GameObject startButtonProximityObject;
    CarUserControl carControl;

    float startTime;
    public Renderer rend;
    Rigidbody reqnow;
    int ran;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<ButtonController>().InteractableStateChanged.AddListener(InitiateEvent);
        

        //Get start button refrence
        startButtonProximityObject = GameObject.FindGameObjectWithTag("StartButtonProximity");
        rend = GetComponent<Renderer>();

        //Get vehicle refrence
        GameObject carObject = GameObject.FindGameObjectWithTag("reqPlayer");
        reqnow = carObject.GetComponent<Rigidbody>();
        carControl = (CarUserControl)carObject.GetComponent("CarUserControl");

    }

    void InitiateEvent(InteractableStateArgs state)
    {
        if (state.NewInteractableState == InteractableState.ProximityState)
        {
            proximityEvent.Invoke();

            //Dissable start button
            startTime = Time.time;
            rend.enabled = false;
            startButtonProximityObject.SetActive(false);

            //Start vehicle
            carControl.startTime = Time.time;

            reqnow.useGravity = true;
            carControl.carStart();

        }
    }

    // Update is called once per frame
    void Update()
    {

        if (Time.time > startTime + simResetTime)
        {


            int trck = carControl.reset();
            if (trck == 1)
            {
                rend.enabled = true;
                startButtonProximityObject.SetActive(true);
            }

        }
    }
    void changefspeed()
    {
        carControl.interactWithVehicle();
    }
}

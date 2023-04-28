using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ControllersBehaviour : MonoBehaviour
{
    private List<UnityEngine.XR.InputDevice> devices;
    private bool leftPrimaryTouch, leftPrimaryButton;
    private bool leftSecundaryTouch, leftSecundaryButton;
    private bool rightPrimaryTouch, rightPrimaryButton;
    private bool rightSecundaryTouch, rightSecundaryButton;
    private Vector2 leftPrimaryAxis, rightPrimaryAxis;
    private float lefttrigger, leftgrip, righttrigger, rightgrip;
    private bool leftTriggerButton, leftGripButton, rightTriggerButton, rightGripButton;
    private bool menuButton;
    private bool leftPrimaryAxisClick, rightPrimaryAxisClick;
    private bool leftPrimaryAxisTouch, rightPrimaryAxisTouch;

    // Start is called before the first frame update
    void Start()
    {
        //Aqui cogemos los dipositivos y los guardamos en una lista
        devices = new List<UnityEngine.XR.InputDevice>();
        UnityEngine.XR.InputDevices.GetDevices(devices);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MuestraDipositivos()
    {
        //Muestra todas las caracteristicas de todos los dipositivos
        foreach (var device in devices)
        {
            Debug.Log(string.Format("Device name '{0}' has characteristics '{1}'", device.name, device.characteristics.ToString()));
        }
    }

    private void detectTouchPrimaryButton()
    {
        //PrimaryTouch detecta si se ha tocado (no pulsado) los botones X/A
        devices[1].TryGetFeatureValue(UnityEngine.XR.CommonUsages.primaryTouch, out leftPrimaryTouch);
        devices[2].TryGetFeatureValue(UnityEngine.XR.CommonUsages.primaryTouch, out rightPrimaryTouch);
    }

    private void detectTouchSecundaryButton()
    {
        //PrimaryTouch detecta si se ha tocado (no pulsado) los botones Y/B
        devices[1].TryGetFeatureValue(UnityEngine.XR.CommonUsages.secondaryTouch, out leftSecundaryTouch);
        devices[2].TryGetFeatureValue(UnityEngine.XR.CommonUsages.secondaryTouch, out rightSecundaryTouch);
    }

    private void detectPressPrimaryButton()
    {
        //PrimaryTouch detecta si hemos pulsado los botones X/A
        devices[1].TryGetFeatureValue(UnityEngine.XR.CommonUsages.primaryButton, out leftPrimaryButton);
        devices[2].TryGetFeatureValue(UnityEngine.XR.CommonUsages.primaryButton, out rightPrimaryButton);
    }

    private void detectPressSecundaryButton()
    {
        //PrimaryTouch detecta si hemos pulsado los botones Y/B
        devices[1].TryGetFeatureValue(UnityEngine.XR.CommonUsages.secondaryButton, out leftSecundaryButton);
        devices[2].TryGetFeatureValue(UnityEngine.XR.CommonUsages.secondaryButton, out rightSecundaryButton);
    }

    private void detectPrimaryAxis()
    {
        //Detecta la posicion de los joystick de los mandos
        devices[1].TryGetFeatureValue(UnityEngine.XR.CommonUsages.primary2DAxis, out leftPrimaryAxis);
        devices[2].TryGetFeatureValue(UnityEngine.XR.CommonUsages.primary2DAxis, out rightPrimaryAxis);
    }

    private void detectGripAndTrigger()
    {
        //Detecta si hemos tocado (no pulsado) los botones traseros y laterales de los mandos
        devices[1].TryGetFeatureValue(UnityEngine.XR.CommonUsages.grip, out leftgrip);
        devices[1].TryGetFeatureValue(UnityEngine.XR.CommonUsages.trigger, out lefttrigger);

        devices[2].TryGetFeatureValue(UnityEngine.XR.CommonUsages.grip, out rightgrip);
        devices[2].TryGetFeatureValue(UnityEngine.XR.CommonUsages.trigger, out righttrigger);
    }

    private void detectGripAndTriggerButtons()
    {
        //Detecta si hemos pulsado los botones traseros y laterales de los mandos
        devices[1].TryGetFeatureValue(UnityEngine.XR.CommonUsages.gripButton, out leftGripButton);
        devices[1].TryGetFeatureValue(UnityEngine.XR.CommonUsages.triggerButton, out leftTriggerButton);

        devices[2].TryGetFeatureValue(UnityEngine.XR.CommonUsages.gripButton, out rightGripButton);
        devices[2].TryGetFeatureValue(UnityEngine.XR.CommonUsages.triggerButton, out rightTriggerButton);
    }

    private void detectMenuButton()
    {
        devices[1].TryGetFeatureValue(UnityEngine.XR.CommonUsages.menuButton, out menuButton);
    }

    private void detectPrimaryAxisClick()
    {
        devices[1].TryGetFeatureValue(UnityEngine.XR.CommonUsages.primary2DAxisClick, out leftPrimaryAxisClick);
        devices[2].TryGetFeatureValue(UnityEngine.XR.CommonUsages.primary2DAxisClick, out rightPrimaryAxisClick);
    }

    private void detectPrimaryAxisTouch()
    {
        devices[1].TryGetFeatureValue(UnityEngine.XR.CommonUsages.primary2DAxisTouch, out leftPrimaryAxisTouch);
        devices[2].TryGetFeatureValue(UnityEngine.XR.CommonUsages.primary2DAxisTouch, out rightPrimaryAxisTouch);
    }

    public void showTouchPrimary()
    {
        //aqui pondremos la informacion en el escenario
    }
}

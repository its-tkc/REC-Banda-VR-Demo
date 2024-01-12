using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputTest : MonoBehaviour, XRIDefaultInputActions.IXRIRightHandInteractionActions
{
    private XRIDefaultInputActions actions;
    public static InputTest Instance;
    int count = 0;
    bool isPressed = false;
    float buttonValue = 0f;
    public GameObject rightcontroller, bullet;
    private void OnEnable()
    {
        if(actions == null)
        {
            actions = new XRIDefaultInputActions();
            actions.XRIRightHandInteraction.SetCallbacks(this);
        }
        actions.XRIRightHandInteraction.Enable();
    }
    private void OnDisable()
    {
        actions.XRIRightHandInteraction.Disable();
    }

    private void Awake()
    {
        Instance = this;
    }
    IEnumerator Printer()
    {
        if (!isPressed)
        {
            Instantiate(bullet, rightcontroller.GetComponent<LineRenderer>().GetPosition(0), Quaternion.identity);
            isPressed = true;
        }
        yield return new WaitForSeconds(0.1f);
        isPressed = false;
        StopCoroutine(nameof(Printer));
    }
    //-----------------------------------------------------------------------------------------------------------
    public void OnActivate(InputAction.CallbackContext context)
    {
        StartCoroutine(nameof(Printer));
    }
    

    public void OnActivateValue(InputAction.CallbackContext context)
    {
        
    }

    public void OnRotateAnchor(InputAction.CallbackContext context)
    {
        
    }

    public void OnSelect(InputAction.CallbackContext context)
    {
        
    }

    public void OnSelectValue(InputAction.CallbackContext context)
    {
        
    }

    public void OnTranslateAnchor(InputAction.CallbackContext context)
    {
        
    }

    public void OnUIPress(InputAction.CallbackContext context)
    {
        
    }

    public void OnUIPressValue(InputAction.CallbackContext context)
    {
        
    }
}

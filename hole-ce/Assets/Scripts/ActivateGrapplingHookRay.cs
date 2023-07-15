using UnityEngine;
using UnityEngine.InputSystem;

public class ActivateGrapplingHookRay : MonoBehaviour
{
    public GameObject leftGrappleRay;
    public GameObject rightGrappleRay;

    public InputActionProperty leftGripAction;
    public InputActionProperty rightGripAction;

    void Update()
    {
        leftGrappleRay.SetActive(leftGripAction.action.ReadValue<float>() > 0.5f);
        rightGrappleRay.SetActive(rightGripAction.action.ReadValue<float>() > 0.5f);
    }
}

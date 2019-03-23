using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleportControl : MonoBehaviour
{
    public VRTeleporter teleporter;
    public GameObject teleport_gameObject;

    public GameObject rightHand;
    public GameObject leftHand;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Oculus_CrossPlatform_PrimaryThumbstick"))
        {
            teleport_gameObject.transform.SetParent(leftHand.transform);
            teleporter.ToggleDisplay(true);
        }

        if (Input.GetButtonDown("Oculus_CrossPlatform_SecondaryThumbstick"))
        {
            teleport_gameObject.transform.SetParent(rightHand.transform);
            teleporter.ToggleDisplay(true);
        }


        if (Input.GetButtonUp("Oculus_CrossPlatform_PrimaryThumbstick") || Input.GetButtonUp("Oculus_CrossPlatform_SecondaryThumbstick"))
        {
            teleporter.Teleport();
            teleporter.ToggleDisplay(false);
            teleport_gameObject.transform.SetParent(teleport_gameObject.transform);
        }
    }
}

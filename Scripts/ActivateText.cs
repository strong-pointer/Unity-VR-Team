using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ActivateText : MonoBehaviour
{
    public GameObject GunText, GlassesText, ClockText;
    public XRGrabInteractable gun, glasses, clock;
    public XRSocketInteractor glassSock, clockSock;
    public XRDirectInteractor rHand, lHand;
    void Update()
    {
        if (rHand.IsSelecting(glasses) || lHand.IsSelecting(glasses) || glassSock.interactablesSelected.Count != 0)
        {
            GlassesText.SetActive(true);
        }
        else
        {
            GlassesText.SetActive(false);
        }

        if (rHand.IsSelecting(gun) || lHand.IsSelecting(gun))
        {
            GunText.SetActive(true);
        }
        else
        {
            GunText.SetActive(false);
        }

        if (rHand.IsSelecting(clock) || lHand.IsSelecting(clock) || clockSock.interactablesSelected.Count != 0)
        {
            ClockText.SetActive(true);
        }
        else
        {
            ClockText.SetActive(false);
        }
    }
}

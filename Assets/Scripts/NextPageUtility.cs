using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
/**
 * @author Chase Franklin
 * Handles executing a next page selection and selection icon
 */
public class NextPageUtility : MonoBehaviour
{
    public Image fill;
    public GameObject canvasIcon;
    public float currentValue, maxValue;
    private float observedTime;

    public GameObject[] activate, deactivate, delayedActivate, delayedDeactivate;
    [SerializeField] private float delayTime = 1.0f;

    private void OnMouseEnter()
    {
        observedTime = Time.time;
        canvasIcon.SetActive(true);
    }
    private void OnMouseOver()
    {
        currentValue = Time.time - observedTime;
        fill.fillAmount = Normalize();
        if (currentValue > maxValue)
        {
            Action();
        }
    }
    private void OnMouseExit()
    {
        currentValue = 0;
        canvasIcon.SetActive(false);
    }

    private float Normalize()
    {
        return currentValue / maxValue;
    }

    private void Action()
    {
        //Trigger Utility
        if (activate.Length > 0)
        {
            for (int i = 0; i < activate.Length; i++)
            {
                activate[i].SetActive(true);
            }
        }

        if (deactivate.Length > 0)
        {
            for (int i = 0; i < deactivate.Length; i++)
            {
                deactivate[i].SetActive(false);
            }
        }

        if (delayedDeactivate.Length > 0)
        {
            Invoke("PerformDelayedDeactivate", delayTime);
        }

        if (delayedActivate.Length > 0)
        {
            Invoke("PerformDelayedActivate", delayTime);
        }
    }

    private void PerformDelayedDeactivate()
    {
        for (int i = 0; i < delayedDeactivate.Length; i++)
        {
            delayedDeactivate[i].SetActive(false);
        }
    }

    private void PerformDelayedActivate()
    {
        for (int i = 0; i < delayedActivate.Length; i++)
        {
            delayedActivate[i].SetActive(true);
        }
    }
}

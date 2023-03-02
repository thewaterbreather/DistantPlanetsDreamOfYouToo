using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class FrameTrigger : MonoBehaviour
{
    public GameObject[] activate;
    public GameObject[] deactivate;
    public GameObject[] delayedActivate;
    public GameObject[] delayedDeactivate;
    [SerializeField] private float delayTime = 1.0f;


    void OnMouseOver()
    {
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

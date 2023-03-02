using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelTriggerNext : MonoBehaviour
{
    public GameObject[] activate;
    public GameObject[] deactivate;
    public GameObject[] activateNext;

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
    }
}

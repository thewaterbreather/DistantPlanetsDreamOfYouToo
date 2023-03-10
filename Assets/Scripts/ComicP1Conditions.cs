using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComicP1Conditions : MonoBehaviour
{
    public GameObject NextIcon;
    public GameObject[] observedFrames;
    private FrameUtility frameScript;

    private bool observed1, observed2, observed3, observed4, observed5;
    private bool nextOption = false;

    void Update()
    {
        if (!nextOption && observedFrames.Length > 0)
        {
            //observed frames update
            for (int i = 0; i < observedFrames.Length; i++)
            {
                frameScript = observedFrames[i].GetComponent<FrameUtility>();
                if (frameScript.observed)
                {
                    if (frameScript.id == 1)
                    { observed1 = true; }
                    if (frameScript.id == 2)
                    { observed2 = true; }
                    if (frameScript.id == 3)
                    { observed3 = true; }
                    if (frameScript.id == 4)
                    { observed4 = true; }
                    if (frameScript.id == 5)
                    { observed5 = true; }
                }
            }
            //page specific conditions
            if (observed1 && observed2 && observed3 && observed4 && observed5)
            {
                nextOption = true;
            }
        }
        else
        {
            NextIcon.SetActive(true);
        }
    }
}

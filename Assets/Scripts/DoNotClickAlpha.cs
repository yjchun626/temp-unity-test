using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DoNotClickAlpha : MonoBehaviour
{
    public Button imgButton;
    // Start is called before the first frame update
    void Start()
    {
        imgButton.GetComponent<Image>().alphaHitTestMinimumThreshold = 0.2f;
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Interactions : MonoBehaviour
{  
    // instantiate objects
    public GameObject outsideCamera;
    public GameObject insideCamera;

    // change the camera view by clicking the change view button
    public void ChangeView()
    {
       if (outsideCamera.activeSelf)
       {
            outsideCamera.SetActive(false);
            insideCamera.SetActive(true);
       }
       else
       {
            outsideCamera.SetActive(true);
            insideCamera.SetActive(false);
       }
    }
}

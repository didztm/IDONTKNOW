using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AndroidExplore : MonoBehaviour
{
	#region Private and Protected Members

    #endregion
    #region Public Members

    #endregion

    #region Public void

    #endregion

    #region System

    void Start ()
    {
        Debug.Log(Input.touchCount);
        Debug.Log(Input.location.lastData.latitude);
        Debug.Log(Input.location.lastData.longitude);
        Debug.Log(Input.compass);
       // Debug.Log(Input.);
    }

    void Update ()
    {
        	
    }

    #endregion

    #region Tools Debug and Utility

    #endregion

    
}

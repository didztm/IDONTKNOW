using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AndroidExplore : MonoBehaviour
{
    #region Private and Protected Members

    #endregion
    #region Public Members
    public Text m_text;
    public Transform m_terrain;
    #endregion

    #region Public void

    #endregion

    #region System
    private void OnGUI()
    {
    }
    public void Start()
    {/*
        bool isPlayerPressing = false;
#if UNITY_ANDROID && !UNITY_EDITOR
        isPlayerPressing = Input.touchCount > 0;
#else
        isPlayerPressing = Input.GetMouseButton(0);
#endif


        Debug.Log(Input.touchCount); // Number of finger on screne
        Debug.Log(Input.touches[0].position); // De 0,0 à 1,1 en pixel

        Debug.Log(Input.acceleration); // Accélration
        Debug.Log(Input.compass); // direction magnétique

        Debug.Log(Input.gyro); // direction magnétique
        Debug.Log(Input.location.lastData.latitude);

        */

    }
    



    
    void Update ()
    {
        //m_text.text = FingerTouch();

    }

    #endregion

    #region Tools Debug and Utility

    public string FingerTouch()
    {

        string str = "";
        if (Input.touchCount > 0)
        {
            switch (Input.touchCount)
            {
                case 1:
                    str = "Un doigt";
                    break;
                case 2:
                    str = "Deux doigts";
                    break;
                case 3:
                    str = "trois doigts";
                    break;

                default:
                    str = "";
                    break;
            }

        }
        return str;
    }
    public void GyroMouv()
    {
        Gyro g = new Gyro();
        g.angle= Input.gyro.attitude.eulerAngles;
        g.rotationRate=Input.gyro.rotationRate;

        m_terrain.eulerAngles = g.angle;


    }
    #endregion


}

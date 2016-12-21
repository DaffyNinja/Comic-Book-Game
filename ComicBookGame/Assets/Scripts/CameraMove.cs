using UnityEngine;
using System.Collections;

public class CameraMove : MonoBehaviour
{

    public float zoomInMin;
    public float zoomInMax;
    [Space(5)]
    public float zoomOutMin;
    public float zoomOutMax;
    [Space(5)]
    public float zoomTime;
    float timer;
    [Space(5)]
    public bool zoomIn;
    public bool zoomOut;
    [Space(5)]
    bool isRedPanel;
    bool isYellowPanel;
    bool isGreenPanel;

    public bool isTransition;


    // Use this for initialization
    void Start()
    {
        isTransition = false;


    }

    // Update is called once per frame
    void Update()
    {
       



    }
}
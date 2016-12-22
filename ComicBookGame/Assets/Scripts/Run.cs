using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Run : MonoBehaviour
{

    Animator animate;

    public float runTime;
    float timer;

    bool pressed;

    // Use this for initialization
    void Start()
    {
        animate = GetComponent<Animator>();

        animate.enabled = false;

        timer = 0;

    }

    // Update is called once per frame
    void Update()
    {
        if (pressed)
        {
            animate.enabled = true;

            timer += Time.deltaTime;

            if (timer >= runTime)
            {
                print("Done");
            }
        }
        else
        {
            animate.enabled = false;

            timer = 0;
        }

    }

    private void OnMouseDown()
    {
        pressed = true;
    }

    private void OnMouseUp()
    {
        pressed = false;
    }

}

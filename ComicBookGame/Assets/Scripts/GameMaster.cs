using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMaster : MonoBehaviour
{

    public GameObject[] redPanels;
    public GameObject[] yellowPanels;
    public GameObject[] greenPanels;
    [Space(10)]
    public int panelArrayNum;
    [Space(5)]
    public bool isRed;
    public bool isYellow;
    public bool isGreen;
    [Space(5)]
    public bool canPlay;
    public bool completedActivity;
    [Space(5)]
    public float changeTime;
    float timer;
    [Space(5)]
    public int panelNum;

    public CameraMove camMove;

    // Use this for initialization
    void Start()
    {
        // isRed = true;

        // panelNum = 0;
        panelArrayNum = 0;

    }

    // Update is called once per frame
    void Update()
    {
    

        if (isRed == true && isYellow == false && isGreen == false && panelNum == 0)
        {
            camMove.gameObject.transform.position = new Vector3(redPanels[panelArrayNum].transform.position.x, redPanels[panelArrayNum].transform.position.y, redPanels[panelArrayNum].transform.position.z - 5);

            canPlay = false;
        }
        else if (isYellow == true && isRed == false && isGreen == false && panelNum == 1)
        {
            // camMove.transform.position = Vector3.Lerp(transform.position, new Vector3(yellowPanels[0].transform.position.x, yellowPanels[0].transform.position.y, yellowPanels[0].transform.position.z - 5), 0.5f);

            camMove.gameObject.transform.position = new Vector3(yellowPanels[panelArrayNum].transform.position.x, yellowPanels[panelArrayNum].transform.position.y, yellowPanels[panelArrayNum].transform.position.z - 5);

            canPlay = false;
        }
        else if (isGreen == true && isRed == false && isYellow == false && panelNum == 2)
        {
            // camMove.transform.position = Vector3.Lerp(transform.position, camMove.gameObject.transform.position = new Vector3(greenPanels[0].transform.position.x, greenPanels[0].transform.position.y, greenPanels[0].transform.position.z - 5),0.5f);

            camMove.gameObject.transform.position = new Vector3(greenPanels[panelArrayNum].transform.position.x, greenPanels[panelArrayNum].transform.position.y, greenPanels[panelArrayNum].transform.position.z - 5);

            canPlay = true;
        }

        //if (camMove.transform.position == new Vector3(redPanels[0].transform.position.x, redPanels[0].transform.position.y, redPanels[0].transform.position.z - 5))
        //{
        //    camMove.isTransition = false;
        //}
        //else
        //{
        //    camMove.isTransition = true;
        //}


        if (Input.GetKeyDown(KeyCode.Space) & canPlay == false|| Input.touchCount > 0 && canPlay == false)
        {
            panelNum += 1;

        }

        switch (panelNum)
        {
            case 1:
                isYellow = true;
                isRed = false;
                break;
            case 2:
                isGreen = true;
                isYellow = false;
                break;
            default:
                isRed = true;
                isYellow = false;
                isGreen = false;
                panelNum = 0;

                break;
        }


        if (canPlay)
        {
            if (completedActivity)
            {
                print("Completed");

                panelArrayNum += 1;
                panelNum += 1;
                canPlay = false;
                completedActivity = false;

            }

        }
        else
        {
            completedActivity = false;
        }


        //Input
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }


    }
}

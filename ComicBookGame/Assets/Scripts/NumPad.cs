using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumPad : MonoBehaviour
{

    public int correctNum1;
    public int correctNum2;
    public int correctNum3;
    public int correctNum4;
    [Space(5)]
    public bool isInput1;
    public int inputNum1;
    [Space(5)]
    public bool isInput2;
    public int inputNum2;
    [Space(5)]
    public bool isInput3;
    public int inputNum3;
    [Space(5)]
    public bool isInput4;
    public int inputNum4;

    bool runCheck;

    GameMaster gMaster;

    // Use this for initialization
    void Start()
    {
        gMaster = GetComponent<GameMaster>();

        isInput1 = true;

    }

    // Update is called once per frame
    void Update()
    {

        if (runCheck)
        {
            print("Input Num = " + inputNum1 + inputNum2 + inputNum3 + inputNum4);

            if (inputNum1 == correctNum1 && inputNum2 == correctNum2 && inputNum3 == correctNum3 && inputNum4 == correctNum4)
            {
                print("UNLOCK");
            }
            else
            {
                print("Wrong");

                inputNum1 = 0;
                inputNum2 = 0;
                inputNum3 = 0;
                inputNum4 = 0;

                isInput1 = true;

                runCheck = false;
            }
        }

    }

    public void Num1()
    {

        if (isInput1)
        {
            inputNum1 = 1;

            isInput2 = true;
            isInput1 = false;
        }
        else if (isInput2)
        {
            inputNum2 = 1;

            isInput3 = true;
            isInput2 = false;
        }
        else if (isInput3)
        {
            inputNum3 = 1;

            isInput4 = true;
            isInput3 = false;
        }
        else if (isInput4)
        {
            inputNum4 = 1;

            runCheck = true;
            isInput4 = false;
        }


        //print("1");
    }

    public void Num2()
    {
        // print("2");

        if (isInput1)
        {
            inputNum1 = 2;

            isInput2 = true;
            isInput1 = false;
        }
        else if (isInput2)
        {
            inputNum2 = 2;

            isInput3 = true;
            isInput2 = false;
        }
        else if (isInput3)
        {
            inputNum3 = 2;

            isInput4 = true;
            isInput3 = false;
        }
        else if (isInput4)
        {
            inputNum4 = 2;

            runCheck = true;
            isInput4 = false;
        }
    }
    public void Num3()
    {
        //  print("3");

        if (isInput1)
        {
            inputNum1 = 3;

            isInput2 = true;
            isInput1 = false;
        }
        else if (isInput2)
        {
            inputNum2 = 3;

            isInput3 = true;
            isInput2 = false;
        }
        else if (isInput3)
        {
            inputNum3 = 3;

            isInput4 = true;
            isInput3 = false;
        }
        else if (isInput4)
        {
            inputNum4 = 3;

            runCheck = true;
            isInput4 = false;
        }
    }
    public void Num4()
    {
        //print("4");

        if (isInput1)
        {
            inputNum1 = 4;

            isInput2 = true;
            isInput1 = false;
        }
        else if (isInput2)
        {
            inputNum2 = 4;

            isInput3 = true;
            isInput2 = false;
        }
        else if (isInput3)
        {
            inputNum3 = 4;

            isInput4 = true;
            isInput3 = false;
        }
        else if (isInput4)
        {
            inputNum4 = 4;

            runCheck = true;
            isInput4 = false;
        }
    }
    public void Num5()
    {
        // print("5");

        if (isInput1)
        {
            inputNum1 = 5;

            isInput2 = true;
            isInput1 = false;
        }
        else if (isInput2)
        {
            inputNum2 = 5;

            isInput3 = true;
            isInput2 = false;
        }
        else if (isInput3)
        {
            inputNum3 = 5;

            isInput4 = true;
            isInput3 = false;
        }
        else if (isInput4)
        {
            inputNum4 = 5;

            runCheck = true;
            isInput4 = false;
        }
    }
    public void Num6()
    {
        // print("6");

        if (isInput1)
        {
            inputNum1 = 6;

            isInput2 = true;
            isInput1 = false;
        }
        else if (isInput2)
        {
            inputNum2 = 6;

            isInput3 = true;
            isInput2 = false;
        }
        else if (isInput3)
        {
            inputNum3 = 6;

            isInput4 = true;
            isInput3 = false;
        }
        else if (isInput4)
        {
            inputNum4 = 6;

            runCheck = true;
            isInput4 = false;
        }
    }
    public void Num7()
    {
        // print("7");

        if (isInput1)
        {
            inputNum1 = 7;

            isInput2 = true;
            isInput1 = false;
        }
        else if (isInput2)
        {
            inputNum2 = 7;

            isInput3 = true;
            isInput2 = false;
        }
        else if (isInput3)
        {
            inputNum3 = 7;

            isInput4 = true;
            isInput3 = false;
        }
        else if (isInput4)
        {
            inputNum4 = 7;

            runCheck = true;
            isInput4 = false;
        }
    }
    public void Num8()
    {
        // print("8");

        if (isInput1)
        {
            inputNum1 = 8;

            isInput2 = true;
            isInput1 = false;
        }
        else if (isInput2)
        {
            inputNum2 = 8;

            isInput3 = true;
            isInput2 = false;
        }
        else if (isInput3)
        {
            inputNum3 = 8;

            isInput4 = true;
            isInput3 = false;
        }
        else if (isInput4)
        {
            inputNum4 = 8;

            runCheck = true;
            isInput4 = false;
        }
    }

    public void Num9()
    {
        // print("9");

        if (isInput1)
        {
            inputNum1 = 9;

            isInput2 = true;
            isInput1 = false;
        }
        else if (isInput2)
        {
            inputNum2 = 9;

            isInput3 = true;
            isInput2 = false;
        }
        else if (isInput3)
        {
            inputNum3 = 9;

            isInput4 = true;
            isInput3 = false;
        }
        else if (isInput4)
        {
            inputNum4 = 9;

            runCheck = true;
            isInput4 = false;
        }
    }
}

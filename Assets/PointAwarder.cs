using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointAwarder : MonoBehaviour
{
    public bool Sequence1;
    public bool Sequence2;
    public bool Sequence3;
    public bool Sequence4;
    public bool Sequence5;
    public bool Sequence6;

    public bool Sequence12_press1;

    public bool Sequence1_press2;
    public bool Sequence1_press3;

    public bool Sequence2_press2;
    public bool Sequence2_press3;

    public bool Sequence34_press1;

    public bool Sequence3_press2;
    public bool Sequence3_press3;

    public bool Sequence4_press1;
    public bool Sequence4_press2;
    public bool Sequence4_press3;

    public bool Sequence56_press1;

    public bool Sequence5_press2;
    public bool Sequence5_press3;

    public bool Sequence6_press2;
    public bool Sequence6_press3;

    public float startTime = 0f;
    public float timer = 0f;

    public float holdTimePress = 0.1f;
    public float holdTime1 = 1.0f;
    public float holdTime2 = 2.0f;

    // ***1***               if ((timer < (startTime + holdTimePress) && Input.GetKeyUp(KeyCode.Space)) && (Sequence34_press1 == false) && (Sequence56_press1 == false))
    // ***2***               if ((timer > (startTime + holdTime1) && (timer < (startTime + holdTime2) && Input.GetKeyUp(KeyCode.Space)) && (Sequence12_press1 == false) && (Sequence56_press1 == false)))
    // ***3***               if ((timer < (startTime + holdTime2) && Input.GetKeyUp(KeyCode.Space)) && (Sequence12_press1 == false) && (Sequence34_press1 == false))

    // Start is called before the first frame update
    void Start()
    {

    }

    //Update is called once per frame
    void threefour()
    {
        Sequence34_press1 = true;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            startTime = Time.time;
            timer = startTime;
        }

        if (Input.GetKey(KeyCode.Space))
        {
            timer += Time.deltaTime;
        }

        // ****************************************************************   1

        if ((timer < (startTime + holdTimePress) && Input.GetKeyUp(KeyCode.Space)) && (Sequence34_press1 == false) && (Sequence56_press1 == false))
        {
            timer = 0f;
            startTime = 0f;

            Sequence12_press1 = true;

            Debug.Log("Sequence12 Press1");
        }


        // 3-2

        if ((Sequence12_press1 == true) && (timer > (startTime + holdTime2) && Input.GetKeyUp(KeyCode.Space)) && (Sequence2_press2 == false))
        {
            timer = 0f;
            startTime = 0f;

            Sequence1_press2 = true;

            Debug.Log("Sequence1 Press2");
        }
        if ((Sequence1_press2 == true) && ((timer > (startTime + holdTime1) && (timer < (startTime + holdTime2) && Input.GetKeyUp(KeyCode.Space)) && (Sequence2_press2 == false))))
        {
            timer = 0f;
            startTime = 0f;

            Sequence1_press3 = true;

            Debug.Log("Sequence3 Press3");

        }
        if (Sequence12_press1 && Sequence1_press2 && Sequence1_press3 == true)
        {
            Sequence1 = true;
        }

        // 2-3

        if ((Sequence12_press1 == true) && ((timer > (startTime + holdTime1) && (timer < (startTime + holdTime2) && Input.GetKeyUp(KeyCode.Space)) && (Sequence1_press2 == false))))
        {
            timer = 0f;
            startTime = 0f;

            Sequence2_press2 = true;
            Debug.Log("Sequence2 Press2");
        }

        if ((Sequence2_press2 == true) && (timer > (startTime + holdTime2) && Input.GetKeyUp(KeyCode.Space)) && (Sequence1_press2 == false))
        {
            timer = 0f;
            startTime = 0f;

            Sequence2_press3 = true;
            Debug.Log("Sequence2 Press3");
        }

        if (Sequence12_press1 && Sequence2_press2 && Sequence2_press3 == true)
        {
            Sequence2 = true;
        }

        //***********************************************************************   2

        if ((timer > (startTime + holdTime1) && (timer < (startTime + holdTime2) && Input.GetKeyUp(KeyCode.Space)) && (Sequence12_press1 == false) && (Sequence56_press1 == false)))
        {
            timer = 0f;
            startTime = 0f;

            Invoke("threefour", 0.1f);

            Debug.Log("Sequence34 Press1");
        }

        // 3-1

        if ((Sequence34_press1 == true) && (timer > (startTime + holdTime2) && Input.GetKeyUp(KeyCode.Space)))
        {

            timer = 0f;
            startTime = 0f;

            Sequence3_press2 = true;

            Debug.Log("Sequence3 Press2");
        }
        if ((Sequence34_press1 == true) && (timer < (startTime + holdTimePress) && Input.GetKeyUp(KeyCode.Space)) && (Sequence4_press2 == false))
        {
            timer = 0f;
            startTime = 0f;

            Sequence3_press3 = true;

            Debug.Log("Sequence3 Press3");
        }

        if (Sequence34_press1 && Sequence3_press2 && Sequence3_press3 == true)
        {
            Sequence3 = true;
        }

        // 1 - 3

        if ((Sequence34_press1 == true) && (timer > (startTime + holdTime1) && (timer < (startTime + holdTime2) && Input.GetKeyUp(KeyCode.Space) && (Sequence3_press2 == false))))
        {
            timer = 0f;
            startTime = 0f;

            Sequence4_press2 = true;

            Debug.Log("Sequence4 Press2");
        }
        if ((timer < (startTime + holdTime2) && Input.GetKeyUp(KeyCode.Space)) && (Sequence4_press2 == true) && (Sequence3_press2 == false))
        {
            timer = 0f;
            startTime = 0f;

            Sequence4_press3 = true;

            Debug.Log("Sequence4 Press3");
        }

        if (Sequence34_press1 && Sequence3_press2 && Sequence3_press3 == true)
        {
            Sequence3 = true;
        }
    }
}
//        //3-2-1
//        if (timer > (startTime + holdTime2) && Input.GetKeyUp(KeyCode.Space))
//        {
//            timer = 0f;
//            startTime = 0f;

//            Sequence6_press1 = true;

//            if (Sequence6_press1 == true)
//            {

//                if (timer > (startTime + holdTime1) && Input.GetKeyUp(KeyCode.Space))
//                {
//                    timer = 0f;
//                    startTime = 0f;

//                    Sequence6_press2 = true;

//                    if (Sequence6_press2 == true)
//                    {

//                        if (timer > (startTime + holdTimePress) && Input.GetKeyUp(KeyCode.Space))
//                        {
//                            timer = 0f;
//                            startTime = 0f;

//                            Sequence6_press3 = true;

//                            if (Sequence6_press1 && Sequence6_press2 && Sequence6_press3 == true)
//                            {
//                                Sequence6 = true;

//                            }
//                        }
//                    }
//                }
//            }
//        }
//        else
//        {
//            //3-1-2
//            if (timer > (startTime + holdTime2) && Input.GetKeyUp(KeyCode.Space))
//            {
//                timer = 0f;
//                startTime = 0f;

//                Sequence5_press1 = true;

//                if (Sequence5_press1 == true)
//                {
//                    if (timer > (startTime + holdTime1) && Input.GetKeyUp(KeyCode.Space))
//                    {
//                        timer = 0f;
//                        startTime = 0f;

//                        Sequence5_press2 = true;

//                        if (Sequence5_press2 == true)
//                        {
//                            if (timer > (startTime + holdTimePress) && Input.GetKeyUp(KeyCode.Space))
//                            {
//                                timer = 0f;
//                                startTime = 0f;

//                                Sequence5_press3 = true;

//                                if (Sequence5_press1 && Sequence5_press2 && Sequence5_press3 == true)
//                                {
//                                    Sequence5 = true;

//                                }
//                            }
//                        }
//                    }
//                }
//            }
//            else
//            {
//                ;
//            }

//                                    }
//                                }
//                            }
//                        }
//                    }
//                }
//            }
//            else
//            {
//                ;
//            }

//            //2-1-3
//            if (timer > (startTime + holdTime1) && Input.GetKeyUp(KeyCode.Space))
//            {
//                timer = 0f;
//                startTime = 0f;

//                Sequence3_press1 = true;

//                if (Sequence3_press1 == true)
//                {
//                    if (timer > (startTime + holdTimePress) && Input.GetKeyUp(KeyCode.Space))
//                    {
//                        timer = 0f;
//                        startTime = 0f;

//                        Sequence3_press2 = true;

//                        if (Sequence3_press2 == true)
//                        {
//                            if (timer > (startTime + holdTime2) && Input.GetKeyUp(KeyCode.Space))
//                            {
//                                timer = 0f;
//                                startTime = 0f;

//                                Sequence3_press3 = true;

//                                if (Sequence3_press1 && Sequence3_press2 && Sequence3_press3 == true)
//                                {
//                                    Sequence3 = true;

//                                }
//                            }
//                        }
//                    }
//                }
//            }
//            else
//            {
//                ;
//            }

//            if ((Sequence1 == true) || (Sequence2 == true) || (Sequence3 == true) || (Sequence4 == true) || (Sequence5 == true) || (Sequence6 == true))
//            {

//                Sequence12_press1 = false;

//                Sequence1_press2 = false;
//                Sequence1_press3 = false;

//                Sequence2_press2 = false;
//                Sequence2_press3 = false;

//                Sequence3_press1 = false;
//                Sequence3_press2 = false;
//                Sequence3_press3 = false;

//                Sequence4_press1 = false;
//                Sequence4_press2 = false;
//                Sequence4_press3 = false;

//                Sequence5_press1 = false;
//                Sequence5_press2 = false;
//                Sequence5_press3 = false;

//                Sequence6_press1 = false;
//                Sequence6_press2 = false;
//                Sequence6_press3 = false;

//            }
//        }
//    }
//}
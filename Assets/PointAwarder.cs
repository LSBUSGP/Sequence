using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointAwarder : MonoBehaviour
{
    public string button = "Jump";
    public float[] pressDurations = new float[] { 0.5f, 1.0f, 2.0f };
    public List<string> sequences = new List<string>(
        new string[] { "123", "132", "213", "231", "312", "321" }
    );
    float heldTime = 0.0f;
    string sequence = "";

    void Update()
    {
        if (Input.GetButton(button))
        {
            heldTime += Time.deltaTime;
        }
        else if (Input.GetButtonUp(button))
        {
            // identify duration
            if (heldTime < pressDurations[0])
            {
                sequence += "1";
            }
            else if (heldTime < pressDurations[1])
            {
                sequence += "2";
            }
            else if (heldTime < pressDurations[2])
            {
                sequence += "3";
            }
            else
            {
                sequence += "X";
            }
            heldTime = 0.0f;

            // check sequence
            if (sequence.Length == 3)
            {
                if (sequences.Contains(sequence))
                {
                    Debug.LogFormat("Detected sequence {0}", sequence);
                }
                else
                {
                    Debug.LogFormat("Unknown sequence {0}", sequence);
                }
                sequence = "";
            }
        }
    }
}
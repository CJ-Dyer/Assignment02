using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeathScript : MonoBehaviour
{
    public Text DeathScore;
    void Start()
    {
        DeathScore.text = "Your Score is: " + Score.PinCount.ToString();
    }
}

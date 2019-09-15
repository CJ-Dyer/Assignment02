using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour {

    public static float speed; 

    void Update ()
	{
        speed = SliderValuesScript.RotatorSpeed;
		transform.Rotate(0f, 0f, speed * Time.deltaTime);
	}

}

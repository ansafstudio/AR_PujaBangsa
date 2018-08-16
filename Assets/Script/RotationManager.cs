using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationManager : MonoBehaviour {
    public GameObject[] Models;

    bool isPressedRightRot;
    bool isPressedLeftRot;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        for (int i = 0; i < Models.Length; i++)
        {
            //Rotation
            if (isPressedRightRot)
            {
				Models[i].transform.Rotate(Vector3.up * Time.deltaTime * 100); //untuk merotate object ke kanan
            }
            else if (isPressedLeftRot)
            {
				Models[i].transform.Rotate(Vector3.down * Time.deltaTime * 100); // untuk merotateobject ke kiri
            }
        }
    }

	public void RightPressedRot() //function saat menekan tombol Rotasi kanan
    {
        isPressedRightRot = true;
    }
	public void RightReleasedRot() //function saat melepas tombol Rotasi kanan
    {
        isPressedRightRot = false;
    }

	public void LeftPressedRot() //function saat menekan tombol Rotasi kiri
    {
        isPressedLeftRot = true;
    }
	public void LeftReleasedRot() //function saat melepas tombol Rotasi kiri
    {
        isPressedLeftRot = false;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuMgr : MonoBehaviour {
	public GameObject mainMenu;
	public GameObject aboutMenu;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Escape)) // cek saat ada input back key
		{
			if (mainMenu.activeSelf) {
				Application.Quit (); // unutk keluar dari aplikasi saat menu utama ditampilkan
			} else {
				mainMenu.SetActive (true); //untuk kembali mengaktifkan menu utama
			}
		}
	}

	public void StartAR() //function saat tap tombol Start
	{
		mainMenu.SetActive (false);
		aboutMenu.SetActive (false);
	}

	public void OpenAbout() //function saat tap tombol About
	{
		aboutMenu.SetActive (true);
		mainMenu.SetActive (false);
	}

	public void ExitFromAbout() //function saat tap tombol Exit di menu About
	{
		mainMenu.SetActive (true);
		aboutMenu.SetActive (false);
	}

	public void PlayVideo() //function saat tap tombol Video
    {
        Handheld.PlayFullScreenMovie("Ngurah-Rai-Movie-Trailer.mp4");
    }
}

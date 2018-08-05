using UnityEngine;
using System.Collections;

public class Mesh17 : MonoBehaviour
{

	public GameObject mes17;
	public GameObject mes1717;


	// Use this for initialization
	void Start ()
	{
		mes17.SetActive (true);
		mes1717.SetActive (false);
	}

	// Update is called once per frame
	void Update ()
	{

	}

	public void OnMouseDown(){
		PlayerPrefs.SetInt ("clicked",1);
		if(PlayerPrefs.GetInt("Turn")==0){
			PlayerPrefs.SetInt ("Turn",1);
		}
		else if(PlayerPrefs.GetInt("Turn")==1){
			PlayerPrefs.SetInt ("Turn",0);
		}
		mes17.SetActive (false);
		mes1717.SetActive (true);

	}
}


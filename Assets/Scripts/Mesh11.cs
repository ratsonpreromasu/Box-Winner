using UnityEngine;
using System.Collections;

public class Mesh11 : MonoBehaviour
{

	public GameObject mes11;
	public GameObject mes1111;


	// Use this for initialization
	void Start ()
	{
		mes11.SetActive (true);
		mes1111.SetActive (false);
	}

	// Update is called once per frame
	void Update ()
	{

	}


	public void OnMouseDown(){
		PlayerPrefs.SetInt ("clicked",1);

//		if(PlayerPrefs.GetInt("Turn")==0){
//			PlayerPrefs.SetInt ("Turn",1);
//		}
//		else if(PlayerPrefs.GetInt("Turn")==1){
//			PlayerPrefs.SetInt ("Turn",0);
//		}
		mes11.SetActive (false);
		mes1111.SetActive (true);

	}
}


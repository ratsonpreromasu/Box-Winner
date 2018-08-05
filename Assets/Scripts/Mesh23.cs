using UnityEngine;
using System.Collections;

public class Mesh23 : MonoBehaviour
{

	public GameObject mes23;
	public GameObject mes2323;


	// Use this for initialization
	void Start ()
	{
		mes23.SetActive (true);
		mes2323.SetActive (false);
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
		mes23.SetActive (false);
		mes2323.SetActive (true);

	}
}


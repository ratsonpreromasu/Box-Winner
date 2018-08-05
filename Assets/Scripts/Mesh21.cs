using UnityEngine;
using System.Collections;

public class Mesh21 : MonoBehaviour
{

	public GameObject mes21;
	public GameObject mes2121;


	// Use this for initialization
	void Start ()
	{
		mes21.SetActive (true);
		mes2121.SetActive (false);
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
		mes21.SetActive (false);
		mes2121.SetActive (true);

	}
}


using UnityEngine;
using System.Collections;

public class Mesh4 : MonoBehaviour
{

	public GameObject mes4;
	public GameObject mes44;


	// Use this for initialization
	void Start ()
	{
		mes4.SetActive (true);
		mes44.SetActive (false);
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
		mes4.SetActive (false);
		mes44.SetActive (true);

	}
}


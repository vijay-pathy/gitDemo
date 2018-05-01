using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{


	public GameObject InteractionPanel;
	public GameObject extinghuisherAddedPanel;

	public Text Info;
	public static GameObject _selectedObject;
	// Use this for initialization

	void Awake ()
	{
		ValveController.OnInteraction += DoAction;
	}


	void Start ()
	{
    //this is  start. called once @ begining
		
	}


	
	// Update is called once per frame
	void Update ()
	{

//this a new change this is a fourth change

	}

	void DoAction ()
	{
		ShowPanel ();
	}


	public void ClosePanel ()
	{
		InteractionPanel.SetActive (false);
	}







	void ShowPanel ()
	{
		switch (_selectedObject.tag.ToString ()) {

		case "valve":
			if (_selectedObject.GetComponent<ValveController> ().state == true) {
				Info.text = "Do u want to turn off the valve?";
			} else {
				Info.text = "Do u want to turn on the valve?";

			}
			break;
		case "fire":
			Info.text = " ";

			break;
		case "ext":
			Info.text = " Do grab the fire extinguisher?";
			break;

		}

		InteractionPanel.SetActive (true);

	}





	public void AddExthinguisherpanel ()
	{
		if (_selectedObject.tag == "ext") {
			extinghuisherAddedPanel.SetActive (true);
			_selectedObject.SetActive (false);
		}

	}




}

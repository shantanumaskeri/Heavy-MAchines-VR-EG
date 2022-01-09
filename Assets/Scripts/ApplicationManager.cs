using UnityEngine;
using System.Collections;

public class ApplicationManager : MonoBehaviour 
{
	// Singleton instance
	public static ApplicationManager Instance;

	// public variables
	public bool isMoveAllowed;
	public GameObject firstSelection;
	public GameObject secondSelection;
	public GameObject mainExperience;
	public GameObject ovrPlayerController;
	public string applicationState;

	// private variables
	Vector3 initialPosition;

	// Use this for initialization
	void Start () 
	{
		Instance = this;

		isMoveAllowed = false;
		applicationState = "machineSelection";

		firstSelection.SetActive (true);
		secondSelection.SetActive (false);
		mainExperience.SetActive (false);

		initialPosition = ovrPlayerController.transform.position;
	}

	public void MoveToTerrainSelection ()
	{
		applicationState = "terrainSelection";

		firstSelection.SetActive (false);
		secondSelection.SetActive (true);
	}

	public void StartApplication ()
	{
		isMoveAllowed = true;
		applicationState = "experience";

		secondSelection.SetActive (false);
		mainExperience.SetActive (true);
	}

	public void BackToTerrainSelection ()
	{
		isMoveAllowed = false;
		applicationState = "terrainSelection";

		ovrPlayerController.transform.position = initialPosition;

		secondSelection.SetActive (true);
		mainExperience.SetActive (false);
	}

	public void BackToMachineSelection ()
	{
		applicationState = "machineSelection";

		firstSelection.SetActive (true);
		secondSelection.SetActive (false);
	}

	public void OpenWebsite ()
	{
		Debug.Log ("OpenWebsite");
		Application.OpenURL ("https://www.facebook.com/ElyonInteractive");
	}
}

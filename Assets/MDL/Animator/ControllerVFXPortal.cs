using UnityEngine;

public class ControllerVFXPortal : MonoBehaviour {
	public GameObject currentEffect;

	void Start ()
	{
		currentEffect.SetActive (false);
	}

	void VFXPortalPlay ()
	{
		currentEffect.SetActive (true);
	}
}

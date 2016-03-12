using UnityEngine;
using System.Collections;

public class SelectionManager : MonoBehaviour
{
    GameObject selectedPiece;

	// Use this for initialization
	void Start ()
    {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
	
	}

    public void selectNewPiece(GameObject piece)
    {
        if (selectedPiece != null)
        {
            selectedPiece.GetComponent<SelectPiece>().restoreColor();
        }

        selectedPiece = piece;
    }
}

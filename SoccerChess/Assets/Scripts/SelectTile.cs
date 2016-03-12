using UnityEngine;
using System.Collections;

public class SelectTile : MonoBehaviour
{
    [SerializeField]
    SelectionManager selectionManager;

	// Use this for initialization
	void Start ()
    {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
	
	}

    void OnMouseDown()
    {
        if (selectionManager == null) selectionManager = GameObject.FindGameObjectWithTag("SelectionManager").GetComponent<SelectionManager>();
        if (selectionManager.hasSomePieceSelected())
        {
            selectionManager.movePieceToTile(this.transform.position);
        }
        else print("Select some piece");
    }
}

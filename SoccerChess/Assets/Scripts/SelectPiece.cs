using UnityEngine;
using System.Collections;

public class SelectPiece : MonoBehaviour
{

    [SerializeField]
    Color objectColor;
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
        this.gameObject.GetComponent<SpriteRenderer>().color = Color.green;
        selectionManager.selectNewPiece(this.gameObject);
    }

    public void restoreColor()
    {
        this.gameObject.GetComponent<SpriteRenderer>().color = objectColor;
    }
}

using UnityEngine;
using System.Collections;

public class SelectionManager : MonoBehaviour
{
    GameObject selectedPiece;
    Vector3 destiny;
    bool move = false;
    
    void FixedUpdate()
    {
        if (move)
        {
            float pieceZ = selectedPiece.transform.position.z;
            selectedPiece.transform.position = Vector3.Lerp(selectedPiece.transform.position, destiny, Time.fixedDeltaTime);
            selectedPiece.transform.position = new Vector3(selectedPiece.transform.position.x, selectedPiece.transform.position.y, pieceZ);

            if (selectedPiece.transform.position.x == destiny.x && selectedPiece.transform.position.y == destiny.y) move = false;
        }
    }

    public void selectNewPiece(GameObject piece)
    {
        if (selectedPiece != null && piece != selectedPiece)
        {
            selectedPiece.GetComponent<SelectPiece>().restoreColor();
        }

        selectedPiece = piece;
        move = false;
    }

    public bool hasSomePieceSelected()
    {
        return selectedPiece != null;
    }

    public void movePieceToTile(Vector3 tilePosition)
    {
        if (!move)
        {
            destiny = tilePosition;
            move = true;
        }

    }
}

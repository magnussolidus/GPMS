using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Piece_type
{
    pawn,
    tower,
    bishop,
    knight,
    queen,
    king
}

public class Piece : MonoBehaviour
{

    public GameObject piecePrefab;
    public Guid uId = Guid.NewGuid();
    public Piece_type type;
    public bool movementFlag = false;


    public void ToggleFlag()
    {
        this.movementFlag = !this.movementFlag;
    }

    public GameObject GetThisPieceGameObject()
    {
        return this.gameObject;
    }

    public Piece_type GetThisPieceType()
    {
        return this.type;
    }

    public Piece GetThisPieceComponent()
    {
        return this.gameObject.GetComponent<Piece>();
    }

}

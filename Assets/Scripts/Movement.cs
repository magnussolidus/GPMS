using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement
{
    public Position startPosition;
    public Position endPosition;
    public Piece piece;
    public bool inert;
    public string historyString;

    public Movement(int startX, int startY, int endX, int endY, Piece owner, string moveString)
    {
        startPosition = new Position(startX, startY);
        endPosition = new Position(endX, endY);
        piece = owner;
        historyString = moveString;

    }

    public Movement(Position startPos, Position finishPos, Piece owner, string moveString)
    {
        startPosition = startPos;
        endPosition = finishPos;
        piece = owner;
        historyString = moveString;
    }
}

using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using Hiraishin.Utilities;
using DG.Tweening;

public class BoardSystem
{
    
    private BoardComponent boardComp;

    public Action<CandyType, List<Candy>> OnCandyMatch;
    public Action<byte> OnRefillBoard;
    public Action<Candy> OnRemoveCandy;

    private Grid<Candy> CandyGrid;
    private List<Candy> Bananas;
    private List<Candy> Grapes;
    private List<Candy> Watermelon;
    private List<Candy> Cherry;
    private List<Candy> Apple;
    private List<Candy> Triangle;
    private List<Candy> Square;
    private List<Candy> Hexagon;
    private List<Candy> Pentagon;
    private List<Candy> Scatter;
    private List<Candy> Jackpot;

    private class CoroutineHelper : MonoBehaviour { }
    private static CoroutineHelper _Coroutine;

    public BoardSystem(BoardComponent comp)
    {
        boardComp = comp;
        CandyGrid = new Grid<Candy>(boardComp.Width, boardComp.Height, boardComp.CellSize, boardComp.OriginPosition, GridType.Grid2D, boardComp.DebugLine);
        Bananas = new List<Candy>();
        Grapes = new List<Candy>();
        Watermelon = new List<Candy>();
        Cherry = new List<Candy>();
        Apple = new List<Candy>();
        Triangle = new List<Candy>();
        Square = new List<Candy>();
        Hexagon = new List<Candy>();
        Pentagon = new List<Candy>();
        Scatter = new List<Candy>();
        Jackpot = new List<Candy>();

        GameObject CoroutineObject = new GameObject("Board System Coroutine Helper");
        _Coroutine = CoroutineObject.AddComponent<CoroutineHelper>();
    }
    private void AddToList(Candy candy)
    {
        switch (candy.GetCandyType)
        {
            case CandyType.Banana:
                Bananas.Add(candy);
                break;
            case CandyType.Grapes:
                Grapes.Add(candy);
                break;
            case CandyType.Watermelon:
                Watermelon.Add(candy);
                break;
            case CandyType.Cherry:
                Cherry.Add(candy);
                break;
            case CandyType.Apple:
                Apple.Add(candy);
                break;
            case CandyType.TriangleCandy:
                Triangle.Add(candy);
                break;
            case CandyType.SquareCandy:
                Square.Add(candy);
                break;
            case CandyType.PentagonCandy:
                Pentagon.Add(candy);
                break;
            case CandyType.HexagonCandy:
                Hexagon.Add(candy);
                break;
            case CandyType.Scatter:
                Scatter.Add(candy);
                break;
            case CandyType.Jackpot:
                Jackpot.Add(candy);
                break;
        }
    }
    private void CheckMatchResult()
    {
        if (Bananas.Count >= 8)
        {
            GameController.Instance.UpdateGold(CandyType.Banana, Bananas.Count);
            OnCandyMatch?.Invoke(CandyType.Banana, Bananas);
            foreach (Candy item in Bananas)
            {
                int x, y;
                CandyGrid.GetXY(item.transform.position, out x, out y);
                CandyGrid.SetValue(x, y, null);
            }
        }
        if (Grapes.Count >= 8)
        {
            GameController.Instance.UpdateGold(CandyType.Grapes, Grapes.Count);
            OnCandyMatch?.Invoke(CandyType.Grapes, Grapes);
            foreach (Candy item in Grapes)
            {
                int x, y;
                CandyGrid.GetXY(item.transform.position, out x, out y);
                CandyGrid.SetValue(x, y, null);
            }
        }
        if (Watermelon.Count >= 8)
        {
            GameController.Instance.UpdateGold(CandyType.Watermelon, Watermelon.Count);
            OnCandyMatch?.Invoke(CandyType.Watermelon, Watermelon);
            foreach (Candy item in Watermelon)
            {
                int x, y;
                CandyGrid.GetXY(item.transform.position, out x, out y);
                CandyGrid.SetValue(x, y, null);
            }
        }
        if (Cherry.Count >= 8)
        {
            GameController.Instance.UpdateGold(CandyType.Cherry, Cherry.Count);
            OnCandyMatch?.Invoke(CandyType.Cherry, Cherry);
            foreach (Candy item in Cherry)
            {
                int x, y;
                CandyGrid.GetXY(item.transform.position, out x, out y);
                CandyGrid.SetValue(x, y, null);
            }
        }
        if (Apple.Count >= 8)
        {
            GameController.Instance.UpdateGold(CandyType.Apple, Apple.Count);
            OnCandyMatch?.Invoke(CandyType.Apple, Apple);
            foreach (Candy item in Apple)
            {
                int x, y;
                CandyGrid.GetXY(item.transform.position, out x, out y);
                CandyGrid.SetValue(x, y, null);
            }
        }
        if (Triangle.Count >= 8)
        {
            GameController.Instance.UpdateGold(CandyType.TriangleCandy, Triangle.Count);
            OnCandyMatch?.Invoke(CandyType.TriangleCandy, Triangle);
            foreach (Candy item in Triangle)
            {
                int x, y;
                CandyGrid.GetXY(item.transform.position, out x, out y);
                CandyGrid.SetValue(x, y, null);
            }
        }
        if (Square.Count >= 8)
        {
            GameController.Instance.UpdateGold(CandyType.SquareCandy, Square.Count);
            OnCandyMatch?.Invoke(CandyType.SquareCandy, Square);
            foreach (Candy item in Square)
            {
                int x, y;
                CandyGrid.GetXY(item.transform.position, out x, out y);
                CandyGrid.SetValue(x, y, null);
            }
        }
        if (Pentagon.Count >= 8)
        {
            GameController.Instance.UpdateGold(CandyType.PentagonCandy, Pentagon.Count);
            OnCandyMatch?.Invoke(CandyType.PentagonCandy, Pentagon);
            foreach (Candy item in Pentagon)
            {
                int x, y;
                CandyGrid.GetXY(item.transform.position, out x, out y);
                CandyGrid.SetValue(x, y, null);
            }
        }
        if (Hexagon.Count >= 8)
        {
            GameController.Instance.UpdateGold(CandyType.HexagonCandy, Hexagon.Count);
            OnCandyMatch?.Invoke(CandyType.HexagonCandy, Hexagon);
            foreach (Candy item in Hexagon)
            {
                int x, y;
                CandyGrid.GetXY(item.transform.position, out x, out y);
                CandyGrid.SetValue(x, y, null);
            }
        }
        if (Scatter.Count >= 4)
        {
            GameController.Instance.UpdateGold(CandyType.Scatter, Scatter.Count);
            OnCandyMatch?.Invoke(CandyType.Scatter, Scatter);
            foreach (Candy item in Scatter)
            {
                int x, y;
                CandyGrid.GetXY(item.transform.position, out x, out y);
                CandyGrid.SetValue(x, y, null);
            }
        }
        if (Jackpot.Count >= 5)
        {
            GameController.Instance.UpdateGold(CandyType.Jackpot, Jackpot.Count);
            OnCandyMatch?.Invoke(CandyType.Jackpot, Jackpot);
            foreach (Candy item in Jackpot)
            {
                int x, y;
                CandyGrid.GetXY(item.transform.position, out x, out y);
                CandyGrid.SetValue(x, y, null);
            }
        }
        ClearAllMtachResult();
        _Coroutine.StartCoroutine(MoveDownCandy());
    }
    private IEnumerator MoveDownCandy()
    {
        yield return new WaitForSeconds(1f);
        int cout = 0;
        for (int x = 0; x < boardComp.Width; x++)
        {
            for (int y = 0; y < boardComp.Height; y++)
            {
                Candy candy = CandyGrid.GetValue(x, y);
                if (candy == null)
                {
                    cout++;
                }
                else if(cout > 0)
                {
                    Vector3 TargetPosition = CandyGrid.GetCenterPositionInWorld(x, y - cout);
                    candy.transform.DOMoveY(TargetPosition.y, 0.2f).SetEase(Ease.Linear);
                    CandyGrid.SetValue(x, y - cout, candy);
                    CandyGrid.SetValue(x, y, null);
                }
            }
            cout = 0;
        }
        yield return new WaitForSeconds(0.5f);
        byte EmptyCell = 0;
        for (int x = 0; x < boardComp.Width; x++)
        {
            for (int y = 0; y < boardComp.Height; y++)
            {
                Candy candy = CandyGrid.GetValue(x, y);
                if (candy == null)
                {
                    EmptyCell++;
                }
            }
        }
        OnRefillBoard?.Invoke(EmptyCell);
    }
    private void ClearAllMtachResult()
    {
        Bananas.Clear();
        Grapes.Clear();
        Watermelon.Clear();
        Cherry.Clear();
        Apple.Clear();
        Triangle.Clear();
        Square.Clear();
        Pentagon.Clear();
        Hexagon.Clear();
        Scatter.Clear();
        Jackpot.Clear();
    }

    public void Roll(Queue<Candy> candies)
    {
        for (int x = 0; x < boardComp.Width; x++)
        {
            for (int y = 0; y < boardComp.Height; y++)
            {
                Candy candy = CandyGrid.GetValue(x, y);
                if (candy != null)
                {
                    OnRemoveCandy?.Invoke(candy);
                }
                candy = null;
                candy = candies.Dequeue();
                CandyGrid.SetValue(x, y, candy);
                candy.gameObject.SetActive(true);
                Vector3 OriginPos = CandyGrid.GetCenterPositionInWorld(x, y);
                Vector3 StartPosition = OriginPos;
                StartPosition.y += boardComp.CellSize * boardComp.Height;
                candy.transform.position = StartPosition;
                candy.transform.DOMoveY(OriginPos.y, 0.5f).SetEase(Ease.Linear);
            }
        }
        _Coroutine.StartCoroutine(CheckBoard());
    }
    public void FillCandyToBoard(Queue<Candy> candies)
    {
        if (candies.Count == 0)
        {
            HUD.Instance.OnClickRoll();
            return;
        }
        for (int x = 0; x < boardComp.Width; x++)
        {
            for (int y = 0; y < boardComp.Height; y++)
            {
                Candy candy = CandyGrid.GetValue(x, y);
                if (candy == null)
                {
                    candy = candies.Dequeue();
                    CandyGrid.SetValue(x, y, candy);
                    candy.gameObject.SetActive(true);
                    Vector3 OriginPos = CandyGrid.GetCenterPositionInWorld(x, y);
                    Vector3 StartPosition = OriginPos;
                    StartPosition.y += boardComp.CellSize * boardComp.Height;
                    candy.transform.position = StartPosition;
                    candy.transform.DOMoveY(OriginPos.y, 0.5f).SetEase(Ease.Linear);
                }
            }
        }
        _Coroutine.StartCoroutine(CheckBoard());
    }
    public IEnumerator CheckBoard()
    {
        yield return new WaitForSeconds(2f);
        for (int x = 0; x < boardComp.Width; x++)
        {
            for (int y = 0; y < boardComp.Height; y++)
            {
                Candy candy = CandyGrid.GetValue(x, y);
                AddToList(candy);
            }
        }
        CheckMatchResult();
    }
}

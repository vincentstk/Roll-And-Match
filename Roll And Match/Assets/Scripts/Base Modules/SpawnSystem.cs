using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class SpawnSystem
{
    [Inject] CandyPooler _CandyPooler;

    private SpawnComponent spawnComp;

    private const string BANANA = "Banana";
    private const string GRAPES = "Grapes";
    private const string WATERMELON = "Watermelon";
    private const string CHERRY = "Cherry";
    private const string APPLE = "Apple";
    private const string TRIANGLE = "Triangle";
    private const string SQUARE = "Square";
    private const string PENTAGON = "Pentagon";
    private const string HEXAGON = "Hexagon";
    private const string SCATTER = "Scatter";
    private const string JACKPOT = "Jackpot";

    public SpawnSystem(SpawnComponent _spawnComp)
    {
        spawnComp = _spawnComp;
    }
    private Candy Spawn(CandyType type)
    {
        GameObject CandyObject = null;
        Candy Candy = null;
        switch (type)
        {
            case CandyType.Banana:
                CandyObject = _CandyPooler.SpawnObject(BANANA, Vector3.zero, Quaternion.identity);
                break;
            case CandyType.Grapes:
                CandyObject = _CandyPooler.SpawnObject(GRAPES, Vector3.zero, Quaternion.identity);
                break;
            case CandyType.Watermelon:
                CandyObject = _CandyPooler.SpawnObject(WATERMELON, Vector3.zero, Quaternion.identity);
                break;
            case CandyType.Cherry:
                CandyObject = _CandyPooler.SpawnObject(CHERRY, Vector3.zero, Quaternion.identity);
                break;
            case CandyType.Apple:
                CandyObject = _CandyPooler.SpawnObject(APPLE, Vector3.zero, Quaternion.identity);
                break;
            case CandyType.TriangleCandy:
                CandyObject = _CandyPooler.SpawnObject(TRIANGLE, Vector3.zero, Quaternion.identity);
                break;
            case CandyType.SquareCandy:
                CandyObject = _CandyPooler.SpawnObject(SQUARE, Vector3.zero, Quaternion.identity);
                break;
            case CandyType.PentagonCandy:
                CandyObject = _CandyPooler.SpawnObject(PENTAGON, Vector3.zero, Quaternion.identity);
                break;
            case CandyType.HexagonCandy:
                CandyObject = _CandyPooler.SpawnObject(HEXAGON, Vector3.zero, Quaternion.identity);
                break;
            case CandyType.Scatter:
                CandyObject = _CandyPooler.SpawnObject(SCATTER, Vector3.zero, Quaternion.identity);
                break;
            case CandyType.Jackpot:
                CandyObject = _CandyPooler.SpawnObject(JACKPOT, Vector3.zero, Quaternion.identity);
                break;

        }
        Candy = CandyObject.GetComponent<Candy>();
        CandyObject.SetActive(false);
        return Candy;
    }
    public Queue<Candy> RandomRollCandy(byte Count)
    {
        Queue<Candy> candies = new Queue<Candy>();
        for (int i = 0; i < Count; i++)
        {
            float result = Random.Range(0f, 1f) * 100;
            for (int j = 0; j < spawnComp.Candies.Length; j++)
            {
                if (result <= spawnComp.Candies[j].GetRatio)
                {
                    Candy candy = Spawn(spawnComp.Candies[j].GetCandyType);
                    candies.Enqueue(candy);
                    break;
                }
                else
                {
                    result -= spawnComp.Candies[j].GetRatio;
                }
            }
        }

        return candies;
    }
    public void RemoveCandyList(CandyType Type, List<Candy> Candies)
    {
        switch (Type)
        {
            case CandyType.Banana:
                foreach (Candy item in Candies)
                {
                    _CandyPooler.ReturnToPool(BANANA, item.gameObject, true);
                }
                break;
            case CandyType.Grapes:
                foreach (Candy item in Candies)
                {
                    _CandyPooler.ReturnToPool(GRAPES, item.gameObject, true);
                }
                break;
            case CandyType.Watermelon:
                foreach (Candy item in Candies)
                {
                    _CandyPooler.ReturnToPool(WATERMELON, item.gameObject, true);
                }
                break;
            case CandyType.Cherry:
                foreach (Candy item in Candies)
                {
                    _CandyPooler.ReturnToPool(CHERRY, item.gameObject, true);
                }
                break;
            case CandyType.Apple:
                foreach (Candy item in Candies)
                {
                    _CandyPooler.ReturnToPool(APPLE, item.gameObject, true);
                }
                break;
            case CandyType.TriangleCandy:
                foreach (Candy item in Candies)
                {
                    _CandyPooler.ReturnToPool(TRIANGLE, item.gameObject, true);
                }
                break;
            case CandyType.SquareCandy:
                foreach (Candy item in Candies)
                {
                    _CandyPooler.ReturnToPool(SQUARE, item.gameObject, true);
                }
                break;
            case CandyType.PentagonCandy:
                foreach (Candy item in Candies)
                {
                    _CandyPooler.ReturnToPool(PENTAGON, item.gameObject, true);
                }
                break;
            case CandyType.HexagonCandy:
                foreach (Candy item in Candies)
                {
                    _CandyPooler.ReturnToPool(HEXAGON, item.gameObject, true);
                }
                break;
            case CandyType.Scatter:
                foreach (Candy item in Candies)
                {
                    _CandyPooler.ReturnToPool(SCATTER, item.gameObject, true);
                }
                break;
            case CandyType.Jackpot:
                foreach (Candy item in Candies)
                {
                    _CandyPooler.ReturnToPool(JACKPOT, item.gameObject, true);
                }
                break;
        }
    }
    public void RemoveCandy(Candy candy)
    {
        switch (candy.GetCandyType)
        {
            case CandyType.Banana:
                _CandyPooler.ReturnToPool(BANANA, candy.gameObject, true);
                break;
            case CandyType.Grapes:
                _CandyPooler.ReturnToPool(GRAPES, candy.gameObject, true);
                break;
            case CandyType.Watermelon:
                _CandyPooler.ReturnToPool(WATERMELON, candy.gameObject, true);
                break;
            case CandyType.Cherry:
                _CandyPooler.ReturnToPool(CHERRY, candy.gameObject, true);
                break;
            case CandyType.Apple:
                _CandyPooler.ReturnToPool(APPLE, candy.gameObject, true);
                break;
            case CandyType.TriangleCandy:
                _CandyPooler.ReturnToPool(TRIANGLE, candy.gameObject, true);
                break;
            case CandyType.SquareCandy:
                _CandyPooler.ReturnToPool(SQUARE, candy.gameObject, true);
                break;
            case CandyType.PentagonCandy:
                _CandyPooler.ReturnToPool(PENTAGON, candy.gameObject, true);
                break;
            case CandyType.HexagonCandy:
                _CandyPooler.ReturnToPool(HEXAGON, candy.gameObject, true);
                break;
            case CandyType.Scatter:
                _CandyPooler.ReturnToPool(SCATTER, candy.gameObject, true);
                break;
            case CandyType.Jackpot:
                _CandyPooler.ReturnToPool(JACKPOT, candy.gameObject, true);
                break;
        }
    }

    public class Factory : PlaceholderFactory<SpawnComponent, SpawnSystem> { }
}

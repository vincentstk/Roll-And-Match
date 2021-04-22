using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sirenix.OdinInspector;
using Hiraishin.Utilities;

public class GameController : BaseSingleton<GameController>
{

    #region Components
    [FoldoutGroup("Components", true, 0, GroupID = "Component")]
    [SerializeField]
    private GoldComponent goldComp;
    #endregion

    public float GetGold
    {
        get => goldComp.Gold;
    }
    // Start is called before the first frame update
    void Start()
    {
        HUD.Instance.UpdateGold(goldComp.Gold);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void UseGold()
    {
        goldComp.Gold -= goldComp.GoldToRoll;
        HUD.Instance.UpdateGold(goldComp.Gold);
    }
    public void UpdateGold(CandyType type, int count)
    {
        float AddGold = 0;
        switch (type)
        {
            case CandyType.Banana:
                if (count == 8)
                {
                    AddGold = goldComp.GoldToRoll * goldComp.BananasODD[0];
                }
                else if (count == 9)
                {
                    AddGold = goldComp.GoldToRoll * goldComp.BananasODD[1];
                }
                else if (count == 10)
                {
                    AddGold = goldComp.GoldToRoll * goldComp.BananasODD[2];
                }
                else if (count == 11)
                {
                    AddGold = goldComp.GoldToRoll * goldComp.BananasODD[3];
                }
                else
                    AddGold = goldComp.GoldToRoll * goldComp.BananasODD[4];
                break;
            case CandyType.Grapes:
                if (count == 8)
                {
                    AddGold = goldComp.GoldToRoll * goldComp.GrapesODD[0];
                }
                else if (count == 9)
                {
                    AddGold = goldComp.GoldToRoll * goldComp.GrapesODD[1];
                }
                else if (count == 10)
                {
                    AddGold = goldComp.GoldToRoll * goldComp.GrapesODD[2];
                }
                else if (count == 11)
                {
                    AddGold = goldComp.GoldToRoll * goldComp.GrapesODD[3];
                }
                else
                    AddGold = goldComp.GoldToRoll * goldComp.GrapesODD[4];
                break;
            case CandyType.Watermelon:
                if (count == 8)
                {
                    AddGold = goldComp.GoldToRoll * goldComp.WatermelonODD[0];
                }
                else if (count == 9)
                {
                    AddGold = goldComp.GoldToRoll * goldComp.WatermelonODD[1];
                }
                else if (count == 10)
                {
                    AddGold = goldComp.GoldToRoll * goldComp.WatermelonODD[2];
                }
                else if (count == 11)
                {
                    AddGold = goldComp.GoldToRoll * goldComp.WatermelonODD[3];
                }
                else
                    AddGold = goldComp.GoldToRoll * goldComp.WatermelonODD[4];
                break;
            case CandyType.Cherry:
                if (count == 8)
                {
                    AddGold = goldComp.GoldToRoll * goldComp.CherryODD[0];
                }
                else if (count == 9)
                {
                    AddGold = goldComp.GoldToRoll * goldComp.CherryODD[1];
                }
                else if (count == 10)
                {
                    AddGold = goldComp.GoldToRoll * goldComp.CherryODD[2];
                }
                else if (count == 11)
                {
                    AddGold = goldComp.GoldToRoll * goldComp.CherryODD[3];
                }
                else
                    AddGold = goldComp.GoldToRoll * goldComp.CherryODD[4];
                break;
            case CandyType.Apple:
                if (count == 8)
                {
                    AddGold = goldComp.GoldToRoll * goldComp.AppleODD[0];
                }
                else if (count == 9)
                {
                    AddGold = goldComp.GoldToRoll * goldComp.AppleODD[1];
                }
                else if (count == 10)
                {
                    AddGold = goldComp.GoldToRoll * goldComp.AppleODD[2];
                }
                else if (count == 11)
                {
                    AddGold = goldComp.GoldToRoll * goldComp.AppleODD[3];
                }
                else
                    AddGold = goldComp.GoldToRoll * goldComp.AppleODD[4];
                break;
            case CandyType.TriangleCandy:
                if (count == 8)
                {
                    AddGold = goldComp.GoldToRoll * goldComp.TriangleODD[0];
                }
                else if (count == 9)
                {
                    AddGold = goldComp.GoldToRoll * goldComp.TriangleODD[1];
                }
                else if (count == 10)
                {
                    AddGold = goldComp.GoldToRoll * goldComp.TriangleODD[2];
                }
                else if (count == 11)
                {
                    AddGold = goldComp.GoldToRoll * goldComp.TriangleODD[3];
                }
                else
                    AddGold = goldComp.GoldToRoll * goldComp.TriangleODD[4];
                break;
            case CandyType.SquareCandy:
                if (count == 8)
                {
                    AddGold = goldComp.GoldToRoll * goldComp.SquareODD[0];
                }
                else if (count == 9)
                {
                    AddGold = goldComp.GoldToRoll * goldComp.SquareODD[1];
                }
                else if (count == 10)
                {
                    AddGold = goldComp.GoldToRoll * goldComp.SquareODD[2];
                }
                else if (count == 11)
                {
                    AddGold = goldComp.GoldToRoll * goldComp.SquareODD[3];
                }
                else
                    AddGold = goldComp.GoldToRoll * goldComp.SquareODD[4];
                break;
            case CandyType.PentagonCandy:
                if (count == 8)
                {
                    AddGold = goldComp.GoldToRoll * goldComp.PentagonODD[0];
                }
                else if (count == 9)
                {
                    AddGold = goldComp.GoldToRoll * goldComp.PentagonODD[1];
                }
                else if (count == 10)
                {
                    AddGold = goldComp.GoldToRoll * goldComp.PentagonODD[2];
                }
                else if (count == 11)
                {
                    AddGold = goldComp.GoldToRoll * goldComp.PentagonODD[3];
                }
                else
                    AddGold = goldComp.GoldToRoll * goldComp.PentagonODD[4];
                break;
            case CandyType.HexagonCandy:
                if (count == 8)
                {
                    AddGold = goldComp.GoldToRoll * goldComp.HexagonODD[0];
                }
                else if (count == 9)
                {
                    AddGold = goldComp.GoldToRoll * goldComp.HexagonODD[1];
                }
                else if (count == 10)
                {
                    AddGold = goldComp.GoldToRoll * goldComp.HexagonODD[2];
                }
                else if (count == 11)
                {
                    AddGold = goldComp.GoldToRoll * goldComp.HexagonODD[3];
                }
                else
                    AddGold = goldComp.GoldToRoll * goldComp.HexagonODD[4];
                break;
            case CandyType.Scatter:
                break;
            case CandyType.Jackpot:
                AddGold = 10000;
                break;
        }
        goldComp.Gold += AddGold;
        HUD.Instance.ShowNoti(type, count, AddGold);
        HUD.Instance.UpdateGold(goldComp.Gold);
    }
}

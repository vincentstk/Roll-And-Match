using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Hiraishin.Utilities;
using Sirenix.OdinInspector;
using TMPro;
using Zenject;

public class HUD : BaseSingleton<HUD>
{
    [Inject] UIPooler _UIPooler;
    #region UI Elements
    [FoldoutGroup("Texts", true, 0, GroupID = "Text")]
    public TextMeshProUGUI txtGold;
    [FoldoutGroup("Text")]
    public TextMeshProUGUI txtRollCount;
    [FoldoutGroup("Text")]
    public TextMeshProUGUI txtFreeGameCount;
    [FoldoutGroup("Text")]
    public TextMeshProUGUI txtJackpotCount;
    #endregion
    public Canvas GameplayUI;

    private const string NOTI = "Noti";
    private int RollCount = 0;
    private int Index = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void UpdateGold(float gold)
    {
        txtGold.SetText(gold.ToString());
    }
    public void ScatterUpdate(int count)
    {
        txtFreeGameCount.SetText("Free " + count);
    }
    public void JackpotUpdate(int count)
    {
        txtJackpotCount.SetText("Jackpot " + count);
    }
    public void OnClickRoll()
    {
        if (GameController.Instance.GetGold < 100)
        {
            return;
        }
        RollCount++;
        txtRollCount.SetText(RollCount.ToString());
        GameController.Instance.UseGold();
        CandyBoard.Instance.Roll();
    }
    public void ShowNoti(CandyType type, int count, float gold)
    {
        Index++;
        GameObject txt = _UIPooler.SpawnWithNewParent(NOTI, GameplayUI.transform, GameplayUI.transform.position, Quaternion.identity); 
        TextFadeVFX fade = txt.GetComponent<TextFadeVFX>();
        fade.StartVFX("Match " + count + " " + type.ToString() + " Claim" + gold, Index);
        if (Index == 3)
        {
            Index = 0;
        }
    }
}

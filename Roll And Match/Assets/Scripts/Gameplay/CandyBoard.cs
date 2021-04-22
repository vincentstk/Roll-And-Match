using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sirenix.OdinInspector;
using Hiraishin.Utilities;
using Zenject;

public class CandyBoard : BaseSingleton<CandyBoard>
{
    #region Systems
    [Inject] SpawnSystem.Factory _SpawnSystemFactory;
    private BoardSystem _BoardSystem;
    private SpawnSystem _SpawnSystem;
    #endregion

    #region Components
    [FoldoutGroup("Components", true, 0, GroupID = "Component")]
    [SerializeField]
    private BoardComponent boardComp;
    [FoldoutGroup("Component")]
    [SerializeField]
    private SpawnComponent spawnComp;
    #endregion

    // Start is called before the first frame update
    void Start()
    {
        _BoardSystem = new BoardSystem(boardComp);
        _SpawnSystem = _SpawnSystemFactory.Create(spawnComp);
        _BoardSystem.OnCandyMatch += _SpawnSystem.RemoveCandyList;
        _BoardSystem.OnRefillBoard += Refill;
        _BoardSystem.OnRemoveCandy += _SpawnSystem.RemoveCandy;
        //StartCoroutine(Test());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void Refill(byte count)
    {
        Queue<Candy> candies = _SpawnSystem.RandomRollCandy(count);
        _BoardSystem.FillCandyToBoard(candies);
    }
    IEnumerator Test()
    {
        yield return new WaitForSeconds(2f);
        Roll();
    }
    public void Roll()
    {
        Queue<Candy> candies = _SpawnSystem.RandomRollCandy((byte)(boardComp.Width * boardComp.Height));
        _BoardSystem.Roll(candies);
    }
}

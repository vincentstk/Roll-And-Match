using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class SceneInstaller : MonoInstaller
{
    [SerializeField]
    private GameObject CandyPoolerPrefab;
    [SerializeField]
    private GameObject txtNotiPrefab;

    public override void InstallBindings()
    {
        Container.Bind<CandyPooler>().FromComponentInNewPrefab(CandyPoolerPrefab).AsSingle();
        Container.Bind<UIPooler>().FromComponentInNewPrefab(txtNotiPrefab).AsSingle();
        Container.BindFactory<SpawnComponent, SpawnSystem, SpawnSystem.Factory>();
    }
}

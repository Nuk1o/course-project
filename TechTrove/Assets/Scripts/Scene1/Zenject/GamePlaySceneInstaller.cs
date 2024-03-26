using UnityEngine;
using Zenject;

public class GamePlaySceneInstaller : MonoInstaller
{
    [SerializeField] private TestClass _testClass;
    public override void InstallBindings()
    {
        Container.Bind<TestClass>().FromInstance(_testClass);
    }
}

using UnityEngine;
using Zenject;

public class GamePlaySceneInstaller : MonoInstaller
{
    [SerializeField] private TestClass _testClass;
    [SerializeField] private DigitalPanel _digitalPanel;
    public override void InstallBindings()
    {
        Container.Bind<TestClass>().FromInstance(_testClass);
        Container.Bind<DigitalPanel>().FromInstance(_digitalPanel);
    }
}

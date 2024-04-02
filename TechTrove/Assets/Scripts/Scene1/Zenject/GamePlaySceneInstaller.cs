using DialogScripts;
using UnityEngine;
using Zenject;

public class GamePlaySceneInstaller : MonoInstaller
{
    [SerializeField] private TestClass _testClass;
    [SerializeField] private DigitalPanel _digitalPanel;
    [SerializeField] private DialogController _dialogController;
    public override void InstallBindings()
    {
        Container.Bind<TestClass>().FromInstance(_testClass);
        Container.Bind<DigitalPanel>().FromInstance(_digitalPanel);
        Container.Bind<DialogController>().FromInstance(_dialogController);
    }
}

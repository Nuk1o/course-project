using DialogScripts;
using UnityEngine;
using Zenject;

public class GamePlaySceneInstaller : MonoInstaller
{
    [SerializeField] private DigitalPanel _digitalPanel;
    [SerializeField] private DialogController _dialogController;
    public override void InstallBindings()
    {
        Container.Bind<DigitalPanel>().FromInstance(_digitalPanel);
        Container.Bind<DialogController>().FromInstance(_dialogController);
    }
}

using UnityEngine;
using Zenject;

public class InformationInstaller : MonoInstaller
{
    [SerializeField] private InfoPanel _infoPanel;

    public override void InstallBindings()
    {
        Container.Bind<InfoPanel>().FromInstance(_infoPanel);
    }
}

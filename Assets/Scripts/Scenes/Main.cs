using UnityEngine;

public class Main : BaseVrScene
{
    public GameObject SelectInfo;
    public GameObject NoControllerInfo;

    public void StartGame()
    {
        LoaderManager.Load(GameScene.City);
    }

    public void ShowConfigurations()
    {
        LoaderManager.Load(GameScene.Configurations, true);
    }

    public override void OnUpdate()
    {
        SelectInfo.SetActive(HasController);
        NoControllerInfo.SetActive(!HasController);
    }
}

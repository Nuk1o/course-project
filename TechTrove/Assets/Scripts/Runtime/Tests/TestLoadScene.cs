using System.Collections;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.TestTools;

public class TestLoadScene
{
    [UnityTest]
    public IEnumerator TestSceneLoading()
    {
        SceneManager.LoadScene("End");
        yield return null;
        Scene loadedScene = SceneManager.GetActiveScene();
        Assert.NotNull(loadedScene);
        Assert.AreEqual("End", loadedScene.name);
    }
}
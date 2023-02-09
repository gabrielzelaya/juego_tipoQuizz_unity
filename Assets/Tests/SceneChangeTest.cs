using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using UnityEngine.SceneManagement;

public class SceneChangeTest
{
    [Test]
    public void TestSceneChange()
    {
        // Arrange
        int initialScene = 19;
        int nextScene = 1;

        // Act
        SceneManager.LoadScene(initialScene);
        logicacambiarnivel sceneChanger = new logicacambiarnivel();
        sceneChanger.CambiarNivel(nextScene);
        int actualScene = SceneManager.GetActiveScene().buildIndex;

        // Assert
        Assert.AreEqual(nextScene, actualScene);
    }
}

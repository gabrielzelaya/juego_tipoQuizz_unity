using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;


public class ResolutionTest
{
    [Test]
    public void TestResolution1920x1080()
    {
        // Arrange
        int width = 1920;
        int height = 1080;

        // Act
        Screen.SetResolution(width, height, false);

        // Assert
        Assert.AreEqual(width, Screen.width);
        Assert.AreEqual(height, Screen.height);
    }

    
}

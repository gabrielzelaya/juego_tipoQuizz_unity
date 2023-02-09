using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class PerformanceTest
{
    [Test]
    public void TestFrameRate()
    {
        // Arrange
        int frameRate = 90;
        float deltaTime = 1.0f / frameRate;

        // Act
        float actualFrameRate = 1.0f / Time.deltaTime;

        // Assert
        Assert.LessOrEqual(actualFrameRate, frameRate + 5);
        Assert.GreaterOrEqual(actualFrameRate, frameRate - 5);
    }
}

using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;

using UnityEngine.TestTools;


using UnityEngine.SceneManagement;

using UnityEngine;
using System.Diagnostics;
using Debug = UnityEngine.Debug;
public class pruebadeescenas
{
  [Test]
  public void TestSceneLoadPerformance()
  {
    // Crea una instancia de Stopwatch para medir el tiempo transcurrido
    Stopwatch stopwatch = new Stopwatch();

    // Inicia la medición
    stopwatch.Start();

    // Carga la escena que quieres medir
    SceneManager.LoadScene("inicio");

    // Detiene la medición
    stopwatch.Stop();

    // Muestra el tiempo transcurrido en milisegundos
    Debug.Log("Tiempo de carga de escena: " + stopwatch.ElapsedMilliseconds + " ms");
  }
}

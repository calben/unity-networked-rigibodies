﻿using UnityEngine;
using System.Collections;

public class RigidBodyManagerVisualizer : MonoBehaviour
{

  public bool isColoringPerSync;
  public bool isColoringByPlayerProximity;


  public Color syncedRoundColor;
  public Color prioritizedColor;

  RigidBodyManager manager;

  void Start()
  {
    this.manager = this.GetComponent<RigidBodyManager>();
  }

  public void ShowVisualization()
  {
    if (isColoringPerSync)
    {
      syncedRoundColor = new Color(Random.value, Random.value, Random.value, 1.0f);
    }
    if (isColoringByPlayerProximity)
    {
      foreach (GameObject obj in this.manager.objectsByPriority[this.manager.playerPriority])
      {
        obj.renderer.material.color = this.prioritizedColor;
      }
    }
  }
}

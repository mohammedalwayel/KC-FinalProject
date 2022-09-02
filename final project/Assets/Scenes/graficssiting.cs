using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class graficssiting : MonoBehaviour
{
  public void changQuality(int qualatyIndex)
    {

        QualitySettings.SetQualityLevel(qualatyIndex);
    }
}

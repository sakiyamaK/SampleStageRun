using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
  public static bool goal = false;
    // Start is called before the first frame update
    void Start()
    {
        goal = false;
    }

  void OnTriggerEnter(Collider other)
  {
    if(other.gameObject.tag == "Player")
    {
      goal = true;
    }
  }
}

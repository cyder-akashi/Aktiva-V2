﻿using System.Collections.Generic;
using UnityEngine;

namespace UserInputs
{
  public class Playback : UserInput
  {
    protected override void ResetData()
    {
    }

    protected override void UpdateData()
    {
      if (Input.GetKeyDown(KeyCode.Space))
      {
        DataUpdated();
      }
    }
  }
}

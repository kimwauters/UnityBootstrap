using System.Collections.Generic;
using Entitas;
using UnityEngine;
using Entitas.CodeGeneration.Attributes;
using System.Linq;
using TKLibs;

[Meta, Unique]
public class TimeServiceComponent : IComponent
{
  public ITimeService instance;
}
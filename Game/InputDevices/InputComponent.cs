﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharp_ECS;
namespace Game.InputDevices;

struct InputComponent : IComponent
{
    public int Id { get; set; }
}

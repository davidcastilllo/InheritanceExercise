using System;
using System.ComponentModel.DataAnnotations;

namespace Inheritance;

public class Reptile : Animal {
 public bool CanSwim { get; set; }
 public bool LaysEggs { get; set; }
 public string ColdOrHotBlooded { get; set; }
 public string ScalesOrScutes { get; set; }

 public void display() {
  Console.WriteLine($"Hello I am a reptile. Here are some facts about me: It's {IsAlive} I am alive. I am {Age} years old. The {LandSeaAir} is where I reside. I have {LegCount} legs. It's {CanSwim} I can swim. It's {LaysEggs} I lay eggs. I am {ColdOrHotBlooded}. I have {ScalesOrScutes}.");
 }
}
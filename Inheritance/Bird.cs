using System;

namespace Inheritance;

public class Bird : Animal {
 public bool CanFly { get; set; }
 public bool EatsFromSea { get; set; }
 public bool WalksOnLand { get; set; }
 public int NumberOfFeathers { get; set; }
 
 public void display() {
  Console.WriteLine($"Hello I am a bird. Here are some facts about me: It's {IsAlive} I am alive. I am {Age} years old. The {LandSeaAir} is where I reside. I have {LegCount} legs. It's {CanFly} I can fly. It's {EatsFromSea} I eat fish. It's {WalksOnLand} I walk on land. I have {NumberOfFeathers} feathers.");
 }
}
 

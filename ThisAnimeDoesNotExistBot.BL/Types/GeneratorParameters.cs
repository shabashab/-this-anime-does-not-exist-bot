using System;
using ThisAnimeDoesNotExistBot.BL.Types.Interfaces;
using ThisAnimeDoesNotExistBot.BL.Validators;

namespace ThisAnimeDoesNotExistBot.BL.Types
{
  public class GeneratorParameters : IGeneratorParameters
  {
    public uint GenerationSeed { get; private set; }
    public uint  CreativityLevel { get; private set; }
    
    public GeneratorParameters(uint generationSeed, uint creativityLevel)
    {
      GenerationSeed = generationSeed;
      CreativityLevel = creativityLevel;
    }
  }
}
using System;
using System.Security.Policy;
using ThisAnimeDoesNotExistBot.BL.Validators;

namespace ThisAnimeDoesNotExistBot.BL
{
  public class GeneratorParameters : IGeneratorParameters
  {
    public int Seed { get; private set; }
    public int CreativityLevel { get; private set; }

    public GeneratorParameters(int seed, int creativityLevel, ISeedValidator seedValidator = null, ICreativityLevelValidator creativityLevelValidator = null)
    {
      seedValidator ??= new SeedValidator();
      creativityLevelValidator ??= new CreativityLevelValidator();

      bool seedValid = seedValidator.Validate(seed);
      if(seedValid == false)
        throw new ArgumentException("Seed is not valid", nameof(seed));

      bool creativityLevelValid = creativityLevelValidator.Validate(creativityLevel);
      if(creativityLevelValid == false)
        throw new ArgumentException("Creativity level is not valid", nameof(creativityLevel));
      
      Seed = seed;
      CreativityLevel = creativityLevel;
    }
  }
  
}
using System;
using System.Text;
using ThisAnimeDoesNotExistBot.BL.Validators;

namespace ThisAnimeDoesNotExistBot.BL
{
  public class ImageUriBuilder : IUriBuilder
  {
    private readonly IGeneratorParameters _parameters;
    private readonly string _hostName;
    
    public ImageUriBuilder(IGeneratorParameters parameters,
      string hostName,
      IHostNameValidator hostNameValidator = null,
      IGeneratorParametersValidator generatorParametersValidator = null) 
    {
      hostNameValidator ??= 
        new HostNameValidator();
      
      generatorParametersValidator ??= 
        new GeneratorParametersValidator(new SeedValidator(),new CreativityLevelValidator());

      bool parametersValid = generatorParametersValidator.Validate(parameters);
      if(parametersValid == false)
        throw new ArgumentException("Invalid generator parameters", nameof(parameters));

      bool hostNameValid = hostNameValidator.Validate(hostName);
      if (hostNameValid == false)
        throw new ArgumentException("Invalid host name", nameof(hostName));
      
      this._parameters = parameters;
      this._hostName = hostName;
    }
    
    public Uri BuildUri()
    {
      var uriStringBuilder = new StringBuilder();
      
      uriStringBuilder.Append(_hostName);
      uriStringBuilder.AppendFormat("/results/psi-{0}.{1}/seed{2}.png", 
        _parameters.CreativityLevel / 10,
        _parameters.CreativityLevel % 10, 
        _parameters.Seed);

      var uriString = uriStringBuilder.ToString();
      
      var result = new Uri(uriString, UriKind.Absolute);
      return result;
    }
  }
}
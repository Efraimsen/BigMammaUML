using BigMammaV3.Configurations;
using BigMammaV3.Interfaces;
using BigMammaV3.Models;

namespace BigMammaV3.Repositories;

public class MemberRepository : JsonRepository<Member>
{

    public MemberRepository(IJsonService jsonService, AppSettings settings) 
                         : base(jsonService, Path.Combine(settings.Storage.DataDirectory, settings.Storage.MemberFileName))
    {

    }

}

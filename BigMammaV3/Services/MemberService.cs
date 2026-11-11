using BigMammaV3.Interfaces;
using BigMammaV3.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace BigMammaV3.Services;

public class MemberService : IDataHandler
{
    public MemberRepository MemberRepository { get; set; }

    public void CreateMember()
    {

    }
}

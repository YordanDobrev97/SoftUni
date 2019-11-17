using System;
using System.Collections.Generic;
using System.Text;

namespace BirthdayCelebrations
{
    public interface IIdentifiable : IBirthdable
    {
         string Id { get; }
    }
}

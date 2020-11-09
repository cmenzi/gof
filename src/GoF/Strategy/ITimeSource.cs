using System;

namespace GoF
{
    public interface ITimeSource
    {
        DateTime Now { get; }
    }
}
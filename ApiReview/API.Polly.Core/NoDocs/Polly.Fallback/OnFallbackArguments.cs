// Assembly 'Polly.Core'

using System.Runtime.InteropServices;

namespace Polly.Fallback;

[StructLayout(LayoutKind.Sequential, Size = 1)]
public readonly record struct OnFallbackArguments
{
    public OnFallbackArguments();
}

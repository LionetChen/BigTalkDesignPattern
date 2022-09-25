using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightPattern;
public static class Config
{
    public static int ImageSize { get; set; } = SmallSize;
    /// <summary>
    /// 10KB usage per tree ~ 50MB RAM usage per 5000 trees
    /// </summary>
    public const int SmallSize = 1024 * 10;
    /// <summary>
    /// 100MB usage per tree ~ 16GB RAM usage per 160 trees
    /// </summary>
    public const int CrashingSize = 1024 * 1024 * 100;
}

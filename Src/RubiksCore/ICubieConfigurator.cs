
using System.Collections.Generic;

namespace RubiksCore
{
    interface ICubieConfigurator
    {
        IEnumerable<Cubie> CreateCubies(int cubeSize);
    }
}

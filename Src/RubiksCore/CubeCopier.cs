using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubiksCore
{
    /// <summary>
    /// Copies the cubies of an existing RubiksCube
    /// </summary>
    class CubeCopier : ICubieConfigurator
    {
        #region Instance Variables

        RubiksCube _cubeToCopy;

        #endregion

        #region Constructor

        /// <summary>
        /// Creates a new copier
        /// </summary>
        /// <param name="cubeToCopy">The cube that will be copied</param>
        public CubeCopier(RubiksCube cubeToCopy)
        {
            _cubeToCopy = cubeToCopy;
        }

        #endregion

        public IEnumerable<Cubie> CreateCubies(int cubeSize)
        {
            if (cubeSize != _cubeToCopy.CubeSize)
            {
                throw new InvalidOperationException(string.Format("Cannot CreateCubies for {0} size cube. Cube to copy is size {1}", cubeSize, _cubeToCopy.CubeSize));
            }

            return _cubeToCopy.Cubies.Select(cubie => new Cubie(cubie.FrontSide, cubie.BackSide, cubie.RightSide, cubie.LeftSide, cubie.UpSide, cubie.DownSide, cubie.Position)).ToArray();
        }
    }
}

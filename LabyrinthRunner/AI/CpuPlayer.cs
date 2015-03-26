using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LabyrinthRunner.Common;
using LabyrinthRunner.UI;

namespace LabyrinthRunner.AI
{
    class CpuPlayer : Player, IMovable, IRenderable
    {
        // TODO needs implementation of simple AI
        public CpuPlayer()
            : base(1, 1, '*')
        { }

        public override void Move()
        {
            throw new NotImplementedException();
        }

        
    }
}

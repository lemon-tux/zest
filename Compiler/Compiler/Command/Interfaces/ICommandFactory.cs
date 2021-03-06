﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Compiler.Command.Interfaces
{
    public interface ICommandFactory
    {
        IEnumerable<ICommand> CreateCompilerCommands();
    }
}

﻿/*
 * Copyright (c) 2018 Demerzel Solutions Limited
 * This file is part of the Nethermind library.
 *
 * The Nethermind library is free software: you can redistribute it and/or modify
 * it under the terms of the GNU Lesser General Public License as published by
 * the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version.
 *
 * The Nethermind library is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
 * GNU Lesser General Public License for more details.
 *
 * You should have received a copy of the GNU Lesser General Public License
 * along with the Nethermind. If not, see <http://www.gnu.org/licenses/>.
 */

using System.Collections.Generic;
using System.Numerics;
using Nethermind.Core;
using Nethermind.Core.Crypto;
using Nethermind.Core.Encoding;
using Nethermind.Core.Specs;

namespace Ethereum.Test.Base
{
    public class BlockchainTest
    {
        public string Name { get; set; }
        public IReleaseSpec Network { get; set; }
        public IReleaseSpec NetworkAfterTransition { get; set; }
        public BigInteger TransitionBlockNumber { get; set; }
        public Keccak LastBlockHash { get; set; }
        public Rlp GenesisRlp { get; set; }

        public TestBlockJson[] Blocks { get; set; }
        public TestBlockHeaderJson GenesisBlockHeader { get; set; }

        public Dictionary<Address, AccountState> Pre { get; set; }
        public Dictionary<Address, AccountState> PostState { get; set; }
        public bool SealEngineUsed { get; set; }        

        public override string ToString()
        {
            return Name;
        }
    }
}